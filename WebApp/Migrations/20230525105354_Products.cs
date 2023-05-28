using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable


namespace WebApp.Migrations
{
    /// <inheritdoc />
    public partial class Products : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TagName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductTags",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    TagId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTags", x => new { x.ProductId, x.TagId });
                    table.ForeignKey(
                        name: "FK_ProductTags_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductTags_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "iPhone 13 mini. Det mest avancerade dubbelkamerasystemet någonsin på en iPhone. Blixtsnabbt A15 Bionic-chip. Ett språng för batteritiden. Tålig design. Supersnabbt 5G1. Och en ljusare Super Retina XDR-skärm.", "https://www.netonnet.se/art/mobil-smartwatch/mobiltelefoner/iphone/apple-iphone-13-mini-128gb-midnight/1020710.9044/#", 8290m, "Apple iPhone 13 mini 128GB Midnight" });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "TagName" },
                values: new object[,]
                {
                    { 1, "new" },
                    { 2, "featured" },
                    { 3, "popular" }
                });

            migrationBuilder.InsertData(
                table: "ProductTags",
                columns: new[] { "ProductId", "TagId" },
                values: new object[] { 1, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_ProductTags_TagId",
                table: "ProductTags",
                column: "TagId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductTags");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "519fdfeb-7151-40ef-b1a3-368b66346c92",
                column: "ConcurrencyStamp",
                value: "7edeae7d-3ffd-4bf6-89fa-e78b25a88568");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d0f3cef6-1ade-4c26-8ae2-3384ec2f4dd1",
                column: "ConcurrencyStamp",
                value: "375318d8-9168-4b49-80bd-2f2ae2d96cbd");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bd91b606-3b0a-4a45-9d8c-fb9a2245a082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "583e46e2-2b3d-4d60-b240-a99cc8da216e", "AQAAAAIAAYagAAAAEM7CZdk4ylSCDvMocIKpcQzsuFarX1lQuRCDRPtoUYcgsfE3yOVdsiBFFBnGDDZugg==", "183bb7a3-3919-4c33-9ae7-5258079c1921" });
        }
    }
}
