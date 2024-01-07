using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UserLoginBE.Migrations
{
    /// <inheritdoc />
    public partial class changeType_districtID : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AlterColumn<int>(
                name: "DistrictId",
                table: "Ward",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "034ef469-0897-4c60-9316-0b4fdd863367", null, "AdminDistrict", "AdminDistrict" },
                    { "25001b5d-6c1d-42f7-a3ad-a84ffe7fd163", null, "AdminWard", "AdminWard" },
                    { "39fd49c0-89e6-45b7-af6f-65ab82f9650f", null, "Guest", "Guest" },
                    { "734f87cd-5b1c-43f2-8684-271629fdaabe", null, "User", "User" },
                    { "c66ab6ff-d7ba-43fe-a27e-e24ab7f4db63", null, "AdminGov", "AdminGov" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "034ef469-0897-4c60-9316-0b4fdd863367");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "25001b5d-6c1d-42f7-a3ad-a84ffe7fd163");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "39fd49c0-89e6-45b7-af6f-65ab82f9650f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "734f87cd-5b1c-43f2-8684-271629fdaabe");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c66ab6ff-d7ba-43fe-a27e-e24ab7f4db63");

            migrationBuilder.AlterColumn<string>(
                name: "DistrictId",
                table: "Ward",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
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
    }
}
