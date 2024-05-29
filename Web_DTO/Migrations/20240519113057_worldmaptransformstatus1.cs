using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web_DAL.Migrations
{
    public partial class worldmaptransformstatus1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "worlMapClıckHome",
                table: "playerWorldMapTransforms",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "worlMapClıckLittleForest",
                table: "playerWorldMapTransforms",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "worlMapClıckTown",
                table: "playerWorldMapTransforms",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "worlMaptransformIsTown",
                table: "playerWorldMapTransforms",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "worlMapClıckHome",
                table: "playerWorldMapTransforms");

            migrationBuilder.DropColumn(
                name: "worlMapClıckLittleForest",
                table: "playerWorldMapTransforms");

            migrationBuilder.DropColumn(
                name: "worlMapClıckTown",
                table: "playerWorldMapTransforms");

            migrationBuilder.DropColumn(
                name: "worlMaptransformIsTown",
                table: "playerWorldMapTransforms");
        }
    }
}
