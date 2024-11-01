using Microsoft.EntityFrameworkCore;

namespace S3_Domain
{
    [PrimaryKey(nameof(DocumentOutputTypeId))]
    public class DocumentOutputType
    {
        public Guid DocumentOutputTypeId { get; set; } = Guid.NewGuid();

        public string DocumentOutputTypeName { get; set; }
    }
}
 