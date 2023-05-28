using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp.Migrations
{
    /// <inheritdoc />
    public partial class ContactForms : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContactForms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactForms", x => x.Id);
                });

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "371af6ca-449f-476a-ae56-22823bcdd95a", "AQAAAAIAAYagAAAAECecGS20xwRbxNSNlkHecDwxLQIMCDimF+vE3dpgvV4DNC09Lj6zXTJjuwTH7hQ2hA==", "356fdcf3-0c57-43da-86b7-68be01b4038d" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactForms");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "519fdfeb-7151-40ef-b1a3-368b66346c92",
                column: "ConcurrencyStamp",
                value: "ecfc577d-0a58-4bfe-9934-48ca60ae7343");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d0f3cef6-1ade-4c26-8ae2-3384ec2f4dd1",
                column: "ConcurrencyStamp",
                value: "ad9e35a2-52a7-4cb7-8977-a6b35c2bb835");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bd91b606-3b0a-4a45-9d8c-fb9a2245a082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9f71265d-55ff-4866-b0fe-4e0f088cfd04", "AQAAAAIAAYagAAAAEIObuuX6YLcJH4v2hCYpGljaH+s9NhY4q/rbuMb152x++ZXTfiydkyiObUsAMQdUvw==", "07304b38-ff09-441d-b8b9-d7437fbf76f7" });
        }
    }
}
