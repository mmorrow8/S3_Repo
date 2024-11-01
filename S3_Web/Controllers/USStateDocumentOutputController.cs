using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using S3_Web.Models;
using System.Text;

namespace S3_Web.Controllers
{
    public class USStateDocumentOutputController : Controller
    {
        private readonly HttpClient _httpClient;

        public USStateDocumentOutputController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IActionResult> Index()
        {
            // API endpoint URL
            var apiUrl = "http://localhost:7072/S3/getall";

            // Call the API
            var response = await _httpClient.GetAsync(apiUrl);
            response.EnsureSuccessStatusCode();

            // Deserialize the JSON response
            var jsonData = await response.Content.ReadAsStringAsync();
            var data = JsonConvert.DeserializeObject<DocumentData>(jsonData);

            // Pass the deserialized data to the view
            return View(data.Documents);
        }

        [HttpPost]
        public async Task<IActionResult> Details([FromBody] DetailsRequestModel request)
        {
            if (request == null || string.IsNullOrEmpty(request.state) || string.IsNullOrEmpty(request.document) || string.IsNullOrEmpty(request.format))
            {
                return BadRequest("Missing parameters.");
            }

            // Create the JSON content to send to the Azure Function
            var jsonContent = JsonConvert.SerializeObject(new
            {
                state = request.state,
                document = request.document,
                format = request.format,
                effectiveStart = request.effectiveStart,
                effectiveEnd = request.effectiveEnd,
                name = request.name,
                address = request.address,
                csz = request.csz
            });

            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            // Send a POST request to the Azure Function with the JSON body
            var apiUrl = "http://localhost:7072/S3/post"; // Azure Function URL
            var response = await _httpClient.PostAsync(apiUrl, content);

            if (!response.IsSuccessStatusCode)
            {
                return StatusCode((int)response.StatusCode, "Failed to fetch details.");
            }

            var details = await response.Content.ReadAsStringAsync();


            // Pass the data to the view
            var model = JsonConvert.DeserializeObject<USStateDocumentOutputViewModel>(details);
            return View(model);
        }
    }
}

public class DetailsRequestModel
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