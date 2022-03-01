using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SocialMVCIdentityFinal.Migrations
{
    public partial class ThirdOne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "userAddress",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "userJob",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "userSex",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "userAddress",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "userJob",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "userSex",
                table: "AspNetUsers");
        }
    }
}
