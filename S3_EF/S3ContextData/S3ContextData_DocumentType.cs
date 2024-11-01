using S3_Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3_EF
{
    public static partial class S3ContextData
    {
        public static List<DocumentType> AddDocumentTypeData(this S3DbContext c)
        {
            List<DocumentType> DocumentTypes = new List<DocumentType> {
                new DocumentType { DocumentTypeId = new Guid("9f5a8e0a-6f4b-45b7-a09c-678ba9e5f2d3"), DocumentTypeName = "Hunting" },
                new DocumentType { DocumentTypeId = new Guid("2c4e7a8f-d6b9-41e1-a482-91c1e5a7b8e2"), DocumentTypeName = "Fishing" },
                new DocumentType { DocumentTypeId = new Guid("5b3f2d8a-1e9c-4c8a-b6a3-d8f4e1b9a7c5"), DocumentTypeName = "Recreational" },
                new DocumentType { DocumentTypeId = new Guid("7f1a6e9b-8d5c-41a7-b8a1-f3d7e0c2a6b4"), DocumentTypeName = "Bear" },
                new DocumentType { DocumentTypeId = new Guid("e4b1a9d7-c6a8-4c3f-b2e9-a5d7f0b9c2e3"), DocumentTypeName = "Driver's License" },
                new DocumentType { DocumentTypeId = new Guid("a2d3c6f9-4f7b-46c1-b8e2-e5c9a1d0f7b1"), DocumentTypeName = "Gun Permit" },
                new DocumentType { DocumentTypeId = new Guid("3f8b2e1a-9c6a-4d5c-a3b7-f2a7e9c0d8f4"), DocumentTypeName = "Vehicle Registration" },
                new DocumentType { DocumentTypeId = new Guid("c2e9d7f1-5a3f-4b6a-b0a8-9e8d5c1f7b3a"), DocumentTypeName = "Visitor's Pass" },
                new DocumentType { DocumentTypeId = new Guid("d0b8f7e3-a1f5-4c2a-9b8a-6f3c9e7d5b4a"), DocumentTypeName = "RFID" }
            };

            return DocumentTypes;
        }
    }
}
