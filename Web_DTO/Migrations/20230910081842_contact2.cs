using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web_DAL.Migrations
{
    public partial class contact2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_AspNetUsers_UsersId",
                table: "Contacts");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_UsersId",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "UsersId",
                table: "Contacts");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_UserID",
                table: "Contacts",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_AspNetUsers_UserID",
                table: "Contacts",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_AspNetUsers_UserID",
                table: "Contacts");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_UserID",
                table: "Contacts");

            migrationBuilder.AddColumn<int>(
                name: "UsersId",
                table: "Contacts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_UsersId",
                table: "Contacts",
                column: "UsersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_AspNetUsers_UsersId",
                table: "Contacts",
                column: "UsersId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
