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
        public static List<DocumentOutputType> AddDocumentOutputTypeData(this S3DbContext c)
        {
            List<DocumentOutputType> DocumentOutputTypes = new List<DocumentOutputType> {
                new DocumentOutputType { DocumentOutputTypeId = new Guid("de4f1d2b-10c3-4a5e-8a9f-9a8f6e0b7c3f"), DocumentOutputTypeName = "PDF" },
                new DocumentOutputType { DocumentOutputTypeId = new Guid("ab9e5f2d-4b3a-48c9-b8a1-6f1d4c7a3e5b"), DocumentOutputTypeName = "PNG" },
                new DocumentOutputType { DocumentOutputTypeId = new Guid("f28b3a5c-79de-46b2-b3d4-4f0c7e6d5a8b"), DocumentOutputTypeName = "Zebra Label Printer" },
                new DocumentOutputType { DocumentOutputTypeId = new Guid("c5b2e7d1-9f3a-4d6c-8b1d-7a4f8e9c3a5b"), DocumentOutputTypeName = "Zebra Continuous Printer" },
                new DocumentOutputType { DocumentOutputTypeId = new Guid("b1d6e4f9-3a8b-41f0-9c2d-5e7f6a2b4d3c"), DocumentOutputTypeName = "Zebra RFID" },
                new DocumentOutputType { DocumentOutputTypeId = new Guid("fa7c2b5e-6e3b-4a9f-b2d1-1d3f9e8b4c7f"), DocumentOutputTypeName = "ZPL" },
                new DocumentOutputType { DocumentOutputTypeId = new Guid("d3a7b5f4-2f1b-4c9e-8a3c-7c5e6b9f2a8d"), DocumentOutputTypeName = "ZPL II" },
                new DocumentOutputType { DocumentOutputTypeId = new Guid("b7f4e3a2-5b8d-4a6f-9c1e-3a2d8b7c5f4e"), DocumentOutputTypeName = "Avery" }
            };

            return DocumentOutputTypes;
        }
    }
}
