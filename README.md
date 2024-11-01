# S3 - Document Generation Microservice
This Azure function microservice generates documents by accepting a JSON payload that specifies the document type, format, and data to populate. This service is designed for easy integration with other applications needing automated document generation.

## Technologies
I wrote this solution
    .NET Core 8
    EF Core 8
    C#
    Razor
    ASP.NET

It demonstrates my use of 
    DI (dependency injection)
    EF Code First and migrations
    Unit testing that uses an in-memory database context
    LINQ
    JSON
    Javascript

## Example JSON Request
Below is a sample JSON request to generate a document. This JSON payload should be sent to the microservice’s endpoint.

{
  "state": "IL",
  "document": "Hunting",
  "format": "ZPL",
  "effectiveStart": "20240101",
  "effectiveEnd": null,
  "name": "Mark Morrow",
  "address": "123 Main Street",
  "csz": "Mountain View, CA 94040"
}

## Usage
Once the S3 project is running as an Azure function, you can use the S3_Web project to interact with it, or you can send requests to the endpoint directly.
