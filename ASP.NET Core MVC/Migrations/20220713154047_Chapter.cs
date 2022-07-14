using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP.NET_Core_MVC.Migrations
{
    public partial class Chapter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ChapterId",
                table: "Terms",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Chapters",
                columns: table => new
                {
                    ChapterId = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chapters", x => x.ChapterId);
                });

            migrationBuilder.InsertData(
                table: "Chapters",
                columns: new[] { "ChapterId", "Name" },
                values: new object[,]
                {
                    { "I", "Introduction" },
                    { "s", "single" },
                    { "B", "Bootstrap" },
                    { "d", "data-driven" },
                    { "t", "testing" },
                    { "c", "controllers" },
                    { "R", "Razor" }
                });

            migrationBuilder.UpdateData(
                table: "Terms",
                keyColumn: "TermId",
                keyValue: 2,
                column: "ChapterId",
                value: "t");

            migrationBuilder.UpdateData(
                table: "Terms",
                keyColumn: "TermId",
                keyValue: 3,
                column: "ChapterId",
                value: "c");

            migrationBuilder.UpdateData(
                table: "Terms",
                keyColumn: "TermId",
                keyValue: 4,
                column: "ChapterId",
                value: "R");

            migrationBuilder.CreateIndex(
                name: "IX_Terms_ChapterId",
                table: "Terms",
                column: "ChapterId");

            migrationBuilder.AddForeignKey(
                name: "FK_Terms_Chapters_ChapterId",
                table: "Terms",
                column: "ChapterId",
                principalTable: "Chapters",
                principalColumn: "ChapterId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Terms_Chapters_ChapterId",
                table: "Terms");

            migrationBuilder.DropTable(
                name: "Chapters");

            migrationBuilder.DropIndex(
                name: "IX_Terms_ChapterId",
                table: "Terms");

            migrationBuilder.DropColumn(
                name: "ChapterId",
                table: "Terms");
        }
    }
}
