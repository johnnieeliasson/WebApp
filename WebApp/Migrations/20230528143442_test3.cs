using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp.Migrations
{
    /// <inheritdoc />
    public partial class test3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "519fdfeb-7151-40ef-b1a3-368b66346c92",
                column: "ConcurrencyStamp",
                value: "c63c90f4-035a-4c77-8232-3bb6706e2a73");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d0f3cef6-1ade-4c26-8ae2-3384ec2f4dd1",
                column: "ConcurrencyStamp",
                value: "63b7be96-fd58-47af-9d16-4db91b04d7f9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bd91b606-3b0a-4a45-9d8c-fb9a2245a082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "494ce806-7c40-402f-a143-b3b9813b6db3", "AQAAAAIAAYagAAAAEPuadguB1LIsDlzh8b84fEaAGe/d2NLh8sdvOqn+dYp86Y+5/iddDjIfFsZCi6BK6A==", "562b89b6-606b-4cb7-bf8d-d6f22654a9a0" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
