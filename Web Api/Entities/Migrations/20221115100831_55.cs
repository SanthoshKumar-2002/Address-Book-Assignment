using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi2.Migrations
{
    public partial class _55 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Files",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Size = table.Column<long>(type: "bigint", nullable: true),
                    FormFile = table.Column<byte[]>(type: "varbinary(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Files", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "metadatas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    key = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_metadatas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "refSets",
                columns: table => new
                {
                    RefSetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_refSets", x => x.RefSetId);
                });

            migrationBuilder.CreateTable(
                name: "Setrefs",
                columns: table => new
                {
                    RefId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RefSetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RefType = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Setrefs", x => x.RefId);
                });

            migrationBuilder.CreateTable(
                name: "Types",
                columns: table => new
                {
                    RefType = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Key = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Types", x => x.RefType);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    AddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Line1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Line2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZipCode = table.Column<int>(type: "int", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    country = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.AddressId);
                    table.ForeignKey(
                        name: "FK_Addresses_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "emails",
                columns: table => new
                {
                    EmailId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_emails", x => x.EmailId);
                    table.ForeignKey(
                        name: "FK_emails_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "phoneNumbers",
                columns: table => new
                {
                    phoneId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    phoneNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_phoneNumbers", x => x.phoneId);
                    table.ForeignKey(
                        name: "FK_phoneNumbers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "FirstName", "IsActive", "LastName", "Password", "UpdateBy", "UpdatedOn", "UserName" },
                values: new object[] { new Guid("1398ff0d-2062-4594-33d4-08dac5f97924"), null, null, "Kavin", true, "Raja", "Kavin@123", null, null, "Kavin" });

            migrationBuilder.InsertData(
                table: "metadatas",
                columns: new[] { "Id", "description", "key" },
                values: new object[,]
                {
                    { 1, "display the address type", "ADDRESS TYPE" },
                    { 2, "display the phonenumber type", "PHONE NUMBER TYPE" },
                    { 3, "display the email type", "EMAIL ADDRESS TYPE" },
                    { 4, "display the country of the user", "Country" },
                    { 5, "display users from India", "India" },
                    { 6, "display users in united states", "UNITED STATES" }
                });

            migrationBuilder.InsertData(
                table: "refSets",
                columns: new[] { "RefSetId", "CreatedBy", "CreatedOn", "Description", "IsActive", "Name", "UpdateBy", "UpdatedOn" },
                values: new object[,]
                {
                    { new Guid("1298ff0d-2062-4594-23d4-08dac5f97924"), null, null, "for the country USA", null, "USA", null, null },
                    { new Guid("1398ff0d-2062-4594-23d4-08dac5f97914"), null, null, "for the country India", null, "INDIA", null, null },
                    { new Guid("1398ff0d-2062-4594-23d4-08dac5f97921"), null, null, "for the country UK", null, "UK", null, null },
                    { new Guid("1398ff0d-2062-4594-23d4-08dac5f97922"), null, null, "for the alternate", null, "ALTERNATE", null, null },
                    { new Guid("1398ff0d-2062-4594-23d4-08dac5f97923"), null, null, "for the work", null, "WORK", null, null },
                    { new Guid("1398ff0d-2062-4594-23d4-08dac5f97924"), null, null, "for the personal", null, "PERSONAL", null, null },
                    { new Guid("1398ff0d-2062-5594-23d4-08dac5f97924"), null, null, "for the country Japan", null, "JAPAN", null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_UserId",
                table: "Addresses",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_emails_UserId",
                table: "emails",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_phoneNumbers_UserId",
                table: "phoneNumbers",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "emails");

            migrationBuilder.DropTable(
                name: "Files");

            migrationBuilder.DropTable(
                name: "metadatas");

            migrationBuilder.DropTable(
                name: "phoneNumbers");

            migrationBuilder.DropTable(
                name: "refSets");

            migrationBuilder.DropTable(
                name: "Setrefs");

            migrationBuilder.DropTable(
                name: "Types");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
