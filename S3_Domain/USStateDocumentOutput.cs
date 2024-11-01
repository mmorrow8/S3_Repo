using Microsoft.EntityFrameworkCore;
using S3_Domain;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace S3_Domain
{
    [PrimaryKey(nameof(USStateDocumentOutputId))]
    [Index(nameof(USStateDocumentTypeId), nameof(DocumentOutputTypeId), nameof(EffectiveStart), IsUnique = true)]
    
    public class USStateDocumentOutput
    {
        public Guid USStateDocumentOutputId { get; set; } = Guid.NewGuid();

        // Foreign key to USStateDocumentType
        [ForeignKey("USStateDocumentType")]
        public Guid USStateDocumentTypeId { get; set; }
        public USStateDocumentType? USStateDocumentType { get; set; }

        // Foreign key to DocumentOutputType
        [ForeignKey("DocumentOutputType")]
        public Guid DocumentOutputTypeId { get; set; }
        public DocumentOutputType? DocumentOutputType { get; set; }

        public DateTime EffectiveStart { get; set; }

        public DateTime? EffectiveEnd { get; set; }

        public byte[] DocumentContent { get; set; }
    }
}