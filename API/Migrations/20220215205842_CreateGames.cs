using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class CreateGames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    mdate = table.Column<string>(type: "TEXT", nullable: true),
                    stadium = table.Column<string>(type: "TEXT", nullable: true),
                    team1 = table.Column<string>(type: "TEXT", nullable: true),
                    team2 = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Games");
        }
    }
}
