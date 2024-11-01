using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.EntityFrameworkCore;
using S3_EF;
using System.Net;
using System.Text.Json;

public class HttpQueryFunction_getall
{
    private readonly S3DbContext _context;

    public HttpQueryFunction_getall(S3DbContext context)
    {
        _context = context;
    }

    [Function("HttpQueryFunction_getall")]
    public async Task<HttpResponseData> Run(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "getall")] HttpRequestData req)
    {
        var queryParams = System.Web.HttpUtility.ParseQueryString(req.Url.Query);

        // Set default values for the query parameters
        var param1 = queryParams["doctype"] ?? "default1";
        var param2 = queryParams["statecode"] ?? "default2";
        var param3 = queryParams["outputformat"] ?? "default3";

        var documents = await _context.USStateDocumentOutputs
                        .Include(sdo => sdo.USStateDocumentType)
                        .ThenInclude(dt => dt.DocumentType)
                        .Include(sdo => sdo.USStateDocumentType)
                        .ThenInclude(st => st.USState)                        
                        .Include(sdo => sdo.DocumentOutputType)
                        .ToListAsync();

        var response = req.CreateResponse(HttpStatusCode.OK);
        response.Headers.Add("Content-Type", "application/json");

        var responseMessage = new
        {
            documents
        };

        await response.WriteStringAsync(JsonSerializer.Serialize(responseMessage));
        return response;
    }
}
