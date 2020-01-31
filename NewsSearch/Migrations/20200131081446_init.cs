using Microsoft.EntityFrameworkCore.Migrations;

namespace NewsSearch.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    Id = table.Column<double>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Publication = table.Column<string>(nullable: true),
                    Author = table.Column<string>(nullable: true),
                    Date = table.Column<string>(nullable: true),
                    Year = table.Column<string>(nullable: true),
                    Month = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "News");
        }
    }
}
