using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using S3_EF;
using System.Net;
using System.Text;
using System.Text.Json;

public class HttpQueryFunction_post
{
    private readonly S3DbContext _context;

    public HttpQueryFunction_post(S3DbContext context)
    {
        _context = context;
    }

    [Function("HttpQueryFunction_post")]
    public async Task<HttpResponseData> Run(
        [HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = "post")] HttpRequestData req)
    {
        var requestBody = await new StreamReader(req.Body).ReadToEndAsync();
        var payload = JsonSerializer.Deserialize<PayloadModel>(requestBody);

        if (payload == null || 
            string.IsNullOrEmpty(payload.state) || 
            string.IsNullOrEmpty(payload.document) || 
            string.IsNullOrEmpty(payload.format) ||
            string.IsNullOrEmpty(payload.name) ||
            string.IsNullOrEmpty(payload.address) ||
            string.IsNullOrEmpty(payload.csz))
        {
            var badRequestResponse = req.CreateResponse(HttpStatusCode.BadRequest);
            await badRequestResponse.WriteStringAsync("Invalid request payload.");
            return badRequestResponse;
        }

        // Parse effectiveStart and effectiveEnd dates
        var effectiveStart = DateTime.ParseExact(payload.effectiveStart, "yyyyMMdd", null);
        var effectiveEnd = (DateTime?)null;

        if (!string.IsNullOrEmpty(payload.effectiveEnd) && payload.effectiveEnd != "null")
            effectiveEnd = DateTime.ParseExact(payload.effectiveEnd, "yyyyMMdd", null);

        var returnDocument = _context.USStateDocumentOutputs
                        .Include(sdo => sdo.USStateDocumentType)
                        .ThenInclude(dt => dt.DocumentType)
                        .Include(sdo => sdo.USStateDocumentType)
                        .ThenInclude(st => st.USState)
                        .Include(sdo => sdo.DocumentOutputType)
                        .Where(sdo => sdo.USStateDocumentType.USState.StateCode == payload.state &&
                                        sdo.USStateDocumentType.DocumentType.DocumentTypeName == payload.document &&
                                        sdo.DocumentOutputType.DocumentOutputTypeName == payload.format &&
                                        sdo.EffectiveStart == effectiveStart &&
                                        sdo.EffectiveEnd == effectiveEnd
                                )
                        .ToList()
                        .FirstOrDefault();

        var zplString = ReplaceZPLVariables(returnDocument?.DocumentContent, payload.name, payload.address, payload.csz);
        
        var zplImageBytes = await GetZPLImageAsync(zplString);
        string zplImageBase64 = zplImageBytes != null ? Convert.ToBase64String(zplImageBytes) : null;

        var response = req.CreateResponse(HttpStatusCode.OK);
        response.Headers.Add("Content-Type", "application/json");

        var responseMessage = new
        {
            returnDocument,
            zplImageBase64, // Include the base64 image string in the response
            zplString
        };

        await response.WriteStringAsync(JsonSerializer.Serialize(responseMessage));
        return response;
    }

    private string ReplaceZPLVariables(byte[] documentContent, string name, string address, string csz)
    {
        var zplString = System.Text.Encoding.UTF8.GetString(documentContent);

        zplString = zplString.Replace("^VName$", name);
        zplString = zplString.Replace("^VAddress$", address);
        zplString = zplString.Replace("^VCSZ$", csz);

        return zplString;
    }

    private async Task<byte[]> GetZPLImageAsync(string zplString)
    {
        var documentContent = System.Text.Encoding.UTF8.GetBytes(zplString);

        using var httpClient = new HttpClient();
        using var content = new ByteArrayContent(documentContent);
        content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/x-www-form-urlencoded");

        try
        {
            // Send the POST request
            var response = await httpClient.PostAsync("http://api.labelary.com/v1/printers/8dpmm/labels/8x6/0/", content);

            // Check if the response is successful
            if (response.IsSuccessStatusCode)
            {
                // Read the response as a byte array
                return await response.Content.ReadAsByteArrayAsync();
            }
            else
            {
                Console.WriteLine("Error: {0}", response.StatusCode);
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Exception: {0}", ex.Message);
            return null;
        }
    }
}

// Define the model for the payload
public class PayloadModel
{
    public string state { get; set; }
    public string document { get; set; }
    public string format { get; set; }
    public string effectiveStart { get; set; }
    public string effectiveEnd { get; set; }
    public string name { get; set; }
    public string address { get; set; }
    public string csz { get; set; }
}