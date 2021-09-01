using Microsoft.EntityFrameworkCore.Migrations;

namespace influencer.Migrations
{
    public partial class UserCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserCategory",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserCategory",
                table: "AspNetUsers");
        }
    }
}
