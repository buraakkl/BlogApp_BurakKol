using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogApp.Data.Migrations
{
    public partial class FirstMigrationss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoryName = table.Column<string>(type: "TEXT", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Blog",
                columns: table => new
                {
                    BlogID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BlogName = table.Column<string>(type: "TEXT", nullable: true),
                    BlogImage = table.Column<string>(type: "TEXT", nullable: true),
                    BlogTitle = table.Column<string>(type: "TEXT", nullable: true),
                    BlogContent = table.Column<string>(type: "TEXT", nullable: true),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CategoryID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blog", x => x.BlogID);
                    table.ForeignKey(
                        name: "FK_Blog_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BlogCategories",
                columns: table => new
                {
                    BlogID = table.Column<int>(type: "INTEGER", nullable: false),
                    CategoryID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogCategories", x => new { x.BlogID, x.CategoryID });
                    table.ForeignKey(
                        name: "FK_BlogCategories_Blog_BlogID",
                        column: x => x.BlogID,
                        principalTable: "Blog",
                        principalColumn: "BlogID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BlogCategories_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName", "IsDeleted" },
                values: new object[] { 1, "Music", false });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName", "IsDeleted" },
                values: new object[] { 2, "Game", false });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName", "IsDeleted" },
                values: new object[] { 3, "Books", false });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName", "IsDeleted" },
                values: new object[] { 4, "Food", false });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName", "IsDeleted" },
                values: new object[] { 5, "Sport", false });

            migrationBuilder.InsertData(
                table: "Blog",
                columns: new[] { "BlogID", "BlogContent", "BlogImage", "BlogName", "BlogTitle", "CategoryID", "DateAdded", "IsDeleted" },
                values: new object[] { 1, " lorem ipsum dolor.", "1", "Jazz instruments", "Music History", 3, new DateTime(2023, 1, 11, 1, 40, 50, 407, DateTimeKind.Local).AddTicks(981), false });

            migrationBuilder.InsertData(
                table: "Blog",
                columns: new[] { "BlogID", "BlogContent", "BlogImage", "BlogName", "BlogTitle", "CategoryID", "DateAdded", "IsDeleted" },
                values: new object[] { 2, " lorem ipsum dolor.", "2", "Fps Games", "Game History", 1, new DateTime(2023, 1, 11, 1, 40, 50, 407, DateTimeKind.Local).AddTicks(990), false });

            migrationBuilder.InsertData(
                table: "BlogCategories",
                columns: new[] { "BlogID", "CategoryID" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "BlogCategories",
                columns: new[] { "BlogID", "CategoryID" },
                values: new object[] { 2, 2 });

            migrationBuilder.CreateIndex(
                name: "IX_Blog_CategoryID",
                table: "Blog",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_BlogCategories_CategoryID",
                table: "BlogCategories",
                column: "CategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlogCategories");

            migrationBuilder.DropTable(
                name: "Blog");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
