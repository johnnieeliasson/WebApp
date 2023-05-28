using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp.Migrations
{
    /// <inheritdoc />
    public partial class test2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "519fdfeb-7151-40ef-b1a3-368b66346c92",
                column: "ConcurrencyStamp",
                value: "14df7727-6d2d-45d3-8675-0adc7496835c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d0f3cef6-1ade-4c26-8ae2-3384ec2f4dd1",
                column: "ConcurrencyStamp",
                value: "b50f9162-8ee5-4551-9af0-09d73c41c123");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bd91b606-3b0a-4a45-9d8c-fb9a2245a082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8a18195e-f734-466b-8ce0-92101a41084d", "AQAAAAIAAYagAAAAEG05xC/teAI08wIGtB1p3OuP0kZNvoksT9B/XMssZvZY+6waHCR0Wc04SsHzqRXUmQ==", "2c21d398-293a-4de9-9b6d-e3746fc8b5f0" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "519fdfeb-7151-40ef-b1a3-368b66346c92",
                column: "ConcurrencyStamp",
                value: "cb8f4f0d-e251-4d49-a6bc-b8ac35c4b25d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d0f3cef6-1ade-4c26-8ae2-3384ec2f4dd1",
                column: "ConcurrencyStamp",
                value: "26519069-47b6-456f-b9f3-37d1d83df825");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bd91b606-3b0a-4a45-9d8c-fb9a2245a082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e586a729-0bbb-40c0-8711-76f20f41240f", "AQAAAAIAAYagAAAAEPTLVzjIcWMK6XL38W7vChLbF6IGAwfzkh8BacWoDaUgGLPB7pxCDlc4wwE0zWJE4g==", "10388952-26b1-4449-99e5-5b7e80897d9a" });
        }
    }
}
