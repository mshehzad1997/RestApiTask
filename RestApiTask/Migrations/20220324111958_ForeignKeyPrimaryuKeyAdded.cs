using Microsoft.EntityFrameworkCore.Migrations;

namespace RestApiTask.Migrations
{
    public partial class ForeignKeyPrimaryuKeyAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_users_manageRoles_ManageRoleId",
                table: "users");

            migrationBuilder.DropIndex(
                name: "IX_users_ManageRoleId",
                table: "users");

            migrationBuilder.AddColumn<int>(
                name: "ManageRoleId",
                table: "manageRoles",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "userRoles",
                columns: table => new
                {
                    UserRoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userRoles", x => x.UserRoleId);
                    table.ForeignKey(
                        name: "FK_userRoles_manageRoles_UserId",
                        column: x => x.UserId,
                        principalTable: "manageRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_userRoles_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_manageRoles_ManageRoleId",
                table: "manageRoles",
                column: "ManageRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_userRoles_UserId",
                table: "userRoles",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_manageRoles_users_ManageRoleId",
                table: "manageRoles",
                column: "ManageRoleId",
                principalTable: "users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_manageRoles_users_ManageRoleId",
                table: "manageRoles");

            migrationBuilder.DropTable(
                name: "userRoles");

            migrationBuilder.DropIndex(
                name: "IX_manageRoles_ManageRoleId",
                table: "manageRoles");

            migrationBuilder.DropColumn(
                name: "ManageRoleId",
                table: "manageRoles");

            migrationBuilder.CreateIndex(
                name: "IX_users_ManageRoleId",
                table: "users",
                column: "ManageRoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_users_manageRoles_ManageRoleId",
                table: "users",
                column: "ManageRoleId",
                principalTable: "manageRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
