using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelListing.Migrations
{
    public partial class roles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1f21b987-aa70-4ca7-a021-e37cba45ac57");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7f553a71-36ca-461f-8afe-0c0f6c4050c4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7b32fd5c-ae7b-4fa4-83fc-d17a966cea9d", "aed89ce5-5e91-41a7-9554-749e19f0f3f5", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8271ed6e-7713-4fb8-aeee-731b02e9337b", "5878b14d-424e-40da-835b-8606c56658f9", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7b32fd5c-ae7b-4fa4-83fc-d17a966cea9d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8271ed6e-7713-4fb8-aeee-731b02e9337b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1f21b987-aa70-4ca7-a021-e37cba45ac57", "1a4bf48d-9454-4e41-affc-3d8b4cd831f5", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7f553a71-36ca-461f-8afe-0c0f6c4050c4", "5ddaa973-8758-4aab-8125-d330eec32661", "Administrator", "ADMINISTRATOR" });
        }
    }
}
