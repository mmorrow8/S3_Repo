﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace S3_EF.Migrations
{
    /// <inheritdoc />
    public partial class migration1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DocumentOutputTypes",
                columns: table => new
                {
                    DocumentOutputTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DocumentOutputTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentOutputTypes", x => x.DocumentOutputTypeId);
                });

            migrationBuilder.CreateTable(
                name: "DocumentTypes",
                columns: table => new
                {
                    DocumentTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DocumentTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentTypes", x => x.DocumentTypeId);
                });

            migrationBuilder.CreateTable(
                name: "USStates",
                columns: table => new
                {
                    StateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StateCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StateName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USStates", x => x.StateId);
                });

            migrationBuilder.CreateTable(
                name: "USStateDocumentTypes",
                columns: table => new
                {
                    USStateDocumentTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    USStateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DocumentTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USStateDocumentTypes", x => x.USStateDocumentTypeId);
                    table.ForeignKey(
                        name: "FK_USStateDocumentTypes_DocumentTypes_DocumentTypeId",
                        column: x => x.DocumentTypeId,
                        principalTable: "DocumentTypes",
                        principalColumn: "DocumentTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_USStateDocumentTypes_USStates_USStateId",
                        column: x => x.USStateId,
                        principalTable: "USStates",
                        principalColumn: "StateId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "USStateDocumentOutputs",
                columns: table => new
                {
                    USStateDocumentOutputId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    USStateDocumentTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DocumentOutputTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EffectiveStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EffectiveEnd = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DocumentContent = table.Column<byte[]>(type: "varbinary(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USStateDocumentOutputs", x => x.USStateDocumentOutputId);
                    table.ForeignKey(
                        name: "FK_USStateDocumentOutputs_DocumentOutputTypes_DocumentOutputTypeId",
                        column: x => x.DocumentOutputTypeId,
                        principalTable: "DocumentOutputTypes",
                        principalColumn: "DocumentOutputTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_USStateDocumentOutputs_USStateDocumentTypes_USStateDocumentTypeId",
                        column: x => x.USStateDocumentTypeId,
                        principalTable: "USStateDocumentTypes",
                        principalColumn: "USStateDocumentTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "DocumentOutputTypes",
                columns: new[] { "DocumentOutputTypeId", "DocumentOutputTypeName" },
                values: new object[,]
                {
                    { new Guid("ab9e5f2d-4b3a-48c9-b8a1-6f1d4c7a3e5b"), "PNG" },
                    { new Guid("b1d6e4f9-3a8b-41f0-9c2d-5e7f6a2b4d3c"), "Zebra RFID" },
                    { new Guid("b7f4e3a2-5b8d-4a6f-9c1e-3a2d8b7c5f4e"), "Avery" },
                    { new Guid("c5b2e7d1-9f3a-4d6c-8b1d-7a4f8e9c3a5b"), "Zebra Continuous Printer" },
                    { new Guid("d3a7b5f4-2f1b-4c9e-8a3c-7c5e6b9f2a8d"), "ZPL II" },
                    { new Guid("de4f1d2b-10c3-4a5e-8a9f-9a8f6e0b7c3f"), "PDF" },
                    { new Guid("f28b3a5c-79de-46b2-b3d4-4f0c7e6d5a8b"), "Zebra Label Printer" },
                    { new Guid("fa7c2b5e-6e3b-4a9f-b2d1-1d3f9e8b4c7f"), "ZPL" }
                });

            migrationBuilder.InsertData(
                table: "DocumentTypes",
                columns: new[] { "DocumentTypeId", "DocumentTypeName" },
                values: new object[,]
                {
                    { new Guid("2c4e7a8f-d6b9-41e1-a482-91c1e5a7b8e2"), "Fishing" },
                    { new Guid("3f8b2e1a-9c6a-4d5c-a3b7-f2a7e9c0d8f4"), "Vehicle Registration" },
                    { new Guid("5b3f2d8a-1e9c-4c8a-b6a3-d8f4e1b9a7c5"), "Recreational" },
                    { new Guid("7f1a6e9b-8d5c-41a7-b8a1-f3d7e0c2a6b4"), "Bear" },
                    { new Guid("9f5a8e0a-6f4b-45b7-a09c-678ba9e5f2d3"), "Hunting" },
                    { new Guid("a2d3c6f9-4f7b-46c1-b8e2-e5c9a1d0f7b1"), "Gun Permit" },
                    { new Guid("c2e9d7f1-5a3f-4b6a-b0a8-9e8d5c1f7b3a"), "Visitor's Pass" },
                    { new Guid("d0b8f7e3-a1f5-4c2a-9b8a-6f3c9e7d5b4a"), "RFID" },
                    { new Guid("e4b1a9d7-c6a8-4c3f-b2e9-a5d7f0b9c2e3"), "Driver's License" }
                });

            migrationBuilder.InsertData(
                table: "USStates",
                columns: new[] { "StateId", "StateCode", "StateName" },
                values: new object[,]
                {
                    { new Guid("04b0b346-73c1-49b5-9d5a-435ce6291b27"), "NV", "Nevada" },
                    { new Guid("12ae6e82-56c9-41fa-8d21-7c5f0e1875a3"), "PA", "Pennsylvania" },
                    { new Guid("17c8eb5a-b72f-4e3c-bd45-f621d2a9b6a3"), "VT", "Vermont" },
                    { new Guid("2b1eaf64-8d02-4b0b-8e8c-e6a9baff5c5c"), "CT", "Connecticut" },
                    { new Guid("2f5af7ba-6f5e-4d6a-9a10-638b2dc94b24"), "ID", "Idaho" },
                    { new Guid("34ab1d14-2e4f-497b-b9f1-80b5d98e137e"), "KY", "Kentucky" },
                    { new Guid("3c58b3a4-4e78-4f85-8ed1-f1a5d6f99823"), "CO", "Colorado" },
                    { new Guid("3de879f6-b45e-4038-bcd1-d2b8c1a285b8"), "NJ", "New Jersey" },
                    { new Guid("3f8e845a-08ec-4f57-bc47-bf85f594f738"), "GA", "Georgia" },
                    { new Guid("40e55c1a-8723-4be4-89d9-38c423b19c1a"), "HI", "Hawaii" },
                    { new Guid("4d63bf7e-1832-4829-b2d7-39b8e5ad1423"), "WV", "West Virginia" },
                    { new Guid("4f7d50e3-f3cf-4d5d-988a-cb6bfbdb5a48"), "MT", "Montana" },
                    { new Guid("598b8d23-4bcb-4018-b805-b8a2e8bde473"), "IN", "Indiana" },
                    { new Guid("68b7c6df-c7f1-42a9-88a5-eaf3c628413f"), "MS", "Mississippi" },
                    { new Guid("6939c6b2-c4a4-43d9-8c3e-8fbc714fb6c6"), "NM", "New Mexico" },
                    { new Guid("6a7d5f3e-f6ad-4da2-91b7-e68c4fdb6c5b"), "WY", "Wyoming" },
                    { new Guid("6d7597b9-8391-4cb4-b0a9-103b12e7840e"), "AZ", "Arizona" },
                    { new Guid("7252b347-bd2f-4f8e-9cd1-18337c2c84d2"), "KS", "Kansas" },
                    { new Guid("76b7c5a9-4387-4b9d-93b6-c451fb4e8267"), "TN", "Tennessee" },
                    { new Guid("7a6d8e5e-9b87-43a1-8b4f-f3a30c85719b"), "ND", "North Dakota" },
                    { new Guid("7b5398f5-4a56-47e6-8715-91b4f5d38f96"), "VA", "Virginia" },
                    { new Guid("80b5c7a2-4a45-4312-9e3d-d34b7f267154"), "NC", "North Carolina" },
                    { new Guid("87dbb6c7-6fae-45e1-91b3-5642ae7381d1"), "CA", "California" },
                    { new Guid("8f2b63d2-bfde-4e27-8059-2bfc6275b6af"), "OK", "Oklahoma" },
                    { new Guid("8f643b5f-f6f0-4f3b-b8cd-8bfabc1c97d1"), "MD", "Maryland" },
                    { new Guid("8f6e59a8-41cf-4da5-bf96-68b2308727c9"), "UT", "Utah" },
                    { new Guid("9d93e72f-8a10-4b68-a8cd-b492fd6e6cd1"), "IA", "Iowa" },
                    { new Guid("a2df4e7c-8923-49cb-81cb-bc6be193a5d4"), "NE", "Nebraska" },
                    { new Guid("a4e71c3d-2efc-42d6-a0c9-bd95dc35a654"), "IL", "Illinois" },
                    { new Guid("af5d2f13-dc73-4b49-8d8f-c540fefc9675"), "AR", "Arkansas" },
                    { new Guid("b2143e24-8e4f-4d0e-b051-1cfb5e7b5a47"), "MI", "Michigan" },
                    { new Guid("b834f37e-2084-49ad-a11b-c8b9ec967c61"), "RI", "Rhode Island" },
                    { new Guid("c1e4d92e-8960-4535-8a5e-bb041f37834d"), "NY", "New York" },
                    { new Guid("c2b3dfc4-69e2-4745-94d5-29ec51b7d5f9"), "SC", "South Carolina" },
                    { new Guid("c80b2b14-b5fc-40ae-8785-3d4a3e4fa946"), "MA", "Massachusetts" },
                    { new Guid("c8d7f839-3924-4781-b9e4-5837d5ef4b79"), "WA", "Washington" },
                    { new Guid("d04cb85c-81e1-4e43-b828-594b799a2c8a"), "FL", "Florida" },
                    { new Guid("d48f8d94-8a20-4c2e-b276-29fd451f8c45"), "AL", "Alabama" },
                    { new Guid("d7eec652-9d38-4b7c-9b73-6aef6341c531"), "SD", "South Dakota" },
                    { new Guid("dd32bc36-093d-4e29-bb63-173a8c01a5e5"), "MO", "Missouri" },
                    { new Guid("df5728ae-732a-4d73-93c1-16f5e1b5e4d8"), "WI", "Wisconsin" },
                    { new Guid("e0f3a7c5-1d8b-4a2e-8f9c-3b5f7d0c9ea5"), "US", "US (Federal)" },
                    { new Guid("e44106ff-16b1-4a69-9788-c715f85b06b5"), "DE", "Delaware" },
                    { new Guid("e7a82fb6-a8ff-4076-9b7d-2c8f6c8e8e13"), "MN", "Minnesota" },
                    { new Guid("ef6b8345-345f-4a88-917c-2f1534e5de9a"), "AK", "Alaska" },
                    { new Guid("f2b27896-dfc7-4b3d-b7cb-439a8fdfbb38"), "ME", "Maine" },
                    { new Guid("f3a8c7b9-2c37-47d2-9076-1c25f98bba16"), "NH", "New Hampshire" },
                    { new Guid("f3b1ad4e-dad5-4a71-879c-e6fb30e4d292"), "OH", "Ohio" },
                    { new Guid("f4a2d91e-b95f-42b3-82fc-dc3b6825c182"), "OR", "Oregon" },
                    { new Guid("f4e28a12-2e52-41b2-a16d-3e9b8b2d4b94"), "TX", "Texas" },
                    { new Guid("fd439a35-5916-4ab3-84dc-98551ae9735f"), "LA", "Louisiana" }
                });

            migrationBuilder.InsertData(
                table: "USStateDocumentTypes",
                columns: new[] { "USStateDocumentTypeId", "DocumentTypeId", "USStateId" },
                values: new object[,]
                {
                    { new Guid("a1e9f2c7-8f3d-4a0c-9b5e-d4f3c2b7a9e6"), new Guid("7f1a6e9b-8d5c-41a7-b8a1-f3d7e0c2a6b4"), new Guid("7b5398f5-4a56-47e6-8715-91b4f5d38f96") },
                    { new Guid("a3c9f8b5-7e1f-4a2b-9d5c-e4d1b2a7f3c9"), new Guid("a2d3c6f9-4f7b-46c1-b8e2-e5c9a1d0f7b1"), new Guid("c1e4d92e-8960-4535-8a5e-bb041f37834d") },
                    { new Guid("a4b8d7c3-2e9f-4f1a-9c8b-d3e5c2a9f1b6"), new Guid("2c4e7a8f-d6b9-41e1-a482-91c1e5a7b8e2"), new Guid("12ae6e82-56c9-41fa-8d21-7c5f0e1875a3") },
                    { new Guid("a4f5b3e7-8c2a-4d0e-9b7f-d2c8f1a9e3b4"), new Guid("e4b1a9d7-c6a8-4c3f-b2e9-a5d7f0b9c2e3"), new Guid("3de879f6-b45e-4038-bcd1-d2b8c1a285b8") },
                    { new Guid("a5f3d2c8-7b0e-4e9f-8d1c-b7a6f2e9c4d3"), new Guid("e4b1a9d7-c6a8-4c3f-b2e9-a5d7f0b9c2e3"), new Guid("40e55c1a-8723-4be4-89d9-38c423b19c1a") },
                    { new Guid("a7c9f2b1-5d3a-4f0e-8d1f-b9a4d3e8f6c5"), new Guid("c2e9d7f1-5a3f-4b6a-b0a8-9e8d5c1f7b3a"), new Guid("87dbb6c7-6fae-45e1-91b3-5642ae7381d1") },
                    { new Guid("a7d4e1c9-7f5b-4c9e-9d3f-a4b6f5d8c2b1"), new Guid("d0b8f7e3-a1f5-4c2a-9b8a-6f3c9e7d5b4a"), new Guid("7252b347-bd2f-4f8e-9cd1-18337c2c84d2") },
                    { new Guid("a7d4e9c1-3f5a-4c8b-8d2f-f6e3b1d5a2c8"), new Guid("a2d3c6f9-4f7b-46c1-b8e2-e5c9a1d0f7b1"), new Guid("80b5c7a2-4a45-4312-9e3d-d34b7f267154") },
                    { new Guid("a7d5f1c9-3b8f-4d0e-9a2f-e5b9c3f4d6a1"), new Guid("c2e9d7f1-5a3f-4b6a-b0a8-9e8d5c1f7b3a"), new Guid("d7eec652-9d38-4b7c-9b73-6aef6341c531") },
                    { new Guid("a8e3f1c5-4d7f-4b9e-9a2c-c6f4b3d2a7e5"), new Guid("7f1a6e9b-8d5c-41a7-b8a1-f3d7e0c2a6b4"), new Guid("e44106ff-16b1-4a69-9788-c715f85b06b5") },
                    { new Guid("a9e3d2c7-8f1d-4f0a-9c2e-b3f5a7d6e1c9"), new Guid("2c4e7a8f-d6b9-41e1-a482-91c1e5a7b8e2"), new Guid("d48f8d94-8a20-4c2e-b276-29fd451f8c45") },
                    { new Guid("a9f1d3c7-5b8e-4c7a-9f3d-d6a7c8b4e2f1"), new Guid("7f1a6e9b-8d5c-41a7-b8a1-f3d7e0c2a6b4"), new Guid("4d63bf7e-1832-4829-b2d7-39b8e5ad1423") },
                    { new Guid("b1e9f4c7-8a3d-4c1b-8f6e-d3a5c7b2e9f8"), new Guid("d0b8f7e3-a1f5-4c2a-9b8a-6f3c9e7d5b4a"), new Guid("8f6e59a8-41cf-4da5-bf96-68b2308727c9") },
                    { new Guid("b1f3d2e9-4c7a-4d8f-9e5c-a8f7b6c3e2d4"), new Guid("e4b1a9d7-c6a8-4c3f-b2e9-a5d7f0b9c2e3"), new Guid("7a6d8e5e-9b87-43a1-8b4f-f3a30c85719b") },
                    { new Guid("b1f3d4e7-9f2c-4e5d-8b1f-c4d2a8b7f3e1"), new Guid("9f5a8e0a-6f4b-45b7-a09c-678ba9e5f2d3"), new Guid("d48f8d94-8a20-4c2e-b276-29fd451f8c45") },
                    { new Guid("b2a9c8f3-7f5d-4e0b-8d2f-e1f4c3a6b9d7"), new Guid("2c4e7a8f-d6b9-41e1-a482-91c1e5a7b8e2"), new Guid("598b8d23-4bcb-4018-b805-b8a2e8bde473") },
                    { new Guid("b2c5a8e7-3d1f-4e0a-9f6c-e8b1d5c2a7e4"), new Guid("e4b1a9d7-c6a8-4c3f-b2e9-a5d7f0b9c2e3"), new Guid("2b1eaf64-8d02-4b0b-8e8c-e6a9baff5c5c") },
                    { new Guid("b2d4c8a3-3e1f-4c9d-8f2b-a7f6d9e5c1b4"), new Guid("2c4e7a8f-d6b9-41e1-a482-91c1e5a7b8e2"), new Guid("c1e4d92e-8960-4535-8a5e-bb041f37834d") },
                    { new Guid("b2f8a3c9-7f1d-4c3e-9d5a-f6d2e5a7b3c4"), new Guid("7f1a6e9b-8d5c-41a7-b8a1-f3d7e0c2a6b4"), new Guid("8f643b5f-f6f0-4f3b-b8cd-8bfabc1c97d1") },
                    { new Guid("b3a9e5f2-8c7f-4d0a-8d2b-a5f1e7c3d6f9"), new Guid("2c4e7a8f-d6b9-41e1-a482-91c1e5a7b8e2"), new Guid("3c58b3a4-4e78-4f85-8ed1-f1a5d6f99823") },
                    { new Guid("b3c9e8d2-7a4f-4f0a-9d2e-f5a1d3c7b9e6"), new Guid("c2e9d7f1-5a3f-4b6a-b0a8-9e8d5c1f7b3a"), new Guid("80b5c7a2-4a45-4312-9e3d-d34b7f267154") },
                    { new Guid("b3d7f9e2-4a5c-4e1a-8f7b-d6a9c4b2e3f1"), new Guid("e4b1a9d7-c6a8-4c3f-b2e9-a5d7f0b9c2e3"), new Guid("12ae6e82-56c9-41fa-8d21-7c5f0e1875a3") },
                    { new Guid("b3d9f1a7-8e5f-4c1b-9a3e-c6f2d7e9b5c4"), new Guid("2c4e7a8f-d6b9-41e1-a482-91c1e5a7b8e2"), new Guid("87dbb6c7-6fae-45e1-91b3-5642ae7381d1") },
                    { new Guid("b3e7f5a2-8d1c-4f0e-9a3f-e4c9b6d2f5a7"), new Guid("5b3f2d8a-1e9c-4c8a-b6a3-d8f4e1b9a7c5"), new Guid("c8d7f839-3924-4781-b9e4-5837d5ef4b79") },
                    { new Guid("b3e8f2d9-7c1a-4f0d-8b5e-d2f7a9c6b1e4"), new Guid("9f5a8e0a-6f4b-45b7-a09c-678ba9e5f2d3"), new Guid("d04cb85c-81e1-4e43-b828-594b799a2c8a") },
                    { new Guid("b3f9d8e4-5c1a-4e7b-8f2d-a6e4c7b3d5a9"), new Guid("2c4e7a8f-d6b9-41e1-a482-91c1e5a7b8e2"), new Guid("b2143e24-8e4f-4d0e-b051-1cfb5e7b5a47") },
                    { new Guid("b4c7a9e3-8f1d-4f0a-9e3c-d2f6b8a7c1e9"), new Guid("7f1a6e9b-8d5c-41a7-b8a1-f3d7e0c2a6b4"), new Guid("c2b3dfc4-69e2-4745-94d5-29ec51b7d5f9") },
                    { new Guid("b4d3e2a9-7f8e-4c1a-9d5b-e7a2f1c5d3f9"), new Guid("e4b1a9d7-c6a8-4c3f-b2e9-a5d7f0b9c2e3"), new Guid("a4e71c3d-2efc-42d6-a0c9-bd95dc35a654") },
                    { new Guid("b4d3f2e8-8f5a-4c7e-9d1f-c5e2a7b9d6f3"), new Guid("e4b1a9d7-c6a8-4c3f-b2e9-a5d7f0b9c2e3"), new Guid("7b5398f5-4a56-47e6-8715-91b4f5d38f96") },
                    { new Guid("b4e9c5a7-3f2d-4a8c-9f1e-a7d3f9b6c2e4"), new Guid("7f1a6e9b-8d5c-41a7-b8a1-f3d7e0c2a6b4"), new Guid("3de879f6-b45e-4038-bcd1-d2b8c1a285b8") },
                    { new Guid("b5d2f1e8-4c7f-4a9c-8d5b-a7f4c3d1e6b9"), new Guid("a2d3c6f9-4f7b-46c1-b8e2-e5c9a1d0f7b1"), new Guid("87dbb6c7-6fae-45e1-91b3-5642ae7381d1") },
                    { new Guid("b5d8f1c3-7a4e-4c9a-8d3f-a7c6e2f4d1b9"), new Guid("5b3f2d8a-1e9c-4c8a-b6a3-d8f4e1b9a7c5"), new Guid("17c8eb5a-b72f-4e3c-bd45-f621d2a9b6a3") },
                    { new Guid("b7a5f1c9-3d6f-4e0d-9a2c-e1c3f4b8d5a7"), new Guid("2c4e7a8f-d6b9-41e1-a482-91c1e5a7b8e2"), new Guid("3de879f6-b45e-4038-bcd1-d2b8c1a285b8") },
                    { new Guid("b7d3a8e9-9f2c-4e5a-8b1f-d9e5c4f3a6b7"), new Guid("e4b1a9d7-c6a8-4c3f-b2e9-a5d7f0b9c2e3"), new Guid("6a7d5f3e-f6ad-4da2-91b7-e68c4fdb6c5b") },
                    { new Guid("b7e1a3d4-3f9b-4d2e-9c1f-a9c8d5b6e2f7"), new Guid("3f8b2e1a-9c6a-4d5c-a3b7-f2a7e9c0d8f4"), new Guid("68b7c6df-c7f1-42a9-88a5-eaf3c628413f") },
                    { new Guid("b7e2c9a1-3f8d-4a0b-9e5f-a6c1d4f3b7e2"), new Guid("e4b1a9d7-c6a8-4c3f-b2e9-a5d7f0b9c2e3"), new Guid("f3a8c7b9-2c37-47d2-9076-1c25f98bba16") },
                    { new Guid("b7e2f1a3-9f5d-4c6a-8e2f-d1a8b9c4f3e5"), new Guid("e4b1a9d7-c6a8-4c3f-b2e9-a5d7f0b9c2e3"), new Guid("34ab1d14-2e4f-497b-b9f1-80b5d98e137e") },
                    { new Guid("b7e3c5d1-4a9f-4f0e-9d3c-f5a8b2d6e1c4"), new Guid("3f8b2e1a-9c6a-4d5c-a3b7-f2a7e9c0d8f4"), new Guid("fd439a35-5916-4ab3-84dc-98551ae9735f") },
                    { new Guid("b7e9a5c2-8d4f-4e0a-9d3b-f5c2a8d6f1c3"), new Guid("3f8b2e1a-9c6a-4d5c-a3b7-f2a7e9c0d8f4"), new Guid("87dbb6c7-6fae-45e1-91b3-5642ae7381d1") },
                    { new Guid("b8e5d2c3-7f9a-4c0d-8f6e-d5b1c3e7a2f9"), new Guid("c2e9d7f1-5a3f-4b6a-b0a8-9e8d5c1f7b3a"), new Guid("a2df4e7c-8923-49cb-81cb-bc6be193a5d4") },
                    { new Guid("b9c1f2e3-4d7b-4e0a-9d8f-c7e5a2f6b3d4"), new Guid("e4b1a9d7-c6a8-4c3f-b2e9-a5d7f0b9c2e3"), new Guid("c80b2b14-b5fc-40ae-8785-3d4a3e4fa946") },
                    { new Guid("b9c4f3a2-8e1d-4c0f-8d3b-a3d5f6e2b7c1"), new Guid("d0b8f7e3-a1f5-4c2a-9b8a-6f3c9e7d5b4a"), new Guid("c1e4d92e-8960-4535-8a5e-bb041f37834d") },
                    { new Guid("b9d5f3a2-3e8c-4f7d-8d1a-c6e1f4b7a9c2"), new Guid("2c4e7a8f-d6b9-41e1-a482-91c1e5a7b8e2"), new Guid("8f2b63d2-bfde-4e27-8059-2bfc6275b6af") },
                    { new Guid("c1b7f9e4-5d2c-4a9e-8f3d-b8a9d4f3e1c7"), new Guid("3f8b2e1a-9c6a-4d5c-a3b7-f2a7e9c0d8f4"), new Guid("ef6b8345-345f-4a88-917c-2f1534e5de9a") },
                    { new Guid("c1d5f3a9-7e2b-4f8d-8c3a-b5e6f9d1a4c7"), new Guid("a2d3c6f9-4f7b-46c1-b8e2-e5c9a1d0f7b1"), new Guid("b834f37e-2084-49ad-a11b-c8b9ec967c61") },
                    { new Guid("c2d5f1a9-8f3e-4a7c-9b6f-e3b8d9a2f5c7"), new Guid("a2d3c6f9-4f7b-46c1-b8e2-e5c9a1d0f7b1"), new Guid("dd32bc36-093d-4e29-bb63-173a8c01a5e5") },
                    { new Guid("c2e5f8b1-4f9d-4c3a-8d7f-a6f3d9e4b2c8"), new Guid("e4b1a9d7-c6a8-4c3f-b2e9-a5d7f0b9c2e3"), new Guid("4d63bf7e-1832-4829-b2d7-39b8e5ad1423") },
                    { new Guid("c2f8d3a7-4b5e-4a9d-9f3c-a7b2e1c6d9f4"), new Guid("5b3f2d8a-1e9c-4c8a-b6a3-d8f4e1b9a7c5"), new Guid("c80b2b14-b5fc-40ae-8785-3d4a3e4fa946") },
                    { new Guid("c3f1b5e7-9a8d-4e0f-9b3a-d4b7c2f6e5a1"), new Guid("d0b8f7e3-a1f5-4c2a-9b8a-6f3c9e7d5b4a"), new Guid("6a7d5f3e-f6ad-4da2-91b7-e68c4fdb6c5b") },
                    { new Guid("c4a1e7d3-9f5b-4c2e-8f9d-a2e5d8f3c6b4"), new Guid("e4b1a9d7-c6a8-4c3f-b2e9-a5d7f0b9c2e3"), new Guid("b834f37e-2084-49ad-a11b-c8b9ec967c61") },
                    { new Guid("c4b3e2a1-7d8f-4f9e-8d0e-a7f3d1b2c4e6"), new Guid("e4b1a9d7-c6a8-4c3f-b2e9-a5d7f0b9c2e3"), new Guid("3c58b3a4-4e78-4f85-8ed1-f1a5d6f99823") },
                    { new Guid("c4d2a9b7-5f3e-4c8d-9a7f-b1e5d3f8a6c9"), new Guid("a2d3c6f9-4f7b-46c1-b8e2-e5c9a1d0f7b1"), new Guid("c8d7f839-3924-4781-b9e4-5837d5ef4b79") },
                    { new Guid("c4f5b2d9-3e7c-4a8d-9f1a-a6d3b7e9f2c1"), new Guid("5b3f2d8a-1e9c-4c8a-b6a3-d8f4e1b9a7c5"), new Guid("ef6b8345-345f-4a88-917c-2f1534e5de9a") },
                    { new Guid("c4f8d1a7-5e0b-4a9c-9f3e-d2a7b5c9f8e4"), new Guid("7f1a6e9b-8d5c-41a7-b8a1-f3d7e0c2a6b4"), new Guid("c1e4d92e-8960-4535-8a5e-bb041f37834d") },
                    { new Guid("c5a3d7f8-7e9c-4a1b-9f2e-d3b8c4a9f1e5"), new Guid("2c4e7a8f-d6b9-41e1-a482-91c1e5a7b8e2"), new Guid("ef6b8345-345f-4a88-917c-2f1534e5de9a") },
                    { new Guid("c5d4a8e1-7f3a-4e9c-8d1b-f2a7c6e3d4b8"), new Guid("e4b1a9d7-c6a8-4c3f-b2e9-a5d7f0b9c2e3"), new Guid("d04cb85c-81e1-4e43-b828-594b799a2c8a") },
                    { new Guid("c5f3a1e7-8d2b-4c0a-9d7f-e2b6f9c3d1a8"), new Guid("e4b1a9d7-c6a8-4c3f-b2e9-a5d7f0b9c2e3"), new Guid("68b7c6df-c7f1-42a9-88a5-eaf3c628413f") },
                    { new Guid("c5f3b7e1-9d2c-4f8a-8d0e-a4e7f9d6b3c1"), new Guid("d0b8f7e3-a1f5-4c2a-9b8a-6f3c9e7d5b4a"), new Guid("7a6d8e5e-9b87-43a1-8b4f-f3a30c85719b") },
                    { new Guid("c5f7a8d1-3f9c-4d2a-9b8e-b4a1d3e6c9f5"), new Guid("e4b1a9d7-c6a8-4c3f-b2e9-a5d7f0b9c2e3"), new Guid("f4e28a12-2e52-41b2-a16d-3e9b8b2d4b94") },
                    { new Guid("c6a9f1e5-4b8d-4e1a-9f7c-a5f2c7d3b1e8"), new Guid("9f5a8e0a-6f4b-45b7-a09c-678ba9e5f2d3"), new Guid("34ab1d14-2e4f-497b-b9f1-80b5d98e137e") },
                    { new Guid("c6d8b7e1-5f3a-4c2e-9f8b-b4a9f1c7e2d5"), new Guid("e4b1a9d7-c6a8-4c3f-b2e9-a5d7f0b9c2e3"), new Guid("c1e4d92e-8960-4535-8a5e-bb041f37834d") },
                    { new Guid("c6e3a1f9-4f2a-4d7c-9e3b-b5f8d2c9a1e7"), new Guid("a2d3c6f9-4f7b-46c1-b8e2-e5c9a1d0f7b1"), new Guid("df5728ae-732a-4d73-93c1-16f5e1b5e4d8") },
                    { new Guid("c7a5f9b3-8d2e-4e1c-9b3a-f6d1e4a2b8f3"), new Guid("e4b1a9d7-c6a8-4c3f-b2e9-a5d7f0b9c2e3"), new Guid("f3b1ad4e-dad5-4a71-879c-e6fb30e4d292") },
                    { new Guid("c7b5f9a3-5e1d-4a0f-9d3e-b6a9d4e3f1c2"), new Guid("3f8b2e1a-9c6a-4d5c-a3b7-f2a7e9c0d8f4"), new Guid("3f8e845a-08ec-4f57-bc47-bf85f594f738") },
                    { new Guid("c8a9d3f7-7f2e-4c0d-8d3b-a5e4f2b9c6d8"), new Guid("c2e9d7f1-5a3f-4b6a-b0a8-9e8d5c1f7b3a"), new Guid("f3b1ad4e-dad5-4a71-879c-e6fb30e4d292") },
                    { new Guid("c8b4e5d2-7f1a-4c6e-a8e7-d7f0e1c9b2a3"), new Guid("e4b1a9d7-c6a8-4c3f-b2e9-a5d7f0b9c2e3"), new Guid("6d7597b9-8391-4cb4-b0a9-103b12e7840e") },
                    { new Guid("c8f2d1a5-7f3c-4e9a-9b8e-d5a7c4e3b6d8"), new Guid("c2e9d7f1-5a3f-4b6a-b0a8-9e8d5c1f7b3a"), new Guid("f4e28a12-2e52-41b2-a16d-3e9b8b2d4b94") },
                    { new Guid("c9b2f8d1-4e3f-4a7c-9d5b-a2e4f1d8c3b7"), new Guid("d0b8f7e3-a1f5-4c2a-9b8a-6f3c9e7d5b4a"), new Guid("2f5af7ba-6f5e-4d6a-9a10-638b2dc94b24") },
                    { new Guid("c9d5f3b1-7a8e-4c0d-9f6e-e2a3b4d7f1c8"), new Guid("2c4e7a8f-d6b9-41e1-a482-91c1e5a7b8e2"), new Guid("04b0b346-73c1-49b5-9d5a-435ce6291b27") },
                    { new Guid("c9f7a5b3-3d1e-4a0c-9f5b-a2e4f3d8c7b1"), new Guid("5b3f2d8a-1e9c-4c8a-b6a3-d8f4e1b9a7c5"), new Guid("40e55c1a-8723-4be4-89d9-38c423b19c1a") },
                    { new Guid("d1b5f2a8-7e9c-4c3f-9b2e-a3f6d8c1e4b7"), new Guid("e4b1a9d7-c6a8-4c3f-b2e9-a5d7f0b9c2e3"), new Guid("4f7d50e3-f3cf-4d5d-988a-cb6bfbdb5a48") },
                    { new Guid("d1b7c4e3-9f2a-4d0e-8b6f-a5e2f3b9d4c7"), new Guid("2c4e7a8f-d6b9-41e1-a482-91c1e5a7b8e2"), new Guid("fd439a35-5916-4ab3-84dc-98551ae9735f") },
                    { new Guid("d1c5f7a8-9e3a-4b2d-8f5e-a2c9d6e4b3f9"), new Guid("e4b1a9d7-c6a8-4c3f-b2e9-a5d7f0b9c2e3"), new Guid("f2b27896-dfc7-4b3d-b7cb-439a8fdfbb38") },
                    { new Guid("d1e5a7c3-8f4a-4b9e-8d3c-b6f9c2a1d8e7"), new Guid("3f8b2e1a-9c6a-4d5c-a3b7-f2a7e9c0d8f4"), new Guid("c1e4d92e-8960-4535-8a5e-bb041f37834d") },
                    { new Guid("d1f5c9b7-3a8e-4d0c-9a2f-c4b6e9a3d7f8"), new Guid("c2e9d7f1-5a3f-4b6a-b0a8-9e8d5c1f7b3a"), new Guid("f2b27896-dfc7-4b3d-b7cb-439a8fdfbb38") },
                    { new Guid("d1f7b9c2-3a8e-4c0d-8d1f-b2e5a9f4c7d3"), new Guid("a2d3c6f9-4f7b-46c1-b8e2-e5c9a1d0f7b1"), new Guid("d04cb85c-81e1-4e43-b828-594b799a2c8a") },
                    { new Guid("d2b6f9e1-7c4f-4a9b-9d8e-b7a2f5c3d1e4"), new Guid("e4b1a9d7-c6a8-4c3f-b2e9-a5d7f0b9c2e3"), new Guid("a2df4e7c-8923-49cb-81cb-bc6be193a5d4") },
                    { new Guid("d2b7e5c1-9a3f-4c8a-8d1e-a9f4c6b7d3e2"), new Guid("3f8b2e1a-9c6a-4d5c-a3b7-f2a7e9c0d8f4"), new Guid("6a7d5f3e-f6ad-4da2-91b7-e68c4fdb6c5b") },
                    { new Guid("d2e9c5a3-4f7b-4d1e-9b2f-e5a6c8f3d1b7"), new Guid("e4b1a9d7-c6a8-4c3f-b2e9-a5d7f0b9c2e3"), new Guid("3f8e845a-08ec-4f57-bc47-bf85f594f738") },
                    { new Guid("d2f1b3e4-9a7c-4d0f-8b5e-a6e3f4b7c2d5"), new Guid("e4b1a9d7-c6a8-4c3f-b2e9-a5d7f0b9c2e3"), new Guid("b2143e24-8e4f-4d0e-b051-1cfb5e7b5a47") },
                    { new Guid("d3a01bff-5a5f-4d8e-889e-89d7e0af6b1a"), new Guid("e4b1a9d7-c6a8-4c3f-b2e9-a5d7f0b9c2e3"), new Guid("d48f8d94-8a20-4c2e-b276-29fd451f8c45") },
                    { new Guid("d3e1b8a9-7f6c-4e2a-8d9b-a6f5c3d4e9b2"), new Guid("e4b1a9d7-c6a8-4c3f-b2e9-a5d7f0b9c2e3"), new Guid("8f6e59a8-41cf-4da5-bf96-68b2308727c9") },
                    { new Guid("d3e1f9a4-5a7c-4f0d-8b2e-b4c5a6f9d8c1"), new Guid("9f5a8e0a-6f4b-45b7-a09c-678ba9e5f2d3"), new Guid("f4a2d91e-b95f-42b3-82fc-dc3b6825c182") },
                    { new Guid("d3e5f8c1-7a2b-4f0d-9e5c-b4f1c9d7e2a8"), new Guid("7f1a6e9b-8d5c-41a7-b8a1-f3d7e0c2a6b4"), new Guid("af5d2f13-dc73-4b49-8d8f-c540fefc9675") },
                    { new Guid("d4b3f9a5-6f2c-4e0b-8d9f-a7f3c1d8e5b9"), new Guid("3f8b2e1a-9c6a-4d5c-a3b7-f2a7e9c0d8f4"), new Guid("598b8d23-4bcb-4018-b805-b8a2e8bde473") },
                    { new Guid("d4c2f9b3-7e8a-4f0e-9a3c-b7f1e5d8a9c2"), new Guid("c2e9d7f1-5a3f-4b6a-b0a8-9e8d5c1f7b3a"), new Guid("dd32bc36-093d-4e29-bb63-173a8c01a5e5") },
                    { new Guid("d5a9f2c4-8e3f-4d1c-8d0a-b3e7a5f9b1c6"), new Guid("7f1a6e9b-8d5c-41a7-b8a1-f3d7e0c2a6b4"), new Guid("6d7597b9-8391-4cb4-b0a9-103b12e7840e") },
                    { new Guid("d5b9f3a1-7e8f-4c2a-9d7e-c4b6f2d9a3b5"), new Guid("e4b1a9d7-c6a8-4c3f-b2e9-a5d7f0b9c2e3"), new Guid("8f2b63d2-bfde-4e27-8059-2bfc6275b6af") },
                    { new Guid("d5e7c2b9-8f1d-4c3e-9b7f-a6b4d8c3e2f1"), new Guid("c2e9d7f1-5a3f-4b6a-b0a8-9e8d5c1f7b3a"), new Guid("6d7597b9-8391-4cb4-b0a9-103b12e7840e") },
                    { new Guid("d6b9f3a2-8f1d-4e7c-9d5e-a4c1f7b2d5e8"), new Guid("d0b8f7e3-a1f5-4c2a-9b8a-6f3c9e7d5b4a"), new Guid("e44106ff-16b1-4a69-9788-c715f85b06b5") },
                    { new Guid("d6c9f1a3-7b5f-4c2a-8d3e-e2b7f4c5a9f3"), new Guid("e4b1a9d7-c6a8-4c3f-b2e9-a5d7f0b9c2e3"), new Guid("d7eec652-9d38-4b7c-9b73-6aef6341c531") },
                    { new Guid("d7a5c8f3-9e6b-4a7d-8b1c-b2f4d3e9c7f5"), new Guid("e4b1a9d7-c6a8-4c3f-b2e9-a5d7f0b9c2e3"), new Guid("c8d7f839-3924-4781-b9e4-5837d5ef4b79") },
                    { new Guid("d7f4c2b1-9a6e-4f0d-8d3a-c5e1f9b2e8a6"), new Guid("7f1a6e9b-8d5c-41a7-b8a1-f3d7e0c2a6b4"), new Guid("68b7c6df-c7f1-42a9-88a5-eaf3c628413f") },
                    { new Guid("d8c5b1a2-3e7f-4a9c-b4e9-c2d7a1f3e6b4"), new Guid("e4b1a9d7-c6a8-4c3f-b2e9-a5d7f0b9c2e3"), new Guid("598b8d23-4bcb-4018-b805-b8a2e8bde473") },
                    { new Guid("d8e4a9c2-3f1a-4e7f-9b6d-c7a1f5d4b2e8"), new Guid("e4b1a9d7-c6a8-4c3f-b2e9-a5d7f0b9c2e3"), new Guid("80b5c7a2-4a45-4312-9e3d-d34b7f267154") },
                    { new Guid("d8f2a1b3-5c7f-4d9e-8d0a-e4b7c3a6f1e9"), new Guid("3f8b2e1a-9c6a-4d5c-a3b7-f2a7e9c0d8f4"), new Guid("c2b3dfc4-69e2-4745-94d5-29ec51b7d5f9") },
                    { new Guid("d9a3f1b7-5e8d-4f2c-9b7a-e6c4b2f3d5a8"), new Guid("9f5a8e0a-6f4b-45b7-a09c-678ba9e5f2d3"), new Guid("f4e28a12-2e52-41b2-a16d-3e9b8b2d4b94") },
                    { new Guid("d9c7e3b1-4a5f-4e0d-9b8a-a2f1d3f5c8e6"), new Guid("d0b8f7e3-a1f5-4c2a-9b8a-6f3c9e7d5b4a"), new Guid("04b0b346-73c1-49b5-9d5a-435ce6291b27") },
                    { new Guid("d9e1f3c5-4a8b-4d2c-9f7a-b5f6c2a9d3e4"), new Guid("5b3f2d8a-1e9c-4c8a-b6a3-d8f4e1b9a7c5"), new Guid("9d93e72f-8a10-4b68-a8cd-b492fd6e6cd1") },
                    { new Guid("d9f3c5b1-8a4e-4f0d-9d2f-a7b2e6c3f1a9"), new Guid("7f1a6e9b-8d5c-41a7-b8a1-f3d7e0c2a6b4"), new Guid("87dbb6c7-6fae-45e1-91b3-5642ae7381d1") },
                    { new Guid("e1a7d8c3-8b9f-4d2a-8c1e-d5f4a9b6f2e3"), new Guid("5b3f2d8a-1e9c-4c8a-b6a3-d8f4e1b9a7c5"), new Guid("f3a8c7b9-2c37-47d2-9076-1c25f98bba16") },
                    { new Guid("e1c8b9d2-7f5a-4a3d-8f4c-b3e7f5a9c1d6"), new Guid("a2d3c6f9-4f7b-46c1-b8e2-e5c9a1d0f7b1"), new Guid("a4e71c3d-2efc-42d6-a0c9-bd95dc35a654") },
                    { new Guid("e1d3f9a7-9a4c-4e2b-8f0d-b3c7f4a5d9e1"), new Guid("d0b8f7e3-a1f5-4c2a-9b8a-6f3c9e7d5b4a"), new Guid("87dbb6c7-6fae-45e1-91b3-5642ae7381d1") },
                    { new Guid("e1f5a8b3-7d2c-4f0a-9d3e-b6c9f4d7e2a3"), new Guid("c2e9d7f1-5a3f-4b6a-b0a8-9e8d5c1f7b3a"), new Guid("40e55c1a-8723-4be4-89d9-38c423b19c1a") },
                    { new Guid("e2f1c5b9-7d4a-4c0e-8a9f-b3d7f6c8e4a1"), new Guid("9f5a8e0a-6f4b-45b7-a09c-678ba9e5f2d3"), new Guid("87dbb6c7-6fae-45e1-91b3-5642ae7381d1") },
                    { new Guid("e3b9a7f5-8c1d-4f0e-9d2c-c5a4d6f9b7e3"), new Guid("7f1a6e9b-8d5c-41a7-b8a1-f3d7e0c2a6b4"), new Guid("b2143e24-8e4f-4d0e-b051-1cfb5e7b5a47") },
                    { new Guid("e3c9f7a1-8d2b-4e0c-9a5d-f5b6a1c3d4e7"), new Guid("2c4e7a8f-d6b9-41e1-a482-91c1e5a7b8e2"), new Guid("8f6e59a8-41cf-4da5-bf96-68b2308727c9") },
                    { new Guid("e3d5f9a2-7c1b-4f0d-9a8e-c5b2f7a4d3e8"), new Guid("a2d3c6f9-4f7b-46c1-b8e2-e5c9a1d0f7b1"), new Guid("d7eec652-9d38-4b7c-9b73-6aef6341c531") },
                    { new Guid("e4a3c1b7-5d8e-41b3-8d0f-b2f7a9d8e4c6"), new Guid("e4b1a9d7-c6a8-4c3f-b2e9-a5d7f0b9c2e3"), new Guid("af5d2f13-dc73-4b49-8d8f-c540fefc9675") },
                    { new Guid("e4a7c1d9-5f3b-4d9e-9a8f-b7f2c8a3d5e1"), new Guid("9f5a8e0a-6f4b-45b7-a09c-678ba9e5f2d3"), new Guid("f3b1ad4e-dad5-4a71-879c-e6fb30e4d292") },
                    { new Guid("e4c3a9d5-8f7e-4f0b-9a1d-f2b5d1a3c8e9"), new Guid("5b3f2d8a-1e9c-4c8a-b6a3-d8f4e1b9a7c5"), new Guid("c1e4d92e-8960-4535-8a5e-bb041f37834d") },
                    { new Guid("e4c7a1d3-5f9e-4a3f-8d1c-a6f3d2b7e5c9"), new Guid("3f8b2e1a-9c6a-4d5c-a3b7-f2a7e9c0d8f4"), new Guid("4f7d50e3-f3cf-4d5d-988a-cb6bfbdb5a48") },
                    { new Guid("e5a3c8d1-9b7f-4c0e-8f1d-c9d2f6b4e3a7"), new Guid("2c4e7a8f-d6b9-41e1-a482-91c1e5a7b8e2"), new Guid("3f8e845a-08ec-4f57-bc47-bf85f594f738") },
                    { new Guid("e5b9c3f2-7d4a-4e6f-9d8a-b7c1f3d6a4e9"), new Guid("e4b1a9d7-c6a8-4c3f-b2e9-a5d7f0b9c2e3"), new Guid("df5728ae-732a-4d73-93c1-16f5e1b5e4d8") },
                    { new Guid("e5c2a7b9-8f4d-4e0c-9a3f-b7d8f6c3a1e4"), new Guid("c2e9d7f1-5a3f-4b6a-b0a8-9e8d5c1f7b3a"), new Guid("e0f3a7c5-1d8b-4a2e-8f9c-3b5f7d0c9ea5") },
                    { new Guid("e5f2c3a8-9b7d-4e1a-9d8c-c2a7d5b3f4e9"), new Guid("d0b8f7e3-a1f5-4c2a-9b8a-6f3c9e7d5b4a"), new Guid("8f2b63d2-bfde-4e27-8059-2bfc6275b6af") },
                    { new Guid("e6b3d2f9-8f1c-4a9e-9d7f-c1a2b5f4d3e7"), new Guid("e4b1a9d7-c6a8-4c3f-b2e9-a5d7f0b9c2e3"), new Guid("8f643b5f-f6f0-4f3b-b8cd-8bfabc1c97d1") },
                    { new Guid("e7a1f3d5-4b8f-4e2d-9a0c-d9c2f5a8b7e3"), new Guid("c2e9d7f1-5a3f-4b6a-b0a8-9e8d5c1f7b3a"), new Guid("c1e4d92e-8960-4535-8a5e-bb041f37834d") },
                    { new Guid("e7c1f3a5-8d2b-4e0f-9d6c-b9a5f2d7e3c4"), new Guid("3f8b2e1a-9c6a-4d5c-a3b7-f2a7e9c0d8f4"), new Guid("3c58b3a4-4e78-4f85-8ed1-f1a5d6f99823") },
                    { new Guid("e7c3f2b1-8d5e-4a9f-b7d1-c6a9e2f8b3d4"), new Guid("e4b1a9d7-c6a8-4c3f-b2e9-a5d7f0b9c2e3"), new Guid("2f5af7ba-6f5e-4d6a-9a10-638b2dc94b24") },
                    { new Guid("e7c4f1b9-5a3d-4e0c-8f1d-c9a6b7f5d2e8"), new Guid("7f1a6e9b-8d5c-41a7-b8a1-f3d7e0c2a6b4"), new Guid("7252b347-bd2f-4f8e-9cd1-18337c2c84d2") },
                    { new Guid("e7d9a1b4-4f3c-4e0a-b6f8-c9b1f3a2e4d5"), new Guid("e4b1a9d7-c6a8-4c3f-b2e9-a5d7f0b9c2e3"), new Guid("dd32bc36-093d-4e29-bb63-173a8c01a5e5") },
                    { new Guid("e8a1d3b9-7c2f-4e5a-9d6f-b2f3c8e5d7a4"), new Guid("9f5a8e0a-6f4b-45b7-a09c-678ba9e5f2d3"), new Guid("c80b2b14-b5fc-40ae-8785-3d4a3e4fa946") },
                    { new Guid("e8a5d1b2-4c3f-4d9e-9b2f-b1d7a3c4f6e8"), new Guid("e4b1a9d7-c6a8-4c3f-b2e9-a5d7f0b9c2e3"), new Guid("7252b347-bd2f-4f8e-9cd1-18337c2c84d2") },
                    { new Guid("e8f3c1b7-7d4a-4c6e-9b1d-b7c5d2a9f6e3"), new Guid("e4b1a9d7-c6a8-4c3f-b2e9-a5d7f0b9c2e3"), new Guid("e0f3a7c5-1d8b-4a2e-8f9c-3b5f7d0c9ea5") },
                    { new Guid("e8f3c7d2-7a5e-4b9c-8d3f-b9a6d4c1e2f7"), new Guid("9f5a8e0a-6f4b-45b7-a09c-678ba9e5f2d3"), new Guid("e0f3a7c5-1d8b-4a2e-8f9c-3b5f7d0c9ea5") },
                    { new Guid("e9a2b8d5-4f1e-4d7f-8b9c-c6f3d4a1e5b9"), new Guid("e4b1a9d7-c6a8-4c3f-b2e9-a5d7f0b9c2e3"), new Guid("c2b3dfc4-69e2-4745-94d5-29ec51b7d5f9") },
                    { new Guid("e9a3d7b4-5c2e-4f0a-9f8d-c6e2a1d3b9f4"), new Guid("7f1a6e9b-8d5c-41a7-b8a1-f3d7e0c2a6b4"), new Guid("12ae6e82-56c9-41fa-8d21-7c5f0e1875a3") },
                    { new Guid("e9a7b3f1-3d8e-4f0c-8d5a-a7f5c9e2d4b6"), new Guid("3f8b2e1a-9c6a-4d5c-a3b7-f2a7e9c0d8f4"), new Guid("4d63bf7e-1832-4829-b2d7-39b8e5ad1423") },
                    { new Guid("e9c3f7b4-5a2d-4a1f-9d6c-b8a7d2e5f1c3"), new Guid("5b3f2d8a-1e9c-4c8a-b6a3-d8f4e1b9a7c5"), new Guid("f2b27896-dfc7-4b3d-b7cb-439a8fdfbb38") },
                    { new Guid("e9c5d8b4-3f1a-4e7d-9a2f-c7b3f4a8e1d6"), new Guid("9f5a8e0a-6f4b-45b7-a09c-678ba9e5f2d3"), new Guid("17c8eb5a-b72f-4e3c-bd45-f621d2a9b6a3") },
                    { new Guid("e9d2c5f1-4b7e-4f0c-8d3a-f5b8c1a2e7d9"), new Guid("5b3f2d8a-1e9c-4c8a-b6a3-d8f4e1b9a7c5"), new Guid("6939c6b2-c4a4-43d9-8c3e-8fbc714fb6c6") },
                    { new Guid("e9d3f1c7-8a2b-4f0d-8e1f-b6a5c4e2d9f3"), new Guid("d0b8f7e3-a1f5-4c2a-9b8a-6f3c9e7d5b4a"), new Guid("4f7d50e3-f3cf-4d5d-988a-cb6bfbdb5a48") },
                    { new Guid("e9f2b8c3-4a7f-4d1e-8b2a-f5c3d7a6b1e9"), new Guid("e4b1a9d7-c6a8-4c3f-b2e9-a5d7f0b9c2e3"), new Guid("6939c6b2-c4a4-43d9-8c3e-8fbc714fb6c6") },
                    { new Guid("f1b8c4a2-9e7d-4f0e-8d2c-b5e3d9a7f6c1"), new Guid("9f5a8e0a-6f4b-45b7-a09c-678ba9e5f2d3"), new Guid("f3a8c7b9-2c37-47d2-9076-1c25f98bba16") },
                    { new Guid("f1c5d8b3-4a7e-4c2f-8d5b-b9f3e7a6c2d8"), new Guid("e4b1a9d7-c6a8-4c3f-b2e9-a5d7f0b9c2e3"), new Guid("17c8eb5a-b72f-4e3c-bd45-f621d2a9b6a3") },
                    { new Guid("f1d4c9e2-7e8f-4b0a-9d2c-a5c3f7a1b6e9"), new Guid("c2e9d7f1-5a3f-4b6a-b0a8-9e8d5c1f7b3a"), new Guid("df5728ae-732a-4d73-93c1-16f5e1b5e4d8") },
                    { new Guid("f1d8c7b2-9e4a-4c0f-8b3d-a4b5f9e3c7d6"), new Guid("a2d3c6f9-4f7b-46c1-b8e2-e5c9a1d0f7b1"), new Guid("e7a82fb6-a8ff-4076-9b7d-2c8f6c8e8e13") },
                    { new Guid("f2a7b3c9-8d4e-4c1a-8f3d-b7e1c5a9f6b3"), new Guid("d0b8f7e3-a1f5-4c2a-9b8a-6f3c9e7d5b4a"), new Guid("8f643b5f-f6f0-4f3b-b8cd-8bfabc1c97d1") },
                    { new Guid("f2b3d8a9-7e4f-4a0c-9f6d-b1c7e9a2d3f5"), new Guid("d0b8f7e3-a1f5-4c2a-9b8a-6f3c9e7d5b4a"), new Guid("76b7c5a9-4387-4b9d-93b6-c451fb4e8267") },
                    { new Guid("f3a8d1c5-4b6f-4c9e-8d3a-c2f7e5b4d1a9"), new Guid("9f5a8e0a-6f4b-45b7-a09c-678ba9e5f2d3"), new Guid("a2df4e7c-8923-49cb-81cb-bc6be193a5d4") },
                    { new Guid("f3a9b7d2-8e1f-4c0a-9d5b-a4e1c8f3b6d9"), new Guid("a2d3c6f9-4f7b-46c1-b8e2-e5c9a1d0f7b1"), new Guid("34ab1d14-2e4f-497b-b9f1-80b5d98e137e") },
                    { new Guid("f3b2e5a1-8d7c-4c9a-9f1e-a7c5d4f2b9d8"), new Guid("7f1a6e9b-8d5c-41a7-b8a1-f3d7e0c2a6b4"), new Guid("2f5af7ba-6f5e-4d6a-9a10-638b2dc94b24") },
                    { new Guid("f3c9a1d7-8f2b-4a3f-9d5e-b7d1e6c8a2f5"), new Guid("5b3f2d8a-1e9c-4c8a-b6a3-d8f4e1b9a7c5"), new Guid("f4a2d91e-b95f-42b3-82fc-dc3b6825c182") },
                    { new Guid("f3c9d8a7-4b1e-4f0c-9d2a-c5e8a1f4b3d7"), new Guid("a2d3c6f9-4f7b-46c1-b8e2-e5c9a1d0f7b1"), new Guid("af5d2f13-dc73-4b49-8d8f-c540fefc9675") },
                    { new Guid("f3d4e6a7-8a0c-45d3-877d-e7a1c0b5f9b2"), new Guid("e4b1a9d7-c6a8-4c3f-b2e9-a5d7f0b9c2e3"), new Guid("87dbb6c7-6fae-45e1-91b3-5642ae7381d1") },
                    { new Guid("f3e8c7a2-4b1d-4c5f-9a9b-a7d5b4e9c2f8"), new Guid("e4b1a9d7-c6a8-4c3f-b2e9-a5d7f0b9c2e3"), new Guid("76b7c5a9-4387-4b9d-93b6-c451fb4e8267") },
                    { new Guid("f4d3a1b9-7c5e-4f0d-9a1f-d5b7c2e9f8a3"), new Guid("2c4e7a8f-d6b9-41e1-a482-91c1e5a7b8e2"), new Guid("7b5398f5-4a56-47e6-8715-91b4f5d38f96") },
                    { new Guid("f5a7e9b1-7c8d-4a0f-9d3a-b3c1d4f9e6b2"), new Guid("9f5a8e0a-6f4b-45b7-a09c-678ba9e5f2d3"), new Guid("c1e4d92e-8960-4535-8a5e-bb041f37834d") },
                    { new Guid("f5a9e2d1-3c7b-4a9c-9d1f-e3b6f8d2a7c4"), new Guid("e4b1a9d7-c6a8-4c3f-b2e9-a5d7f0b9c2e3"), new Guid("fd439a35-5916-4ab3-84dc-98551ae9735f") },
                    { new Guid("f5c1b2e9-4f3d-4e0a-8d6b-b7a9f4c5e1d8"), new Guid("5b3f2d8a-1e9c-4c8a-b6a3-d8f4e1b9a7c5"), new Guid("e7a82fb6-a8ff-4076-9b7d-2c8f6c8e8e13") },
                    { new Guid("f5c1d8a7-8e4b-4a9e-9d3f-a7b4e2f9c6d3"), new Guid("9f5a8e0a-6f4b-45b7-a09c-678ba9e5f2d3"), new Guid("a4e71c3d-2efc-42d6-a0c9-bd95dc35a654") },
                    { new Guid("f6d3a2c7-7e9f-4c0a-9b3e-b1d4e8f5a9c2"), new Guid("5b3f2d8a-1e9c-4c8a-b6a3-d8f4e1b9a7c5"), new Guid("2b1eaf64-8d02-4b0b-8e8c-e6a9baff5c5c") },
                    { new Guid("f7a3d8b5-9e4f-4c0a-8d1c-b6e5f9c2a4d7"), new Guid("3f8b2e1a-9c6a-4d5c-a3b7-f2a7e9c0d8f4"), new Guid("76b7c5a9-4387-4b9d-93b6-c451fb4e8267") },
                    { new Guid("f7b2d9c1-4a5e-4d9f-9a3c-e4b1a8f5c2d3"), new Guid("a2d3c6f9-4f7b-46c1-b8e2-e5c9a1d0f7b1"), new Guid("6939c6b2-c4a4-43d9-8c3e-8fbc714fb6c6") },
                    { new Guid("f7b3e2a9-4d0c-4b7f-9f5e-d4a6c9e2b1c7"), new Guid("e4b1a9d7-c6a8-4c3f-b2e9-a5d7f0b9c2e3"), new Guid("e44106ff-16b1-4a69-9788-c715f85b06b5") },
                    { new Guid("f8b3d2a7-4c5e-4e9f-8d1c-e6a9b5d7c3f4"), new Guid("5b3f2d8a-1e9c-4c8a-b6a3-d8f4e1b9a7c5"), new Guid("6d7597b9-8391-4cb4-b0a9-103b12e7840e") },
                    { new Guid("f8c1b3d7-4f2e-4a9f-8d6a-b5e7a4f9c1d2"), new Guid("5b3f2d8a-1e9c-4c8a-b6a3-d8f4e1b9a7c5"), new Guid("87dbb6c7-6fae-45e1-91b3-5642ae7381d1") },
                    { new Guid("f8c1e5a9-2f3b-4d6f-9b2a-a5c7f6e3d4b9"), new Guid("e4b1a9d7-c6a8-4c3f-b2e9-a5d7f0b9c2e3"), new Guid("f4a2d91e-b95f-42b3-82fc-dc3b6825c182") },
                    { new Guid("f8d2a1c3-9f5b-4e7a-8d3f-b6c5e4a7f1d9"), new Guid("a2d3c6f9-4f7b-46c1-b8e2-e5c9a1d0f7b1"), new Guid("d48f8d94-8a20-4c2e-b276-29fd451f8c45") },
                    { new Guid("f9a7d9e3-8d0f-42a1-878c-f6d2b0e1a7b3"), new Guid("e4b1a9d7-c6a8-4c3f-b2e9-a5d7f0b9c2e3"), new Guid("ef6b8345-345f-4a88-917c-2f1534e5de9a") },
                    { new Guid("f9b2e8a7-8c3f-4e0a-9d6c-d5f7a2b4e3c1"), new Guid("3f8b2e1a-9c6a-4d5c-a3b7-f2a7e9c0d8f4"), new Guid("7a6d8e5e-9b87-43a1-8b4f-f3a30c85719b") },
                    { new Guid("f9b4e1a8-7f5d-4c3a-8d2f-a7c6f2b1e4d9"), new Guid("e4b1a9d7-c6a8-4c3f-b2e9-a5d7f0b9c2e3"), new Guid("9d93e72f-8a10-4b68-a8cd-b492fd6e6cd1") },
                    { new Guid("f9c1b4a5-8e7d-4c0a-9f6e-b3e5d1f2a7c4"), new Guid("e4b1a9d7-c6a8-4c3f-b2e9-a5d7f0b9c2e3"), new Guid("04b0b346-73c1-49b5-9d5a-435ce6291b27") },
                    { new Guid("f9c3d1e2-8a7b-4f0d-9e3c-b6a9f2e5c8a4"), new Guid("c2e9d7f1-5a3f-4b6a-b0a8-9e8d5c1f7b3a"), new Guid("9d93e72f-8a10-4b68-a8cd-b492fd6e6cd1") },
                    { new Guid("f9c8a3d7-7e2f-4a0b-8d5c-b1d4e3f9a7c5"), new Guid("d0b8f7e3-a1f5-4c2a-9b8a-6f3c9e7d5b4a"), new Guid("af5d2f13-dc73-4b49-8d8f-c540fefc9675") },
                    { new Guid("f9c8d5b1-3e4f-4b7d-9f6e-b1d7c2a3e5f8"), new Guid("e4b1a9d7-c6a8-4c3f-b2e9-a5d7f0b9c2e3"), new Guid("e7a82fb6-a8ff-4076-9b7d-2c8f6c8e8e13") },
                    { new Guid("f9d2a8e3-4c5f-4a9b-8d1f-b4c7e5f3a1d6"), new Guid("c2e9d7f1-5a3f-4b6a-b0a8-9e8d5c1f7b3a"), new Guid("2b1eaf64-8d02-4b0b-8e8c-e6a9baff5c5c") },
                    { new Guid("f9d3c5a7-4f2b-4e1c-8b0d-c3b6e5f7a2d1"), new Guid("5b3f2d8a-1e9c-4c8a-b6a3-d8f4e1b9a7c5"), new Guid("b834f37e-2084-49ad-a11b-c8b9ec967c61") }
                });

            migrationBuilder.InsertData(
                table: "USStateDocumentOutputs",
                columns: new[] { "USStateDocumentOutputId", "DocumentContent", "DocumentOutputTypeId", "EffectiveEnd", "EffectiveStart", "USStateDocumentTypeId" },
                values: new object[,]
                {
                    { new Guid("a9f4c2e7-8d3b-4f5e-9a0c-b7d2f1e6c3f8"), new byte[] { 16, 67, 84, 126, 126, 67, 68, 44, 126, 67, 67, 94, 126, 67, 84, 126, 13, 10, 94, 88, 65, 13, 10, 126, 84, 65, 48, 48, 48, 13, 10, 126, 74, 83, 78, 13, 10, 94, 76, 84, 48, 13, 10, 94, 77, 78, 87, 13, 10, 94, 77, 84, 84, 13, 10, 94, 80, 79, 78, 13, 10, 94, 80, 77, 78, 13, 10, 94, 76, 72, 48, 44, 48, 13, 10, 94, 74, 77, 65, 13, 10, 94, 80, 82, 50, 44, 50, 13, 10, 126, 83, 68, 49, 53, 13, 10, 94, 74, 85, 83, 13, 10, 94, 76, 82, 78, 13, 10, 94, 67, 73, 50, 55, 13, 10, 94, 80, 65, 48, 44, 49, 44, 49, 44, 48, 13, 10, 94, 88, 90, 13, 10, 94, 88, 65, 13, 10, 94, 77, 77, 84, 13, 10, 94, 80, 87, 49, 56, 48, 48, 13, 10, 94, 76, 76, 49, 50, 48, 48, 13, 10, 94, 76, 83, 48, 13, 10, 94, 70, 79, 49, 49, 53, 44, 57, 56, 94, 71, 70, 65, 44, 49, 53, 55, 51, 44, 57, 56, 56, 52, 44, 50, 56, 44, 58, 90, 54, 52, 58, 101, 74, 122, 78, 109, 84, 49, 117, 50, 48, 65, 81, 104, 85, 107, 114, 104, 111, 121, 52, 85, 66, 87, 111, 53, 66, 70, 121, 66, 79, 111, 73, 117, 89, 70, 121, 66, 68, 101, 66, 71, 121, 78, 107, 110, 83, 90, 88, 85, 71, 110, 107, 69, 66, 71, 114, 49, 76, 53, 65, 65, 77, 71, 86, 52, 81, 67, 75, 67, 103, 99, 87, 66, 73, 107, 75, 82, 90, 71, 55, 115, 47, 80, 122, 74, 78, 66, 82, 52, 68, 86, 99, 50, 65, 56, 102, 90, 57, 47, 77, 55, 75, 54, 48, 106, 75, 74, 113, 68, 76, 98, 122, 99, 106, 53, 47, 102, 80, 122, 109, 120, 109, 51, 85, 106, 118, 55, 87, 106, 56, 51, 109, 90, 122, 88, 117, 110, 78, 98, 98, 56, 114, 70, 48, 87, 105, 121, 48, 74, 54, 101, 100, 65, 83, 53, 75, 98, 75, 54, 97, 113, 77, 51, 49, 77, 122, 97, 117, 118, 67, 89, 109, 83, 106, 103, 120, 48, 89, 88, 88, 73, 113, 68, 70, 50, 43, 102, 119, 66, 51, 69, 80, 82, 77, 117, 89, 86, 103, 66, 117, 82, 106, 107, 50, 82, 107, 83, 98, 103, 110, 103, 56, 111, 88, 83, 101, 80, 75, 69, 107, 76, 121, 73, 120, 108, 79, 77, 86, 112, 66, 119, 51, 71, 71, 104, 112, 113, 75, 50, 111, 108, 111, 84, 43, 98, 113, 106, 71, 74, 108, 114, 109, 119, 69, 81, 66, 78, 74, 114, 81, 80, 113, 118, 103, 115, 89, 110, 112, 77, 50, 49, 78, 78, 78, 53, 112, 49, 71, 65, 118, 115, 119, 49, 121, 98, 103, 109, 48, 111, 43, 77, 66, 55, 112, 74, 112, 74, 101, 67, 50, 82, 50, 112, 105, 66, 89, 74, 56, 48, 103, 76, 121, 102, 71, 52, 66, 82, 55, 85, 104, 88, 52, 70, 69, 83, 122, 108, 72, 52, 111, 51, 116, 90, 56, 111, 100, 122, 88, 77, 120, 116, 48, 100, 87, 111, 74, 103, 109, 97, 84, 82, 104, 106, 122, 84, 111, 113, 43, 73, 54, 43, 107, 116, 65, 118, 66, 82, 119, 54, 84, 79, 118, 110, 43, 99, 69, 82, 114, 106, 77, 106, 115, 101, 55, 109, 110, 75, 74, 115, 79, 102, 57, 83, 99, 120, 120, 56, 104, 122, 122, 56, 100, 52, 68, 98, 109, 104, 121, 98, 54, 101, 75, 49, 72, 68, 118, 78, 75, 110, 104, 86, 71, 122, 80, 121, 100, 98, 48, 47, 106, 81, 68, 106, 116, 79, 49, 79, 112, 53, 99, 67, 112, 81, 84, 116, 88, 80, 49, 119, 49, 121, 51, 101, 76, 73, 49, 118, 84, 47, 90, 109, 111, 84, 114, 71, 69, 47, 112, 77, 99, 101, 104, 79, 105, 104, 114, 119, 88, 77, 112, 52, 109, 120, 47, 104, 115, 69, 90, 48, 73, 114, 68, 110, 70, 48, 47, 121, 67, 70, 47, 50, 109, 111, 52, 120, 104, 47, 107, 117, 115, 89, 68, 88, 72, 111, 67, 68, 118, 83, 110, 116, 114, 107, 52, 84, 116, 100, 101, 116, 80, 54, 85, 80, 100, 66, 120, 88, 100, 99, 68, 47, 43, 82, 67, 47, 90, 48, 105, 72, 117, 75, 54, 114, 118, 99, 85, 99, 76, 113, 57, 50, 116, 56, 88, 72, 97, 117, 53, 115, 97, 69, 86, 90, 109, 86, 114, 122, 113, 104, 101, 88, 84, 56, 106, 109, 122, 86, 110, 117, 75, 118, 106, 71, 86, 110, 90, 99, 52, 97, 57, 110, 84, 43, 106, 67, 115, 48, 56, 55, 88, 105, 118, 105, 84, 79, 54, 115, 47, 89, 72, 56, 119, 76, 105, 89, 99, 54, 117, 72, 43, 73, 83, 69, 67, 57, 70, 72, 80, 65, 51, 66, 100, 121, 52, 89, 55, 119, 77, 99, 74, 90, 48, 105, 68, 79, 49, 109, 98, 110, 54, 97, 110, 57, 100, 52, 121, 72, 117, 71, 116, 84, 118, 70, 80, 71, 54, 43, 107, 116, 65, 118, 76, 81, 106, 57, 55, 47, 55, 56, 120, 84, 122, 55, 76, 114, 43, 122, 107, 69, 56, 117, 67, 56, 66, 102, 49, 51, 51, 77, 51, 81, 43, 109, 73, 51, 50, 69, 105, 52, 70, 110, 70, 88, 65, 107, 88, 51, 99, 49, 112, 121, 49, 103, 82, 98, 50, 56, 86, 53, 122, 115, 86, 48, 47, 53, 87, 55, 81, 99, 53, 98, 66, 103, 43, 102, 55, 48, 80, 89, 88, 102, 81, 87, 99, 48, 84, 69, 72, 80, 55, 47, 65, 55, 119, 43, 73, 71, 119, 77, 117, 66, 86, 121, 56, 78, 102, 48, 90, 71, 100, 49, 122, 43, 107, 84, 51, 56, 102, 83, 65, 68, 83, 102, 117, 88, 113, 113, 102, 57, 104, 53, 70, 98, 90, 108, 56, 114, 50, 107, 116, 115, 50, 107, 52, 76, 97, 80, 116, 118, 90, 83, 50, 66, 116, 118, 55, 77, 56, 50, 103, 117, 49, 47, 83, 53, 104, 76, 90, 109, 114, 115, 72, 121, 47, 52, 100, 116, 119, 97, 97, 117, 43, 100, 84, 47, 70, 50, 66, 101, 65, 47, 103, 109, 101, 52, 101, 77, 48, 88, 120, 90, 80, 48, 87, 73, 74, 55, 76, 112, 120, 73, 80, 53, 99, 88, 100, 110, 50, 110, 57, 101, 82, 83, 110, 97, 73, 88, 116, 98, 122, 116, 112, 116, 65, 82, 119, 103, 51, 73, 113, 116, 68, 97, 104, 121, 85, 76, 101, 51, 77, 120, 97, 98, 105, 90, 98, 116, 78, 88, 54, 73, 55, 109, 78, 106, 104, 114, 116, 77, 112, 101, 55, 84, 77, 116, 70, 121, 112, 111, 111, 118, 67, 89, 67, 69, 107, 53, 56, 106, 121, 65, 97, 101, 103, 77, 104, 122, 105, 88, 67, 119, 84, 99, 108, 90, 111, 77, 101, 101, 68, 80, 68, 116, 88, 86, 72, 98, 116, 71, 82, 71, 51, 108, 78, 43, 74, 115, 81, 122, 117, 114, 80, 83, 76, 107, 118, 122, 43, 49, 52, 57, 74, 53, 100, 51, 72, 116, 72, 108, 65, 118, 114, 104, 55, 104, 106, 51, 122, 56, 103, 106, 112, 43, 67, 112, 72, 120, 105, 75, 97, 69, 88, 83, 65, 88, 103, 83, 68, 114, 70, 48, 105, 85, 83, 98, 56, 47, 103, 102, 81, 55, 106, 48, 75, 115, 74, 113, 118, 69, 122, 56, 68, 78, 73, 83, 119, 107, 48, 109, 107, 53, 117, 106, 51, 73, 74, 87, 51, 50, 85, 52, 121, 107, 55, 86, 117, 80, 120, 97, 80, 110, 89, 57, 110, 76, 122, 119, 101, 97, 87, 78, 74, 48, 115, 72, 110, 51, 76, 120, 98, 107, 90, 49, 89, 97, 65, 89, 122, 109, 106, 51, 99, 76, 98, 77, 51, 104, 109, 68, 50, 104, 115, 101, 54, 72, 100, 121, 102, 116, 108, 82, 102, 50, 120, 102, 108, 107, 72, 88, 71, 105, 119, 68, 76, 82, 119, 47, 84, 48, 70, 87, 109, 103, 119, 101, 73, 88, 74, 80, 104, 88, 101, 66, 86, 114, 52, 87, 87, 81, 83, 97, 79, 69, 90, 71, 69, 113, 104, 119, 84, 122, 85, 69, 113, 111, 120, 98, 103, 67, 52, 56, 56, 122, 109, 76, 103, 65, 88, 90, 74, 82, 114, 119, 70, 57, 56, 55, 101, 49, 57, 89, 108, 106, 48, 109, 54, 83, 84, 80, 53, 79, 99, 83, 65, 118, 79, 107, 89, 121, 117, 79, 66, 101, 78, 102, 102, 50, 52, 82, 79, 54, 72, 83, 56, 72, 53, 72, 116, 48, 73, 106, 118, 84, 111, 104, 71, 117, 107, 82, 48, 99, 67, 57, 78, 120, 77, 97, 67, 54, 106, 71, 56, 67, 116, 104, 79, 82, 76, 76, 47, 74, 67, 83, 114, 43, 85, 50, 106, 110, 103, 110, 69, 69, 53, 84, 87, 47, 119, 111, 57, 82, 99, 74, 82, 54, 107, 70, 111, 78, 52, 90, 48, 66, 122, 110, 50, 69, 81, 112, 47, 104, 122, 56, 100, 90, 83, 99, 47, 53, 75, 104, 88, 80, 98, 74, 43, 74, 121, 79, 53, 55, 115, 77, 49, 47, 65, 55, 52, 114, 87, 70, 80, 55, 80, 71, 48, 87, 98, 78, 118, 89, 117, 70, 75, 48, 112, 102, 75, 70, 73, 122, 97, 97, 50, 109, 109, 104, 97, 111, 109, 121, 101, 52, 84, 79, 86, 54, 106, 108, 78, 68, 100, 102, 69, 109, 54, 110, 97, 47, 110, 117, 69, 75, 106, 86, 53, 121, 88, 88, 79, 83, 113, 97, 114, 117, 56, 114, 70, 54, 117, 90, 53, 109, 71, 118, 105, 54, 86, 114, 108, 55, 53, 101, 116, 80, 99, 102, 71, 80, 67, 117, 116, 122, 75, 50, 56, 106, 75, 118, 79, 122, 77, 120, 56, 76, 117, 116, 102, 98, 83, 82, 86, 55, 87, 75, 106, 102, 117, 109, 117, 100, 104, 97, 51, 105, 53, 85, 111, 113, 121, 106, 97, 98, 82, 82, 53, 116, 82, 51, 113, 88, 72, 57, 88, 117, 49, 105, 80, 78, 53, 104, 88, 88, 72, 83, 114, 97, 118, 48, 102, 54, 114, 47, 114, 48, 98, 117, 51, 116, 88, 104, 107, 97, 57, 70, 57, 84, 118, 47, 54, 67, 120, 50, 71, 67, 54, 52, 61, 58, 67, 70, 66, 50, 13, 10, 94, 70, 84, 52, 50, 51, 44, 49, 56, 53, 94, 65, 48, 78, 44, 56, 50, 44, 56, 49, 94, 70, 72, 92, 94, 67, 73, 50, 56, 94, 70, 68, 73, 108, 108, 105, 110, 111, 105, 115, 32, 72, 117, 110, 116, 105, 110, 103, 32, 76, 105, 99, 101, 110, 115, 101, 94, 70, 83, 94, 67, 73, 50, 55, 13, 10, 94, 70, 84, 52, 51, 51, 44, 51, 55, 55, 94, 65, 48, 78, 44, 49, 54, 55, 44, 49, 54, 55, 94, 70, 72, 92, 94, 67, 73, 50, 56, 94, 70, 68, 50, 48, 50, 51, 94, 70, 83, 94, 67, 73, 50, 55, 13, 10, 94, 70, 84, 49, 49, 53, 44, 53, 57, 48, 94, 65, 48, 78, 44, 53, 56, 44, 53, 56, 94, 70, 72, 92, 94, 67, 73, 50, 56, 94, 70, 68, 94, 86, 78, 97, 109, 101, 36, 94, 70, 83, 94, 67, 73, 50, 55, 13, 10, 94, 70, 84, 49, 49, 53, 44, 55, 48, 52, 94, 65, 48, 78, 44, 53, 56, 44, 53, 56, 94, 70, 72, 92, 94, 67, 73, 50, 56, 94, 70, 68, 94, 86, 65, 100, 100, 114, 101, 115, 115, 36, 94, 70, 83, 94, 67, 73, 50, 55, 13, 10, 94, 70, 84, 49, 49, 53, 44, 56, 49, 56, 94, 65, 48, 78, 44, 53, 56, 44, 53, 56, 94, 70, 72, 92, 94, 67, 73, 50, 56, 94, 70, 68, 94, 86, 67, 83, 90, 36, 94, 70, 83, 94, 67, 73, 50, 55, 94, 80, 81, 49, 44, 48, 44, 49, 44, 89, 13, 10, 94, 88, 90, 13, 10 }, new Guid("fa7c2b5e-6e3b-4a9f-b2d1-1d3f9e8b4c7f"), new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f5c1d8a7-8e4b-4a9e-9d3f-a7b4e2f9c6d3") },
                    { new Guid("b5e1a2c9-7c4f-4d9f-8a3b-f1a2d3e9c8b7"), new byte[] { 16, 67, 84, 126, 126, 67, 68, 44, 126, 67, 67, 94, 126, 67, 84, 126, 13, 10, 94, 88, 65, 13, 10, 126, 84, 65, 48, 48, 48, 13, 10, 126, 74, 83, 78, 13, 10, 94, 76, 84, 48, 13, 10, 94, 77, 78, 87, 13, 10, 94, 77, 84, 84, 13, 10, 94, 80, 79, 78, 13, 10, 94, 80, 77, 78, 13, 10, 94, 76, 72, 48, 44, 48, 13, 10, 94, 74, 77, 65, 13, 10, 94, 80, 82, 50, 44, 50, 13, 10, 126, 83, 68, 49, 53, 13, 10, 94, 74, 85, 83, 13, 10, 94, 76, 82, 78, 13, 10, 94, 67, 73, 50, 55, 13, 10, 94, 80, 65, 48, 44, 49, 44, 49, 44, 48, 13, 10, 94, 88, 90, 13, 10, 94, 88, 65, 13, 10, 94, 77, 77, 84, 13, 10, 94, 80, 87, 49, 56, 48, 48, 13, 10, 94, 76, 76, 49, 50, 48, 48, 13, 10, 94, 76, 83, 48, 13, 10, 94, 70, 79, 49, 49, 53, 44, 57, 56, 94, 71, 70, 65, 44, 49, 52, 48, 57, 44, 57, 49, 54, 48, 44, 52, 48, 44, 58, 90, 54, 52, 58, 101, 74, 122, 70, 109, 114, 70, 117, 50, 122, 65, 85, 82, 99, 85, 73, 103, 90, 120, 109, 99, 68, 116, 108, 75, 99, 67, 49, 83, 68, 57, 67, 118, 57, 67, 108, 121, 78, 99, 69, 70, 74, 65, 108, 81, 73, 102, 56, 81, 109, 100, 51, 121, 78, 54, 104, 100, 116, 71, 108, 89, 122, 56, 104, 81, 74, 99, 67, 72, 90, 114, 82, 97, 70, 50, 122, 73, 109, 108, 76, 102, 68, 84, 102, 52, 55, 86, 104, 78, 71, 57, 81, 89, 118, 110, 103, 56, 117, 112, 75, 102, 70, 75, 111, 86, 70, 88, 86, 100, 86, 86, 112, 56, 53, 81, 49, 109, 85, 120, 75, 109, 54, 99, 116, 76, 114, 88, 90, 101, 118, 103, 111, 108, 98, 89, 114, 90, 74, 81, 84, 97, 57, 100, 108, 83, 114, 50, 57, 115, 111, 108, 101, 76, 114, 66, 55, 54, 50, 112, 100, 121, 107, 57, 53, 114, 79, 121, 118, 68, 108, 122, 82, 88, 53, 80, 86, 50, 52, 49, 117, 118, 117, 71, 71, 102, 85, 119, 90, 122, 78, 47, 71, 110, 108, 49, 105, 57, 103, 106, 110, 52, 48, 107, 50, 50, 109, 55, 72, 72, 102, 102, 108, 97, 117, 84, 107, 50, 109, 68, 70, 47, 69, 121, 71, 54, 49, 119, 43, 100, 70, 79, 80, 101, 117, 77, 88, 109, 86, 73, 87, 56, 57, 102, 115, 121, 120, 88, 121, 48, 121, 77, 110, 53, 113, 100, 122, 101, 112, 108, 113, 81, 99, 55, 107, 117, 69, 120, 43, 100, 117, 83, 107, 47, 73, 98, 52, 67, 114, 107, 77, 112, 54, 78, 119, 102, 112, 115, 115, 116, 53, 118, 102, 100, 79, 66, 115, 74, 43, 87, 110, 82, 48, 52, 99, 116, 52, 51, 48, 81, 73, 53, 43, 107, 99, 120, 102, 83, 47, 88, 89, 43, 87, 115, 52, 118, 97, 81, 115, 120, 105, 109, 79, 83, 49, 114, 102, 43, 89, 105, 74, 47, 97, 56, 66, 120, 55, 51, 72, 79, 71, 86, 89, 106, 117, 82, 88, 82, 53, 104, 48, 47, 52, 106, 116, 83, 100, 100, 102, 114, 80, 100, 98, 52, 71, 73, 57, 79, 111, 57, 111, 102, 106, 98, 109, 104, 80, 120, 105, 55, 108, 69, 89, 49, 55, 76, 106, 107, 108, 75, 67, 88, 112, 120, 102, 84, 102, 83, 71, 76, 47, 98, 83, 79, 43, 103, 52, 68, 77, 79, 108, 56, 55, 99, 108, 120, 56, 118, 80, 88, 56, 114, 120, 104, 88, 73, 88, 68, 74, 102, 50, 118, 53, 117, 73, 107, 43, 52, 102, 99, 89, 68, 111, 57, 83, 102, 49, 80, 56, 51, 111, 83, 102, 108, 74, 57, 49, 57, 79, 84, 43, 74, 81, 102, 47, 72, 56, 84, 102, 79, 55, 65, 47, 79, 76, 117, 114, 106, 111, 98, 48, 114, 48, 43, 79, 76, 54, 81, 90, 112, 102, 114, 76, 99, 85, 55, 104, 43, 120, 51, 116, 56, 70, 53, 117, 47, 80, 65, 43, 98, 80, 85, 111, 55, 48, 118, 50, 110, 75, 77, 102, 50, 80, 99, 77, 76, 69, 66, 68, 109, 108, 87, 89, 55, 48, 80, 121, 76, 110, 74, 104, 76, 84, 47, 52, 105, 99, 77, 75, 55, 70, 79, 72, 76, 51, 83, 76, 107, 111, 118, 120, 117, 113, 116, 54, 121, 89, 47, 74, 81, 86, 57, 80, 113, 54, 110, 77, 47, 56, 122, 49, 114, 109, 84, 118, 116, 57, 51, 57, 119, 118, 106, 99, 68, 49, 67, 102, 109, 100, 88, 84, 74, 55, 100, 47, 77, 76, 75, 111, 117, 75, 100, 116, 80, 100, 99, 89, 80, 75, 119, 56, 110, 108, 97, 52, 113, 108, 68, 84, 67, 111, 80, 71, 113, 84, 121, 75, 88, 53, 104, 90, 49, 114, 117, 49, 78, 74, 102, 113, 109, 77, 55, 67, 57, 84, 87, 88, 43, 121, 110, 111, 117, 72, 53, 90, 90, 48, 47, 113, 76, 43, 101, 76, 51, 57, 47, 98, 110, 109, 112, 108, 107, 57, 50, 118, 57, 89, 55, 115, 68, 56, 69, 68, 48, 88, 122, 112, 84, 106, 107, 118, 119, 97, 106, 107, 118, 56, 49, 82, 121, 51, 66, 76, 107, 107, 80, 49, 54, 80, 53, 113, 99, 52, 55, 107, 66, 47, 105, 74, 52, 76, 104, 57, 101, 106, 43, 82, 51, 98, 72, 51, 103, 43, 117, 114, 109, 107, 100, 56, 68, 56, 53, 98, 68, 68, 117, 77, 107, 90, 121, 57, 72, 43, 120, 56, 97, 88, 106, 77, 118, 71, 108, 57, 120, 88, 85, 101, 53, 79, 53, 77, 98, 56, 78, 77, 115, 116, 115, 70, 106, 111, 117, 80, 122, 104, 85, 106, 49, 50, 57, 108, 114, 55, 78, 99, 54, 80, 116, 48, 102, 49, 87, 112, 55, 114, 89, 115, 55, 119, 72, 72, 103, 89, 53, 79, 57, 102, 105, 81, 77, 80, 108, 47, 106, 84, 109, 70, 53, 54, 121, 54, 86, 99, 78, 72, 56, 70, 106, 106, 120, 51, 72, 112, 110, 106, 74, 50, 47, 121, 47, 67, 122, 111, 114, 89, 55, 115, 106, 122, 119, 47, 105, 120, 121, 87, 72, 43, 113, 80, 116, 114, 56, 88, 86, 54, 89, 118, 97, 50, 83, 117, 68, 54, 101, 55, 110, 99, 49, 109, 101, 84, 49, 120, 47, 87, 43, 52, 49, 69, 114, 114, 107, 49, 117, 117, 116, 68, 54, 112, 77, 110, 113, 53, 57, 100, 79, 122, 81, 85, 57, 101, 80, 54, 49, 65, 102, 57, 115, 49, 109, 75, 79, 116, 80, 50, 47, 88, 115, 52, 100, 57, 84, 78, 87, 103, 80, 51, 82, 57, 80, 76, 118, 101, 110, 108, 117, 47, 51, 43, 103, 86, 51, 51, 56, 89, 122, 70, 56, 70, 43, 115, 118, 114, 90, 86, 53, 57, 103, 80, 110, 57, 70, 51, 43, 53, 47, 65, 121, 89, 110, 119, 98, 57, 116, 97, 67, 47, 66, 115, 122, 118, 87, 101, 67, 71, 102, 87, 119, 90, 122, 70, 56, 119, 67, 76, 119, 47, 117, 107, 68, 109, 55, 51, 89, 82, 117, 118, 84, 43, 111, 57, 111, 99, 77, 79, 67, 118, 66, 106, 110, 47, 104, 51, 68, 77, 90, 100, 98, 118, 104, 48, 88, 56, 86, 97, 72, 47, 117, 100, 76, 89, 117, 80, 54, 65, 69, 85, 53, 104, 43, 102, 108, 76, 117, 116, 106, 47, 78, 103, 97, 66, 56, 120, 89, 77, 73, 108, 120, 106, 120, 102, 87, 114, 89, 88, 80, 106, 53, 113, 47, 55, 98, 83, 110, 109, 53, 121, 53, 66, 102, 55, 120, 75, 87, 104, 49, 49, 49, 89, 98, 72, 50, 80, 114, 55, 103, 121, 106, 88, 71, 49, 122, 52, 72, 53, 43, 47, 117, 66, 57, 115, 102, 112, 80, 122, 47, 110, 72, 73, 88, 89, 107, 47, 102, 57, 51, 75, 65, 120, 117, 47, 49, 102, 90, 108, 121, 87, 65, 88, 98, 72, 52, 115, 99, 78, 114, 55, 77, 56, 78, 84, 79, 102, 102, 43, 116, 51, 85, 72, 43, 105, 70, 57, 50, 115, 55, 114, 110, 81, 74, 110, 114, 51, 51, 118, 84, 51, 76, 120, 97, 109, 105, 114, 78, 43, 54, 113, 51, 116, 112, 106, 51, 53, 113, 51, 55, 57, 98, 122, 110, 118, 116, 82, 48, 106, 79, 104, 97, 53, 87, 119, 97, 117, 50, 98, 106, 80, 83, 83, 73, 100, 83, 49, 98, 49, 113, 76, 52, 84, 79, 88, 88, 50, 106, 54, 120, 102, 102, 110, 67, 117, 122, 82, 52, 83, 90, 99, 101, 103, 101, 56, 49, 82, 118, 116, 99, 102, 107, 70, 118, 100, 118, 105, 47, 120, 56, 111, 115, 76, 88, 53, 70, 49, 80, 70, 107, 43, 70, 98, 80, 108, 86, 106, 56, 110, 78, 113, 72, 102, 68, 47, 66, 57, 100, 89, 51, 54, 104, 87, 110, 49, 53, 66, 51, 79, 80, 122, 43, 66, 77, 47, 102, 56, 80, 98, 111, 54, 114, 85, 47, 57, 81, 67, 71, 114, 87, 113, 79, 52, 120, 76, 105, 117, 49, 47, 121, 101, 97, 112, 105, 115, 43, 80, 98, 118, 52, 66, 69, 119, 105, 47, 98, 81, 61, 61, 58, 53, 49, 65, 51, 13, 10, 94, 70, 84, 52, 50, 51, 44, 49, 56, 53, 94, 65, 48, 78, 44, 56, 50, 44, 56, 49, 94, 70, 72, 92, 94, 67, 73, 50, 56, 94, 70, 68, 78, 101, 119, 32, 89, 111, 114, 107, 32, 83, 116, 97, 116, 101, 32, 72, 117, 110, 116, 105, 110, 103, 32, 76, 105, 99, 101, 110, 115, 101, 94, 70, 83, 94, 67, 73, 50, 55, 13, 10, 94, 70, 84, 52, 51, 51, 44, 51, 55, 55, 94, 65, 48, 78, 44, 49, 54, 55, 44, 49, 54, 55, 94, 70, 72, 92, 94, 67, 73, 50, 56, 94, 70, 68, 50, 48, 50, 52, 94, 70, 83, 94, 67, 73, 50, 55, 13, 10, 94, 70, 84, 49, 49, 53, 44, 53, 57, 48, 94, 65, 48, 78, 44, 53, 56, 44, 53, 56, 94, 70, 72, 92, 94, 67, 73, 50, 56, 94, 70, 68, 94, 86, 78, 97, 109, 101, 36, 94, 70, 83, 94, 67, 73, 50, 55, 13, 10, 94, 70, 84, 49, 49, 53, 44, 55, 48, 52, 94, 65, 48, 78, 44, 53, 56, 44, 53, 56, 94, 70, 72, 92, 94, 67, 73, 50, 56, 94, 70, 68, 94, 86, 65, 100, 100, 114, 101, 115, 115, 36, 94, 70, 83, 94, 67, 73, 50, 55, 13, 10, 94, 70, 84, 49, 49, 53, 44, 56, 49, 56, 94, 65, 48, 78, 44, 53, 56, 44, 53, 56, 94, 70, 72, 92, 94, 67, 73, 50, 56, 94, 70, 68, 94, 86, 67, 83, 90, 36, 94, 70, 83, 94, 67, 73, 50, 55, 94, 80, 81, 49, 44, 48, 44, 49, 44, 89, 13, 10, 94, 88, 90, 13, 10 }, new Guid("fa7c2b5e-6e3b-4a9f-b2d1-1d3f9e8b4c7f"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f5a7e9b1-7c8d-4a0f-9d3a-b3c1d4f9e6b2") },
                    { new Guid("c4f9b2a3-5e1d-4a0f-8d3e-f9a6d3e8c1b7"), new byte[] { 16, 67, 84, 126, 126, 67, 68, 44, 126, 67, 67, 94, 126, 67, 84, 126, 13, 10, 94, 88, 65, 13, 10, 126, 84, 65, 48, 48, 48, 13, 10, 126, 74, 83, 78, 13, 10, 94, 76, 84, 48, 13, 10, 94, 77, 78, 87, 13, 10, 94, 77, 84, 84, 13, 10, 94, 80, 79, 78, 13, 10, 94, 80, 77, 78, 13, 10, 94, 76, 72, 48, 44, 48, 13, 10, 94, 74, 77, 65, 13, 10, 94, 80, 82, 50, 44, 50, 13, 10, 126, 83, 68, 49, 53, 13, 10, 94, 74, 85, 83, 13, 10, 94, 76, 82, 78, 13, 10, 94, 67, 73, 50, 55, 13, 10, 94, 80, 65, 48, 44, 49, 44, 49, 44, 48, 13, 10, 94, 88, 90, 13, 10, 94, 88, 65, 13, 10, 94, 77, 77, 84, 13, 10, 94, 80, 87, 49, 56, 48, 48, 13, 10, 94, 76, 76, 49, 50, 48, 48, 13, 10, 94, 76, 83, 48, 13, 10, 94, 70, 79, 49, 49, 53, 44, 57, 56, 94, 71, 70, 65, 44, 49, 52, 48, 57, 44, 57, 49, 54, 48, 44, 52, 48, 44, 58, 90, 54, 52, 58, 101, 74, 122, 70, 109, 114, 70, 117, 50, 122, 65, 85, 82, 99, 85, 73, 103, 90, 120, 109, 99, 68, 116, 108, 75, 99, 67, 49, 83, 68, 57, 67, 118, 57, 67, 108, 121, 78, 99, 69, 70, 74, 65, 108, 81, 73, 102, 56, 81, 109, 100, 51, 121, 78, 54, 104, 100, 116, 71, 108, 89, 122, 56, 104, 81, 74, 99, 67, 72, 90, 114, 82, 97, 70, 50, 122, 73, 109, 108, 76, 102, 68, 84, 102, 52, 55, 86, 104, 78, 71, 57, 81, 89, 118, 110, 103, 56, 117, 112, 75, 102, 70, 75, 111, 86, 70, 88, 86, 100, 86, 86, 112, 56, 53, 81, 49, 109, 85, 120, 75, 109, 54, 99, 116, 76, 114, 88, 90, 101, 118, 103, 111, 108, 98, 89, 114, 90, 74, 81, 84, 97, 57, 100, 108, 83, 114, 50, 57, 115, 111, 108, 101, 76, 114, 66, 55, 54, 50, 112, 100, 121, 107, 57, 53, 114, 79, 121, 118, 68, 108, 122, 82, 88, 53, 80, 86, 50, 52, 49, 117, 118, 117, 71, 71, 102, 85, 119, 90, 122, 78, 47, 71, 110, 108, 49, 105, 57, 103, 106, 110, 52, 48, 107, 50, 50, 109, 55, 72, 72, 102, 102, 108, 97, 117, 84, 107, 50, 109, 68, 70, 47, 69, 121, 71, 54, 49, 119, 43, 100, 70, 79, 80, 101, 117, 77, 88, 109, 86, 73, 87, 56, 57, 102, 115, 121, 120, 88, 121, 48, 121, 77, 110, 53, 113, 100, 122, 101, 112, 108, 113, 81, 99, 55, 107, 117, 69, 120, 43, 100, 117, 83, 107, 47, 73, 98, 52, 67, 114, 107, 77, 112, 54, 78, 119, 102, 112, 115, 115, 116, 53, 118, 102, 100, 79, 66, 115, 74, 43, 87, 110, 82, 48, 52, 99, 116, 52, 51, 48, 81, 73, 53, 43, 107, 99, 120, 102, 83, 47, 88, 89, 43, 87, 115, 52, 118, 97, 81, 115, 120, 105, 109, 79, 83, 49, 114, 102, 43, 89, 105, 74, 47, 97, 56, 66, 120, 55, 51, 72, 79, 71, 86, 89, 106, 117, 82, 88, 82, 53, 104, 48, 47, 52, 106, 116, 83, 100, 100, 102, 114, 80, 100, 98, 52, 71, 73, 57, 79, 111, 57, 111, 102, 106, 98, 109, 104, 80, 120, 105, 55, 108, 69, 89, 49, 55, 76, 106, 107, 108, 75, 67, 88, 112, 120, 102, 84, 102, 83, 71, 76, 47, 98, 83, 79, 43, 103, 52, 68, 77, 79, 108, 56, 55, 99, 108, 120, 56, 118, 80, 88, 56, 114, 120, 104, 88, 73, 88, 68, 74, 102, 50, 118, 53, 117, 73, 107, 43, 52, 102, 99, 89, 68, 111, 57, 83, 102, 49, 80, 56, 51, 111, 83, 102, 108, 74, 57, 49, 57, 79, 84, 43, 74, 81, 102, 47, 72, 56, 84, 102, 79, 55, 65, 47, 79, 76, 117, 114, 106, 111, 98, 48, 114, 48, 43, 79, 76, 54, 81, 90, 112, 102, 114, 76, 99, 85, 55, 104, 43, 120, 51, 116, 56, 70, 53, 117, 47, 80, 65, 43, 98, 80, 85, 111, 55, 48, 118, 50, 110, 75, 77, 102, 50, 80, 99, 77, 76, 69, 66, 68, 109, 108, 87, 89, 55, 48, 80, 121, 76, 110, 74, 104, 76, 84, 47, 52, 105, 99, 77, 75, 55, 70, 79, 72, 76, 51, 83, 76, 107, 111, 118, 120, 117, 113, 116, 54, 121, 89, 47, 74, 81, 86, 57, 80, 113, 54, 110, 77, 47, 56, 122, 49, 114, 109, 84, 118, 116, 57, 51, 57, 119, 118, 106, 99, 68, 49, 67, 102, 109, 100, 88, 84, 74, 55, 100, 47, 77, 76, 75, 111, 117, 75, 100, 116, 80, 100, 99, 89, 80, 75, 119, 56, 110, 108, 97, 52, 113, 108, 68, 84, 67, 111, 80, 71, 113, 84, 121, 75, 88, 53, 104, 90, 49, 114, 117, 49, 78, 74, 102, 113, 109, 77, 55, 67, 57, 84, 87, 88, 43, 121, 110, 111, 117, 72, 53, 90, 90, 48, 47, 113, 76, 43, 101, 76, 51, 57, 47, 98, 110, 109, 112, 108, 107, 57, 50, 118, 57, 89, 55, 115, 68, 56, 69, 68, 48, 88, 122, 112, 84, 106, 107, 118, 119, 97, 106, 107, 118, 56, 49, 82, 121, 51, 66, 76, 107, 107, 80, 49, 54, 80, 53, 113, 99, 52, 55, 107, 66, 47, 105, 74, 52, 76, 104, 57, 101, 106, 43, 82, 51, 98, 72, 51, 103, 43, 117, 114, 109, 107, 100, 56, 68, 56, 53, 98, 68, 68, 117, 77, 107, 90, 121, 57, 72, 43, 120, 56, 97, 88, 106, 77, 118, 71, 108, 57, 120, 88, 85, 101, 53, 79, 53, 77, 98, 56, 78, 77, 115, 116, 115, 70, 106, 111, 117, 80, 122, 104, 85, 106, 49, 50, 57, 108, 114, 55, 78, 99, 54, 80, 116, 48, 102, 49, 87, 112, 55, 114, 89, 115, 55, 119, 72, 72, 103, 89, 53, 79, 57, 102, 105, 81, 77, 80, 108, 47, 106, 84, 109, 70, 53, 54, 121, 54, 86, 99, 78, 72, 56, 70, 106, 106, 120, 51, 72, 112, 110, 106, 74, 50, 47, 121, 47, 67, 122, 111, 114, 89, 55, 115, 106, 122, 119, 47, 105, 120, 121, 87, 72, 43, 113, 80, 116, 114, 56, 88, 86, 54, 89, 118, 97, 50, 83, 117, 68, 54, 101, 55, 110, 99, 49, 109, 101, 84, 49, 120, 47, 87, 43, 52, 49, 69, 114, 114, 107, 49, 117, 117, 116, 68, 54, 112, 77, 110, 113, 53, 57, 100, 79, 122, 81, 85, 57, 101, 80, 54, 49, 65, 102, 57, 115, 49, 109, 75, 79, 116, 80, 50, 47, 88, 115, 52, 100, 57, 84, 78, 87, 103, 80, 51, 82, 57, 80, 76, 118, 101, 110, 108, 117, 47, 51, 43, 103, 86, 51, 51, 56, 89, 122, 70, 56, 70, 43, 115, 118, 114, 90, 86, 53, 57, 103, 80, 110, 57, 70, 51, 43, 53, 47, 65, 121, 89, 110, 119, 98, 57, 116, 97, 67, 47, 66, 115, 122, 118, 87, 101, 67, 71, 102, 87, 119, 90, 122, 70, 56, 119, 67, 76, 119, 47, 117, 107, 68, 109, 55, 51, 89, 82, 117, 118, 84, 43, 111, 57, 111, 99, 77, 79, 67, 118, 66, 106, 110, 47, 104, 51, 68, 77, 90, 100, 98, 118, 104, 48, 88, 56, 86, 97, 72, 47, 117, 100, 76, 89, 117, 80, 54, 65, 69, 85, 53, 104, 43, 102, 108, 76, 117, 116, 106, 47, 78, 103, 97, 66, 56, 120, 89, 77, 73, 108, 120, 106, 120, 102, 87, 114, 89, 88, 80, 106, 53, 113, 47, 55, 98, 83, 110, 109, 53, 121, 53, 66, 102, 55, 120, 75, 87, 104, 49, 49, 49, 89, 98, 72, 50, 80, 114, 55, 103, 121, 106, 88, 71, 49, 122, 52, 72, 53, 43, 47, 117, 66, 57, 115, 102, 112, 80, 122, 47, 110, 72, 73, 88, 89, 107, 47, 102, 57, 51, 75, 65, 120, 117, 47, 49, 102, 90, 108, 121, 87, 65, 88, 98, 72, 52, 115, 99, 78, 114, 55, 77, 56, 78, 84, 79, 102, 102, 43, 116, 51, 85, 72, 43, 105, 70, 57, 50, 115, 55, 114, 110, 81, 74, 110, 114, 51, 51, 118, 84, 51, 76, 120, 97, 109, 105, 114, 78, 43, 54, 113, 51, 116, 112, 106, 51, 53, 113, 51, 55, 57, 98, 122, 110, 118, 116, 82, 48, 106, 79, 104, 97, 53, 87, 119, 97, 117, 50, 98, 106, 80, 83, 83, 73, 100, 83, 49, 98, 49, 113, 76, 52, 84, 79, 88, 88, 50, 106, 54, 120, 102, 102, 110, 67, 117, 122, 82, 52, 83, 90, 99, 101, 103, 101, 56, 49, 82, 118, 116, 99, 102, 107, 70, 118, 100, 118, 105, 47, 120, 56, 111, 115, 76, 88, 53, 70, 49, 80, 70, 107, 43, 70, 98, 80, 108, 86, 106, 56, 110, 78, 113, 72, 102, 68, 47, 66, 57, 100, 89, 51, 54, 104, 87, 110, 49, 53, 66, 51, 79, 80, 122, 43, 66, 77, 47, 102, 56, 80, 98, 111, 54, 114, 85, 47, 57, 81, 67, 71, 114, 87, 113, 79, 52, 120, 76, 105, 117, 49, 47, 121, 101, 97, 112, 105, 115, 43, 80, 98, 118, 52, 66, 69, 119, 105, 47, 98, 81, 61, 61, 58, 53, 49, 65, 51, 13, 10, 94, 70, 84, 52, 50, 51, 44, 49, 56, 53, 94, 65, 48, 78, 44, 56, 50, 44, 56, 49, 94, 70, 72, 92, 94, 67, 73, 50, 56, 94, 70, 68, 78, 101, 119, 32, 89, 111, 114, 107, 32, 83, 116, 97, 116, 101, 32, 72, 117, 110, 116, 105, 110, 103, 32, 76, 105, 99, 101, 110, 115, 101, 94, 70, 83, 94, 67, 73, 50, 55, 13, 10, 94, 70, 84, 52, 51, 51, 44, 51, 55, 55, 94, 65, 48, 78, 44, 49, 54, 55, 44, 49, 54, 55, 94, 70, 72, 92, 94, 67, 73, 50, 56, 94, 70, 68, 50, 48, 50, 51, 94, 70, 83, 94, 67, 73, 50, 55, 13, 10, 94, 70, 84, 49, 49, 53, 44, 53, 57, 48, 94, 65, 48, 78, 44, 53, 56, 44, 53, 56, 94, 70, 72, 92, 94, 67, 73, 50, 56, 94, 70, 68, 94, 86, 78, 97, 109, 101, 36, 94, 70, 83, 94, 67, 73, 50, 55, 13, 10, 94, 70, 84, 49, 49, 53, 44, 55, 48, 52, 94, 65, 48, 78, 44, 53, 56, 44, 53, 56, 94, 70, 72, 92, 94, 67, 73, 50, 56, 94, 70, 68, 94, 86, 65, 100, 100, 114, 101, 115, 115, 36, 94, 70, 83, 94, 67, 73, 50, 55, 13, 10, 94, 70, 84, 49, 49, 53, 44, 56, 49, 56, 94, 65, 48, 78, 44, 53, 56, 44, 53, 56, 94, 70, 72, 92, 94, 67, 73, 50, 56, 94, 70, 68, 94, 86, 67, 83, 90, 36, 94, 70, 83, 94, 67, 73, 50, 55, 94, 80, 81, 49, 44, 48, 44, 49, 44, 89, 13, 10, 94, 88, 90, 13, 10 }, new Guid("fa7c2b5e-6e3b-4a9f-b2d1-1d3f9e8b4c7f"), new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f5a7e9b1-7c8d-4a0f-9d3a-b3c1d4f9e6b2") },
                    { new Guid("e8d5b3c1-4f7a-4d2f-8b1e-c9a4e2f7b6d3"), new byte[] { 16, 67, 84, 126, 126, 67, 68, 44, 126, 67, 67, 94, 126, 67, 84, 126, 13, 10, 94, 88, 65, 13, 10, 126, 84, 65, 48, 48, 48, 13, 10, 126, 74, 83, 78, 13, 10, 94, 76, 84, 48, 13, 10, 94, 77, 78, 87, 13, 10, 94, 77, 84, 84, 13, 10, 94, 80, 79, 78, 13, 10, 94, 80, 77, 78, 13, 10, 94, 76, 72, 48, 44, 48, 13, 10, 94, 74, 77, 65, 13, 10, 94, 80, 82, 50, 44, 50, 13, 10, 126, 83, 68, 49, 53, 13, 10, 94, 74, 85, 83, 13, 10, 94, 76, 82, 78, 13, 10, 94, 67, 73, 50, 55, 13, 10, 94, 80, 65, 48, 44, 49, 44, 49, 44, 48, 13, 10, 94, 88, 90, 13, 10, 94, 88, 65, 13, 10, 94, 77, 77, 84, 13, 10, 94, 80, 87, 49, 56, 48, 48, 13, 10, 94, 76, 76, 49, 50, 48, 48, 13, 10, 94, 76, 83, 48, 13, 10, 94, 70, 79, 49, 49, 53, 44, 57, 56, 94, 71, 70, 65, 44, 49, 53, 55, 51, 44, 57, 56, 56, 52, 44, 50, 56, 44, 58, 90, 54, 52, 58, 101, 74, 122, 78, 109, 84, 49, 117, 50, 48, 65, 81, 104, 85, 107, 114, 104, 111, 121, 52, 85, 66, 87, 111, 53, 66, 70, 121, 66, 79, 111, 73, 117, 89, 70, 121, 66, 68, 101, 66, 71, 121, 78, 107, 110, 83, 90, 88, 85, 71, 110, 107, 69, 66, 71, 114, 49, 76, 53, 65, 65, 77, 71, 86, 52, 81, 67, 75, 67, 103, 99, 87, 66, 73, 107, 75, 82, 90, 71, 55, 115, 47, 80, 122, 74, 78, 66, 82, 52, 68, 86, 99, 50, 65, 56, 102, 90, 57, 47, 77, 55, 75, 54, 48, 106, 75, 74, 113, 68, 76, 98, 122, 99, 106, 53, 47, 102, 80, 122, 109, 120, 109, 51, 85, 106, 118, 55, 87, 106, 56, 51, 109, 90, 122, 88, 117, 110, 78, 98, 98, 56, 114, 70, 48, 87, 105, 121, 48, 74, 54, 101, 100, 65, 83, 53, 75, 98, 75, 54, 97, 113, 77, 51, 49, 77, 122, 97, 117, 118, 67, 89, 109, 83, 106, 103, 120, 48, 89, 88, 88, 73, 113, 68, 70, 50, 43, 102, 119, 66, 51, 69, 80, 82, 77, 117, 89, 86, 103, 66, 117, 82, 106, 107, 50, 82, 107, 83, 98, 103, 110, 103, 56, 111, 88, 83, 101, 80, 75, 69, 107, 76, 121, 73, 120, 108, 79, 77, 86, 112, 66, 119, 51, 71, 71, 104, 112, 113, 75, 50, 111, 108, 111, 84, 43, 98, 113, 106, 71, 74, 108, 114, 109, 119, 69, 81, 66, 78, 74, 114, 81, 80, 113, 118, 103, 115, 89, 110, 112, 77, 50, 49, 78, 78, 78, 53, 112, 49, 71, 65, 118, 115, 119, 49, 121, 98, 103, 109, 48, 111, 43, 77, 66, 55, 112, 74, 112, 74, 101, 67, 50, 82, 50, 112, 105, 66, 89, 74, 56, 48, 103, 76, 121, 102, 71, 52, 66, 82, 55, 85, 104, 88, 52, 70, 69, 83, 122, 108, 72, 52, 111, 51, 116, 90, 56, 111, 100, 122, 88, 77, 120, 116, 48, 100, 87, 111, 74, 103, 109, 97, 84, 82, 104, 106, 122, 84, 111, 113, 43, 73, 54, 43, 107, 116, 65, 118, 66, 82, 119, 54, 84, 79, 118, 110, 43, 99, 69, 82, 114, 106, 77, 106, 115, 101, 55, 109, 110, 75, 74, 115, 79, 102, 57, 83, 99, 120, 120, 56, 104, 122, 122, 56, 100, 52, 68, 98, 109, 104, 121, 98, 54, 101, 75, 49, 72, 68, 118, 78, 75, 110, 104, 86, 71, 122, 80, 121, 100, 98, 48, 47, 106, 81, 68, 106, 116, 79, 49, 79, 112, 53, 99, 67, 112, 81, 84, 116, 88, 80, 49, 119, 49, 121, 51, 101, 76, 73, 49, 118, 84, 47, 90, 109, 111, 84, 114, 71, 69, 47, 112, 77, 99, 101, 104, 79, 105, 104, 114, 119, 88, 77, 112, 52, 109, 120, 47, 104, 115, 69, 90, 48, 73, 114, 68, 110, 70, 48, 47, 121, 67, 70, 47, 50, 109, 111, 52, 120, 104, 47, 107, 117, 115, 89, 68, 88, 72, 111, 67, 68, 118, 83, 110, 116, 114, 107, 52, 84, 116, 100, 101, 116, 80, 54, 85, 80, 100, 66, 120, 88, 100, 99, 68, 47, 43, 82, 67, 47, 90, 48, 105, 72, 117, 75, 54, 114, 118, 99, 85, 99, 76, 113, 57, 50, 116, 56, 88, 72, 97, 117, 53, 115, 97, 69, 86, 90, 109, 86, 114, 122, 113, 104, 101, 88, 84, 56, 106, 109, 122, 86, 110, 117, 75, 118, 106, 71, 86, 110, 90, 99, 52, 97, 57, 110, 84, 43, 106, 67, 115, 48, 56, 55, 88, 105, 118, 105, 84, 79, 54, 115, 47, 89, 72, 56, 119, 76, 105, 89, 99, 54, 117, 72, 43, 73, 83, 69, 67, 57, 70, 72, 80, 65, 51, 66, 100, 121, 52, 89, 55, 119, 77, 99, 74, 90, 48, 105, 68, 79, 49, 109, 98, 110, 54, 97, 110, 57, 100, 52, 121, 72, 117, 71, 116, 84, 118, 70, 80, 71, 54, 43, 107, 116, 65, 118, 76, 81, 106, 57, 55, 47, 55, 56, 120, 84, 122, 55, 76, 114, 43, 122, 107, 69, 56, 117, 67, 56, 66, 102, 49, 51, 51, 77, 51, 81, 43, 109, 73, 51, 50, 69, 105, 52, 70, 110, 70, 88, 65, 107, 88, 51, 99, 49, 112, 121, 49, 103, 82, 98, 50, 56, 86, 53, 122, 115, 86, 48, 47, 53, 87, 55, 81, 99, 53, 98, 66, 103, 43, 102, 55, 48, 80, 89, 88, 102, 81, 87, 99, 48, 84, 69, 72, 80, 55, 47, 65, 55, 119, 43, 73, 71, 119, 77, 117, 66, 86, 121, 56, 78, 102, 48, 90, 71, 100, 49, 122, 43, 107, 84, 51, 56, 102, 83, 65, 68, 83, 102, 117, 88, 113, 113, 102, 57, 104, 53, 70, 98, 90, 108, 56, 114, 50, 107, 116, 115, 50, 107, 52, 76, 97, 80, 116, 118, 90, 83, 50, 66, 116, 118, 55, 77, 56, 50, 103, 117, 49, 47, 83, 53, 104, 76, 90, 109, 114, 115, 72, 121, 47, 52, 100, 116, 119, 97, 97, 117, 43, 100, 84, 47, 70, 50, 66, 101, 65, 47, 103, 109, 101, 52, 101, 77, 48, 88, 120, 90, 80, 48, 87, 73, 74, 55, 76, 112, 120, 73, 80, 53, 99, 88, 100, 110, 50, 110, 57, 101, 82, 83, 110, 97, 73, 88, 116, 98, 122, 116, 112, 116, 65, 82, 119, 103, 51, 73, 113, 116, 68, 97, 104, 121, 85, 76, 101, 51, 77, 120, 97, 98, 105, 90, 98, 116, 78, 88, 54, 73, 55, 109, 78, 106, 104, 114, 116, 77, 112, 101, 55, 84, 77, 116, 70, 121, 112, 111, 111, 118, 67, 89, 67, 69, 107, 53, 56, 106, 121, 65, 97, 101, 103, 77, 104, 122, 105, 88, 67, 119, 84, 99, 108, 90, 111, 77, 101, 101, 68, 80, 68, 116, 88, 86, 72, 98, 116, 71, 82, 71, 51, 108, 78, 43, 74, 115, 81, 122, 117, 114, 80, 83, 76, 107, 118, 122, 43, 49, 52, 57, 74, 53, 100, 51, 72, 116, 72, 108, 65, 118, 114, 104, 55, 104, 106, 51, 122, 56, 103, 106, 112, 43, 67, 112, 72, 120, 105, 75, 97, 69, 88, 83, 65, 88, 103, 83, 68, 114, 70, 48, 105, 85, 83, 98, 56, 47, 103, 102, 81, 55, 106, 48, 75, 115, 74, 113, 118, 69, 122, 56, 68, 78, 73, 83, 119, 107, 48, 109, 107, 53, 117, 106, 51, 73, 74, 87, 51, 50, 85, 52, 121, 107, 55, 86, 117, 80, 120, 97, 80, 110, 89, 57, 110, 76, 122, 119, 101, 97, 87, 78, 74, 48, 115, 72, 110, 51, 76, 120, 98, 107, 90, 49, 89, 97, 65, 89, 122, 109, 106, 51, 99, 76, 98, 77, 51, 104, 109, 68, 50, 104, 115, 101, 54, 72, 100, 121, 102, 116, 108, 82, 102, 50, 120, 102, 108, 107, 72, 88, 71, 105, 119, 68, 76, 82, 119, 47, 84, 48, 70, 87, 109, 103, 119, 101, 73, 88, 74, 80, 104, 88, 101, 66, 86, 114, 52, 87, 87, 81, 83, 97, 79, 69, 90, 71, 69, 113, 104, 119, 84, 122, 85, 69, 113, 111, 120, 98, 103, 67, 52, 56, 56, 122, 109, 76, 103, 65, 88, 90, 74, 82, 114, 119, 70, 57, 56, 55, 101, 49, 57, 89, 108, 106, 48, 109, 54, 83, 84, 80, 53, 79, 99, 83, 65, 118, 79, 107, 89, 121, 117, 79, 66, 101, 78, 102, 102, 50, 52, 82, 79, 54, 72, 83, 56, 72, 53, 72, 116, 48, 73, 106, 118, 84, 111, 104, 71, 117, 107, 82, 48, 99, 67, 57, 78, 120, 77, 97, 67, 54, 106, 71, 56, 67, 116, 104, 79, 82, 76, 76, 47, 74, 67, 83, 114, 43, 85, 50, 106, 110, 103, 110, 69, 69, 53, 84, 87, 47, 119, 111, 57, 82, 99, 74, 82, 54, 107, 70, 111, 78, 52, 90, 48, 66, 122, 110, 50, 69, 81, 112, 47, 104, 122, 56, 100, 90, 83, 99, 47, 53, 75, 104, 88, 80, 98, 74, 43, 74, 121, 79, 53, 55, 115, 77, 49, 47, 65, 55, 52, 114, 87, 70, 80, 55, 80, 71, 48, 87, 98, 78, 118, 89, 117, 70, 75, 48, 112, 102, 75, 70, 73, 122, 97, 97, 50, 109, 109, 104, 97, 111, 109, 121, 101, 52, 84, 79, 86, 54, 106, 108, 78, 68, 100, 102, 69, 109, 54, 110, 97, 47, 110, 117, 69, 75, 106, 86, 53, 121, 88, 88, 79, 83, 113, 97, 114, 117, 56, 114, 70, 54, 117, 90, 53, 109, 71, 118, 105, 54, 86, 114, 108, 55, 53, 101, 116, 80, 99, 102, 71, 80, 67, 117, 116, 122, 75, 50, 56, 106, 75, 118, 79, 122, 77, 120, 56, 76, 117, 116, 102, 98, 83, 82, 86, 55, 87, 75, 106, 102, 117, 109, 117, 100, 104, 97, 51, 105, 53, 85, 111, 113, 121, 106, 97, 98, 82, 82, 53, 116, 82, 51, 113, 88, 72, 57, 88, 117, 49, 105, 80, 78, 53, 104, 88, 88, 72, 83, 114, 97, 118, 48, 102, 54, 114, 47, 114, 48, 98, 117, 51, 116, 88, 104, 107, 97, 57, 70, 57, 84, 118, 47, 54, 67, 120, 50, 71, 67, 54, 52, 61, 58, 67, 70, 66, 50, 13, 10, 94, 70, 84, 52, 50, 51, 44, 49, 56, 53, 94, 65, 48, 78, 44, 56, 50, 44, 56, 49, 94, 70, 72, 92, 94, 67, 73, 50, 56, 94, 70, 68, 73, 108, 108, 105, 110, 111, 105, 115, 32, 72, 117, 110, 116, 105, 110, 103, 32, 76, 105, 99, 101, 110, 115, 101, 94, 70, 83, 94, 67, 73, 50, 55, 13, 10, 94, 70, 84, 52, 51, 51, 44, 51, 55, 55, 94, 65, 48, 78, 44, 49, 54, 55, 44, 49, 54, 55, 94, 70, 72, 92, 94, 67, 73, 50, 56, 94, 70, 68, 50, 48, 50, 52, 94, 70, 83, 94, 67, 73, 50, 55, 13, 10, 94, 70, 84, 49, 49, 53, 44, 53, 57, 48, 94, 65, 48, 78, 44, 53, 56, 44, 53, 56, 94, 70, 72, 92, 94, 67, 73, 50, 56, 94, 70, 68, 94, 86, 78, 97, 109, 101, 36, 94, 70, 83, 94, 67, 73, 50, 55, 13, 10, 94, 70, 84, 49, 49, 53, 44, 55, 48, 52, 94, 65, 48, 78, 44, 53, 56, 44, 53, 56, 94, 70, 72, 92, 94, 67, 73, 50, 56, 94, 70, 68, 94, 86, 65, 100, 100, 114, 101, 115, 115, 36, 94, 70, 83, 94, 67, 73, 50, 55, 13, 10, 94, 70, 84, 49, 49, 53, 44, 56, 49, 56, 94, 65, 48, 78, 44, 53, 56, 44, 53, 56, 94, 70, 72, 92, 94, 67, 73, 50, 56, 94, 70, 68, 94, 86, 67, 83, 90, 36, 94, 70, 83, 94, 67, 73, 50, 55, 94, 80, 81, 49, 44, 48, 44, 49, 44, 89, 13, 10, 94, 88, 90, 13, 10 }, new Guid("fa7c2b5e-6e3b-4a9f-b2d1-1d3f9e8b4c7f"), null, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f5c1d8a7-8e4b-4a9e-9d3f-a7b4e2f9c6d3") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_USStateDocumentOutputs_DocumentOutputTypeId",
                table: "USStateDocumentOutputs",
                column: "DocumentOutputTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_USStateDocumentOutputs_USStateDocumentTypeId_DocumentOutputTypeId_EffectiveStart",
                table: "USStateDocumentOutputs",
                columns: new[] { "USStateDocumentTypeId", "DocumentOutputTypeId", "EffectiveStart" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_USStateDocumentTypes_DocumentTypeId",
                table: "USStateDocumentTypes",
                column: "DocumentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_USStateDocumentTypes_USStateId_DocumentTypeId",
                table: "USStateDocumentTypes",
                columns: new[] { "USStateId", "DocumentTypeId" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "USStateDocumentOutputs");

            migrationBuilder.DropTable(
                name: "DocumentOutputTypes");

            migrationBuilder.DropTable(
                name: "USStateDocumentTypes");

            migrationBuilder.DropTable(
                name: "DocumentTypes");

            migrationBuilder.DropTable(
                name: "USStates");
        }
    }
}
