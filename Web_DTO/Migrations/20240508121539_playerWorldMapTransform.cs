using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web_DAL.Migrations
{
    public partial class playerWorldMapTransform : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "playersvalueId",
                table: "AspNetUsers");

            migrationBuilder.CreateTable(
                name: "playerWorldMapTransforms",
                columns: table => new
                {
                    worlMaptransformID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    worlMaptransformIsHome = table.Column<bool>(type: "bit", nullable: false),
                    worlMaptransformIsLittleForest = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_playerWorldMapTransforms", x => x.worlMaptransformID);
                    table.ForeignKey(
                        name: "FK_playerWorldMapTransforms_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_playerWorldMapTransforms_UserId",
                table: "playerWorldMapTransforms",
                column: "UserId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "playerWorldMapTransforms");

            migrationBuilder.AddColumn<int>(
                name: "playersvalueId",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
