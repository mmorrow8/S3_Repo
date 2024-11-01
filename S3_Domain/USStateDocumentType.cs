using Microsoft.EntityFrameworkCore;
using S3_Domain;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace S3_Domain
{
    [PrimaryKey(nameof(USStateDocumentTypeId))]
    [Index(nameof(USStateId), nameof(DocumentTypeId), IsUnique = true)]
    
    public class USStateDocumentType
    {
        public Guid USStateDocumentTypeId { get; set; } = Guid.NewGuid();

        // Foreign key to USState
        [ForeignKey("USState")]
        public Guid USStateId { get; set; }
        public USState? USState { get; set; }

        // Foreign key to DocumentType
        [ForeignKey("DocumentType")]
        public Guid DocumentTypeId { get; set; }
        public DocumentType? DocumentType { get; set; }
    }
}