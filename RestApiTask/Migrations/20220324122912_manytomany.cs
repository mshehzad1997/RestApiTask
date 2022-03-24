using Microsoft.EntityFrameworkCore.Migrations;

namespace RestApiTask.Migrations
{
    public partial class manytomany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_manageRoles_users_ManageRoleId",
                table: "manageRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_userRoles_manageRoles_UserId",
                table: "userRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_userRoles_users_UserId",
                table: "userRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_userRoles",
                table: "userRoles");

            migrationBuilder.DropIndex(
                name: "IX_manageRoles_ManageRoleId",
                table: "manageRoles");

            migrationBuilder.DropColumn(
                name: "UserRoleId",
                table: "userRoles");

            migrationBuilder.DropColumn(
                name: "ManageRoleId",
                table: "manageRoles");

            migrationBuilder.RenameTable(
                name: "userRoles",
                newName: "UserRoles");

            migrationBuilder.RenameIndex(
                name: "IX_userRoles_UserId",
                table: "UserRoles",
                newName: "IX_UserRoles_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserRoles",
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" });

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_manageRoles_RoleId",
                table: "UserRoles",
                column: "RoleId",
                principalTable: "manageRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_users_UserId",
                table: "UserRoles",
                column: "UserId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_manageRoles_RoleId",
                table: "UserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_users_UserId",
                table: "UserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserRoles",
                table: "UserRoles");

            migrationBuilder.RenameTable(
                name: "UserRoles",
                newName: "userRoles");

            migrationBuilder.RenameIndex(
                name: "IX_UserRoles_UserId",
                table: "userRoles",
                newName: "IX_userRoles_UserId");

            migrationBuilder.AddColumn<int>(
                name: "UserRoleId",
                table: "userRoles",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ManageRoleId",
                table: "manageRoles",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_userRoles",
                table: "userRoles",
                column: "UserRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_manageRoles_ManageRoleId",
                table: "manageRoles",
                column: "ManageRoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_manageRoles_users_ManageRoleId",
                table: "manageRoles",
                column: "ManageRoleId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_userRoles_manageRoles_UserId",
                table: "userRoles",
                column: "UserId",
                principalTable: "manageRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_userRoles_users_UserId",
                table: "userRoles",
                column: "UserId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
