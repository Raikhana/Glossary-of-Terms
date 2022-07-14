using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP.NET_Core_MVC.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Terms",
                columns: table => new
                {
                    TermId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TermName = table.Column<string>(nullable: false),
                    Page = table.Column<int>(nullable: false),
                    Stage = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Terms", x => x.TermId);
                });

            migrationBuilder.InsertData(
                table: "Terms",
                columns: new[] { "TermId", "Page", "Stage", "TermName" },
                values: new object[] { 4, 33, 1, "web app" });

            migrationBuilder.InsertData(
                table: "Terms",
                columns: new[] { "TermId", "Page", "Stage", "TermName" },
                values: new object[] { 3, 33, 1, "local area network (LAN)" });

            migrationBuilder.InsertData(
                table: "Terms",
                columns: new[] { "TermId", "Page", "Stage", "TermName" },
                values: new object[] { 2, 33, 1, "URL (Uniform Resource Locator)" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Terms");
        }
    }
}
