using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UserLoginBE.Migrations
{
    /// <inheritdoc />
    public partial class add_wardDistrict : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "05127a6a-7203-4d3e-a554-adf54c4c70ad");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "14eff8e6-ce6a-4ee9-82d8-22091a7c21c7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "46f80a63-81c0-4f35-b349-65dca7144092");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a52dd50b-bd34-4346-81c7-fb3646ec3697");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bb35e800-8750-43ad-98d9-dee20eb6ec1b");

            migrationBuilder.CreateTable(
                name: "District",
                columns: table => new
                {
                    DistrictId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DistrictName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_District", x => x.DistrictId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Ward",
                columns: table => new
                {
                    WardId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    WardName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DistrictName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DistrictId = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ward", x => x.WardId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0ba1fc46-6370-4955-bb5a-7385ae8f8d88", null, "User", "User" },
                    { "20c41dd1-2c78-4e54-8c46-d813bb71aa77", null, "AdminWard", "AdminWard" },
                    { "a884a293-a62b-416d-ac9c-261e6f7e8d19", null, "AdminDistrict", "AdminDistrict" },
                    { "bc53a0e3-75d4-4ce6-954c-1bf8d437808f", null, "Guest", "Guest" },
                    { "e1e25e81-9b9e-4569-9ed3-a086c736271b", null, "AdminGov", "AdminGov" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "District");

            migrationBuilder.DropTable(
                name: "Ward");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ba1fc46-6370-4955-bb5a-7385ae8f8d88");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "20c41dd1-2c78-4e54-8c46-d813bb71aa77");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a884a293-a62b-416d-ac9c-261e6f7e8d19");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bc53a0e3-75d4-4ce6-954c-1bf8d437808f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e1e25e81-9b9e-4569-9ed3-a086c736271b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "05127a6a-7203-4d3e-a554-adf54c4c70ad", null, "AdminWard", "AdminWard" },
                    { "14eff8e6-ce6a-4ee9-82d8-22091a7c21c7", null, "AdminDistrict", "AdminDistrict" },
                    { "46f80a63-81c0-4f35-b349-65dca7144092", null, "User", "User" },
                    { "a52dd50b-bd34-4346-81c7-fb3646ec3697", null, "AdminGov", "AdminGov" },
                    { "bb35e800-8750-43ad-98d9-dee20eb6ec1b", null, "Guest", "Guest" }
                });
        }
    }
}
