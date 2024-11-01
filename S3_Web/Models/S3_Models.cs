namespace S3_Web.Models
{
    public class USState
    {
        public Guid StateId { get; set; }
        public string StateCode { get; set; }
        public string StateName { get; set; }
    }

    public class DocumentType
    {
        public Guid DocumentTypeId { get; set; }
        public string DocumentTypeName { get; set; }
    }

    public class DocumentOutputType
    {
        public Guid DocumentOutputTypeId { get; set; }
        public string DocumentOutputTypeName { get; set; }
    }

    public class USStateDocumentType
    {
        public Guid USStateDocumentTypeId { get; set; }
        public Guid USStateId { get; set; }
        public USState USState { get; set; }
        public Guid DocumentTypeId { get; set; }
        public DocumentType DocumentType { get; set; }
    }

    public class USStateDocumentOutput
    {
        public Guid USStateDocumentOutputId { get; set; }
        public Guid USStateDocumentTypeId { get; set; }
        public USStateDocumentType USStateDocumentType { get; set; }
        public Guid DocumentOutputTypeId { get; set; }
        public DocumentOutputType DocumentOutputType { get; set; }
        public DateTime EffectiveStart { get; set; }
        public DateTime? EffectiveEnd { get; set; }
        public string DocumentContent { get; set; }
    }

    public class DocumentData
    {
        public List<USStateDocumentOutput> Documents { get; set; }
    }

    public class USStateDocumentOutputViewModel
    {
        public USStateDocumentOutput ReturnDocument { get; set; }
        public string zplImageBase64 { get; set; }
        public string zplString { get; set; }
    }
}
