using Microsoft.EntityFrameworkCore.Migrations;

namespace RestApiTask.Migrations
{
    public partial class ForignKeyUserAndRole : Migration
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
                name: "FK_Payments_manageRoles_ManageRolesId",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_userManagements_manageRoles_ManageRolesId",
                table: "userManagements");

            migrationBuilder.DropIndex(
                name: "IX_userManagements_ManageRolesId",
                table: "userManagements");

            migrationBuilder.DropIndex(
                name: "IX_Payments_ManageRolesId",
                table: "Payments");

            migrationBuilder.DropIndex(
                name: "IX_manageTenants_ManageRolesId",
                table: "manageTenants");

            migrationBuilder.DropIndex(
                name: "IX_demoRequests_ManageRolesId",
                table: "demoRequests");

            migrationBuilder.DropColumn(
                name: "ManageRolesId",
                table: "userManagements");

            migrationBuilder.DropColumn(
                name: "ManageRolesId",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "ManageRolesId",
                table: "manageTenants");

            migrationBuilder.DropColumn(
                name: "ManageRolesId",
                table: "demoRequests");

            migrationBuilder.AddColumn<int>(
                name: "ManageRoleId",
                table: "userManagements",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "UserManagementsId",
                table: "rolesManages",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ManageRoleId",
                table: "Payments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "UserManagementsId",
                table: "manageUsers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ManageRoleId",
                table: "manageTenants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ManageRoleId",
                table: "demoRequests",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_userManagements_ManageRoleId",
                table: "userManagements",
                column: "ManageRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_ManageRoleId",
                table: "Payments",
                column: "ManageRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_manageTenants_ManageRoleId",
                table: "manageTenants",
                column: "ManageRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_demoRequests_ManageRoleId",
                table: "demoRequests",
                column: "ManageRoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_demoRequests_manageRoles_ManageRoleId",
                table: "demoRequests",
                column: "ManageRoleId",
                principalTable: "manageRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_manageTenants_manageRoles_ManageRoleId",
                table: "manageTenants",
                column: "ManageRoleId",
                principalTable: "manageRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_manageRoles_ManageRoleId",
                table: "Payments",
                column: "ManageRoleId",
                principalTable: "manageRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_userManagements_manageRoles_ManageRoleId",
                table: "userManagements",
                column: "ManageRoleId",
                principalTable: "manageRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_demoRequests_manageRoles_ManageRoleId",
                table: "demoRequests");

            migrationBuilder.DropForeignKey(
                name: "FK_manageTenants_manageRoles_ManageRoleId",
                table: "manageTenants");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_manageRoles_ManageRoleId",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_userManagements_manageRoles_ManageRoleId",
                table: "userManagements");

            migrationBuilder.DropIndex(
                name: "IX_userManagements_ManageRoleId",
                table: "userManagements");

            migrationBuilder.DropIndex(
                name: "IX_Payments_ManageRoleId",
                table: "Payments");

            migrationBuilder.DropIndex(
                name: "IX_manageTenants_ManageRoleId",
                table: "manageTenants");

            migrationBuilder.DropIndex(
                name: "IX_demoRequests_ManageRoleId",
                table: "demoRequests");

            migrationBuilder.DropColumn(
                name: "ManageRoleId",
                table: "userManagements");

            migrationBuilder.DropColumn(
                name: "ManageRoleId",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "ManageRoleId",
                table: "manageTenants");

            migrationBuilder.DropColumn(
                name: "ManageRoleId",
                table: "demoRequests");

            migrationBuilder.AddColumn<int>(
                name: "ManageRolesId",
                table: "userManagements",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserManagementsId",
                table: "rolesManages",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "ManageRolesId",
                table: "Payments",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserManagementsId",
                table: "manageUsers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "ManageRolesId",
                table: "manageTenants",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ManageRolesId",
                table: "demoRequests",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_userManagements_ManageRolesId",
                table: "userManagements",
                column: "ManageRolesId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_ManageRolesId",
                table: "Payments",
                column: "ManageRolesId");

            migrationBuilder.CreateIndex(
                name: "IX_manageTenants_ManageRolesId",
                table: "manageTenants",
                column: "ManageRolesId");

            migrationBuilder.CreateIndex(
                name: "IX_demoRequests_ManageRolesId",
                table: "demoRequests",
                column: "ManageRolesId");

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
                name: "FK_Payments_manageRoles_ManageRolesId",
                table: "Payments",
                column: "ManageRolesId",
                principalTable: "manageRoles",
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
    }
}
