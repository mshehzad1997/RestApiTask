using Microsoft.EntityFrameworkCore.Migrations;

namespace RestApiTask.Migrations
{
    public partial class UserAndRolesMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_demoRequests_manageRoles_ManageRolesId",
                table: "demoRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_manageTenants_manageRoles_ManageRolesId",
                table: "manageTenants");

            migrationBuilder.DropForeignKey(
                name: "FK_manageUsers_userManagements_UserManagementsId",
                table: "manageUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_manageRoles_ManageRolesId",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_rolesManages_userManagements_UserManagementsId",
                table: "rolesManages");

            migrationBuilder.DropForeignKey(
                name: "FK_userManagements_manageRoles_ManageRolesId",
                table: "userManagements");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_demoRequests_manageRoles_ManageRolesId",
                table: "demoRequests",
                column: "ManageRolesId",
                principalTable: "manageRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_manageTenants_manageRoles_ManageRolesId",
                table: "manageTenants",
                column: "ManageRolesId",
                principalTable: "manageRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_manageUsers_userManagements_UserManagementsId",
                table: "manageUsers",
                column: "UserManagementsId",
                principalTable: "userManagements",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_manageRoles_ManageRolesId",
                table: "Payments",
                column: "ManageRolesId",
                principalTable: "manageRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_rolesManages_userManagements_UserManagementsId",
                table: "rolesManages",
                column: "UserManagementsId",
                principalTable: "userManagements",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_userManagements_manageRoles_ManageRolesId",
                table: "userManagements",
                column: "ManageRolesId",
                principalTable: "manageRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_demoRequests_manageRoles_ManageRolesId",
                table: "demoRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_manageTenants_manageRoles_ManageRolesId",
                table: "manageTenants");

            migrationBuilder.DropForeignKey(
                name: "FK_manageUsers_userManagements_UserManagementsId",
                table: "manageUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_manageRoles_ManageRolesId",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_rolesManages_userManagements_UserManagementsId",
                table: "rolesManages");

            migrationBuilder.DropForeignKey(
                name: "FK_userManagements_manageRoles_ManageRolesId",
                table: "userManagements");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddForeignKey(
                name: "FK_demoRequests_manageRoles_ManageRolesId",
                table: "demoRequests",
                column: "ManageRolesId",
                principalTable: "manageRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_manageTenants_manageRoles_ManageRolesId",
                table: "manageTenants",
                column: "ManageRolesId",
                principalTable: "manageRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_manageUsers_userManagements_UserManagementsId",
                table: "manageUsers",
                column: "UserManagementsId",
                principalTable: "userManagements",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_manageRoles_ManageRolesId",
                table: "Payments",
                column: "ManageRolesId",
                principalTable: "manageRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_rolesManages_userManagements_UserManagementsId",
                table: "rolesManages",
                column: "UserManagementsId",
                principalTable: "userManagements",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_userManagements_manageRoles_ManageRolesId",
                table: "userManagements",
                column: "ManageRolesId",
                principalTable: "manageRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
