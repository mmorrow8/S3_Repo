using Microsoft.EntityFrameworkCore;

namespace S3_Domain
{
    [PrimaryKey(nameof(DocumentTypeId))]
    public class DocumentType
    {
        public Guid DocumentTypeId { get; set; } = Guid.NewGuid();

        public string DocumentTypeName { get; set; }
    }
}
 