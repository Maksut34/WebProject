using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web_DAL.Migrations
{
    public partial class PlayerValues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "playersvalueId",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "players",
                columns: table => new
                {
                    valueID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    playerLevel = table.Column<int>(type: "int", nullable: false),
                    playerLevel_EXP = table.Column<int>(type: "int", nullable: false),
                    player_Health = table.Column<float>(type: "real", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_players", x => x.valueID);
                    table.ForeignKey(
                        name: "FK_players_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_players_UserId",
                table: "players",
                column: "UserId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "players");

            migrationBuilder.DropColumn(
                name: "playersvalueId",
                table: "AspNetUsers");
        }
    }
}
