using Microsoft.EntityFrameworkCore.Migrations;

namespace RestApiTask.Migrations
{
    public partial class manytomanys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ManageRoleId",
                table: "users");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ManageRoleId",
                table: "users",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
