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
        public static List<USState> AddStateData(this S3DbContext c)
        {
            List<USState> USStates = new List<USState> {
                new USState { StateId = new Guid("d48f8d94-8a20-4c2e-b276-29fd451f8c45"), StateName = "Alabama", StateCode = "AL" },
                new USState { StateId = new Guid("ef6b8345-345f-4a88-917c-2f1534e5de9a"), StateName = "Alaska", StateCode = "AK" },
                new USState { StateId = new Guid("6d7597b9-8391-4cb4-b0a9-103b12e7840e"), StateName = "Arizona", StateCode = "AZ" },
                new USState { StateId = new Guid("af5d2f13-dc73-4b49-8d8f-c540fefc9675"), StateName = "Arkansas", StateCode = "AR" },
                new USState { StateId = new Guid("87dbb6c7-6fae-45e1-91b3-5642ae7381d1"), StateName = "California", StateCode = "CA" },
                new USState { StateId = new Guid("3c58b3a4-4e78-4f85-8ed1-f1a5d6f99823"), StateName = "Colorado", StateCode = "CO" },
                new USState { StateId = new Guid("2b1eaf64-8d02-4b0b-8e8c-e6a9baff5c5c"), StateName = "Connecticut", StateCode = "CT" },
                new USState { StateId = new Guid("e44106ff-16b1-4a69-9788-c715f85b06b5"), StateName = "Delaware", StateCode = "DE" },
                new USState { StateId = new Guid("d04cb85c-81e1-4e43-b828-594b799a2c8a"), StateName = "Florida", StateCode = "FL" },
                new USState { StateId = new Guid("3f8e845a-08ec-4f57-bc47-bf85f594f738"), StateName = "Georgia", StateCode = "GA" },
                new USState { StateId = new Guid("40e55c1a-8723-4be4-89d9-38c423b19c1a"), StateName = "Hawaii", StateCode = "HI" },
                new USState { StateId = new Guid("2f5af7ba-6f5e-4d6a-9a10-638b2dc94b24"), StateName = "Idaho", StateCode = "ID" },
                new USState { StateId = new Guid("a4e71c3d-2efc-42d6-a0c9-bd95dc35a654"), StateName = "Illinois", StateCode = "IL" },
                new USState { StateId = new Guid("598b8d23-4bcb-4018-b805-b8a2e8bde473"), StateName = "Indiana", StateCode = "IN" },
                new USState { StateId = new Guid("9d93e72f-8a10-4b68-a8cd-b492fd6e6cd1"), StateName = "Iowa", StateCode = "IA" },
                new USState { StateId = new Guid("7252b347-bd2f-4f8e-9cd1-18337c2c84d2"), StateName = "Kansas", StateCode = "KS" },
                new USState { StateId = new Guid("34ab1d14-2e4f-497b-b9f1-80b5d98e137e"), StateName = "Kentucky", StateCode = "KY" },
                new USState { StateId = new Guid("fd439a35-5916-4ab3-84dc-98551ae9735f"), StateName = "Louisiana", StateCode = "LA" },
                new USState { StateId = new Guid("f2b27896-dfc7-4b3d-b7cb-439a8fdfbb38"), StateName = "Maine", StateCode = "ME" },
                new USState { StateId = new Guid("8f643b5f-f6f0-4f3b-b8cd-8bfabc1c97d1"), StateName = "Maryland", StateCode = "MD" },
                new USState { StateId = new Guid("c80b2b14-b5fc-40ae-8785-3d4a3e4fa946"), StateName = "Massachusetts", StateCode = "MA" },
                new USState { StateId = new Guid("b2143e24-8e4f-4d0e-b051-1cfb5e7b5a47"), StateName = "Michigan", StateCode = "MI" },
                new USState { StateId = new Guid("e7a82fb6-a8ff-4076-9b7d-2c8f6c8e8e13"), StateName = "Minnesota", StateCode = "MN" },
                new USState { StateId = new Guid("68b7c6df-c7f1-42a9-88a5-eaf3c628413f"), StateName = "Mississippi", StateCode = "MS" },
                new USState { StateId = new Guid("dd32bc36-093d-4e29-bb63-173a8c01a5e5"), StateName = "Missouri", StateCode = "MO" },
                new USState { StateId = new Guid("4f7d50e3-f3cf-4d5d-988a-cb6bfbdb5a48"), StateName = "Montana", StateCode = "MT" },
                new USState { StateId = new Guid("a2df4e7c-8923-49cb-81cb-bc6be193a5d4"), StateName = "Nebraska", StateCode = "NE" },
                new USState { StateId = new Guid("04b0b346-73c1-49b5-9d5a-435ce6291b27"), StateName = "Nevada", StateCode = "NV" },
                new USState { StateId = new Guid("f3a8c7b9-2c37-47d2-9076-1c25f98bba16"), StateName = "New Hampshire", StateCode = "NH" },
                new USState { StateId = new Guid("3de879f6-b45e-4038-bcd1-d2b8c1a285b8"), StateName = "New Jersey", StateCode = "NJ" },
                new USState { StateId = new Guid("6939c6b2-c4a4-43d9-8c3e-8fbc714fb6c6"), StateName = "New Mexico", StateCode = "NM" },
                new USState { StateId = new Guid("c1e4d92e-8960-4535-8a5e-bb041f37834d"), StateName = "New York", StateCode = "NY" },
                new USState { StateId = new Guid("80b5c7a2-4a45-4312-9e3d-d34b7f267154"), StateName = "North Carolina", StateCode = "NC" },
                new USState { StateId = new Guid("7a6d8e5e-9b87-43a1-8b4f-f3a30c85719b"), StateName = "North Dakota", StateCode = "ND" },
                new USState { StateId = new Guid("f3b1ad4e-dad5-4a71-879c-e6fb30e4d292"), StateName = "Ohio", StateCode = "OH" },
                new USState { StateId = new Guid("8f2b63d2-bfde-4e27-8059-2bfc6275b6af"), StateName = "Oklahoma", StateCode = "OK" },
                new USState { StateId = new Guid("f4a2d91e-b95f-42b3-82fc-dc3b6825c182"), StateName = "Oregon", StateCode = "OR" },
                new USState { StateId = new Guid("12ae6e82-56c9-41fa-8d21-7c5f0e1875a3"), StateName = "Pennsylvania", StateCode = "PA" },
                new USState { StateId = new Guid("b834f37e-2084-49ad-a11b-c8b9ec967c61"), StateName = "Rhode Island", StateCode = "RI" },
                new USState { StateId = new Guid("c2b3dfc4-69e2-4745-94d5-29ec51b7d5f9"), StateName = "South Carolina", StateCode = "SC" },
                new USState { StateId = new Guid("d7eec652-9d38-4b7c-9b73-6aef6341c531"), StateName = "South Dakota", StateCode = "SD" },
                new USState { StateId = new Guid("76b7c5a9-4387-4b9d-93b6-c451fb4e8267"), StateName = "Tennessee", StateCode = "TN" },
                new USState { StateId = new Guid("f4e28a12-2e52-41b2-a16d-3e9b8b2d4b94"), StateName = "Texas", StateCode = "TX" },
                new USState { StateId = new Guid("8f6e59a8-41cf-4da5-bf96-68b2308727c9"), StateName = "Utah", StateCode = "UT" },
                new USState { StateId = new Guid("17c8eb5a-b72f-4e3c-bd45-f621d2a9b6a3"), StateName = "Vermont", StateCode = "VT" },
                new USState { StateId = new Guid("7b5398f5-4a56-47e6-8715-91b4f5d38f96"), StateName = "Virginia", StateCode = "VA" },
                new USState { StateId = new Guid("c8d7f839-3924-4781-b9e4-5837d5ef4b79"), StateName = "Washington", StateCode = "WA" },
                new USState { StateId = new Guid("4d63bf7e-1832-4829-b2d7-39b8e5ad1423"), StateName = "West Virginia", StateCode = "WV" },
                new USState { StateId = new Guid("df5728ae-732a-4d73-93c1-16f5e1b5e4d8"), StateName = "Wisconsin", StateCode = "WI" },
                new USState { StateId = new Guid("6a7d5f3e-f6ad-4da2-91b7-e68c4fdb6c5b"), StateName = "Wyoming", StateCode = "WY" },
                new USState { StateId = new Guid("e0f3a7c5-1d8b-4a2e-8f9c-3b5f7d0c9ea5"), StateName = "US (Federal)", StateCode = "US" }
            };

            return USStates;
        }
    }
}
