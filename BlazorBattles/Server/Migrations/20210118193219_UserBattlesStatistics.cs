using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorBattles.Server.Migrations
{
    public partial class UserBattlesStatistics : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Battles",
                table: "Users",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Defeats",
                table: "Users",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Victories",
                table: "Users",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_UserUnits_UserId",
                table: "UserUnits",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserUnits_Users_UserId",
                table: "UserUnits",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserUnits_Users_UserId",
                table: "UserUnits");

            migrationBuilder.DropIndex(
                name: "IX_UserUnits_UserId",
                table: "UserUnits");

            migrationBuilder.DropColumn(
                name: "Battles",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Defeats",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Victories",
                table: "Users");
        }
    }
}
