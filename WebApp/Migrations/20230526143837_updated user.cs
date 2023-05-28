using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp.Migrations
{
    /// <inheritdoc />
    public partial class updateduser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e586a729-0bbb-40c0-8711-76f20f41240f", "ADMIN@DOMAIN.COM", "ADMIN@DOMAIN.COM", "AQAAAAIAAYagAAAAEPTLVzjIcWMK6XL38W7vChLbF6IGAwfzkh8BacWoDaUgGLPB7pxCDlc4wwE0zWJE4g==", "10388952-26b1-4449-99e5-5b7e80897d9a" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "519fdfeb-7151-40ef-b1a3-368b66346c92",
                column: "ConcurrencyStamp",
                value: "1d943c14-81a2-46fe-889e-462d7b864e3a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d0f3cef6-1ade-4c26-8ae2-3384ec2f4dd1",
                column: "ConcurrencyStamp",
                value: "1b462bc2-c12f-4d39-b61a-783e06867030");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bd91b606-3b0a-4a45-9d8c-fb9a2245a082",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "371af6ca-449f-476a-ae56-22823bcdd95a", "ADMIN@DOMIN:COM", "ADMIN@DOMIN:COM", "AQAAAAIAAYagAAAAECecGS20xwRbxNSNlkHecDwxLQIMCDimF+vE3dpgvV4DNC09Lj6zXTJjuwTH7hQ2hA==", "356fdcf3-0c57-43da-86b7-68be01b4038d" });
        }
    }
}
