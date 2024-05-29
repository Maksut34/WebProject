using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web_DAL.Migrations
{
    public partial class martianas1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "NoMorehealth",
                table: "players",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NoMorehealth",
                table: "players");
        }
    }
}
