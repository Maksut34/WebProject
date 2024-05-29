using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web_DAL.Migrations
{
    public partial class martiana2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "martianas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MartianaMaxHealth = table.Column<float>(type: "real", nullable: false),
                    MartianaHealth = table.Column<float>(type: "real", nullable: false),
                    NoMorehealth = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_martianas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_martianas_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_martianas_UserId",
                table: "martianas",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "martianas");
        }
    }
}
