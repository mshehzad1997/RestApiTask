using Microsoft.EntityFrameworkCore.Migrations;

namespace RestApiTask.Migrations
{
    public partial class RolesPermissionAndRelationAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DemoRequests",
                table: "manageRoles");

            migrationBuilder.DropColumn(
                name: "ManageTenants",
                table: "manageRoles");

            migrationBuilder.DropColumn(
                name: "Payments",
                table: "manageRoles");

            migrationBuilder.CreateTable(
                name: "demoRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ViewRequest = table.Column<bool>(type: "bit", nullable: false),
                    ApproveRequest = table.Column<bool>(type: "bit", nullable: false),
                    ManageRolesId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_demoRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_demoRequests_manageRoles_ManageRolesId",
                        column: x => x.ManageRolesId,
                        principalTable: "manageRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "manageTenants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegisterTenant = table.Column<bool>(type: "bit", nullable: false),
                    ViewTenant = table.Column<bool>(type: "bit", nullable: false),
                    UpdateTenant = table.Column<bool>(type: "bit", nullable: false),
                    UpgradePlan = table.Column<bool>(type: "bit", nullable: false),
                    RessetPassword = table.Column<bool>(type: "bit", nullable: false),
                    ManageRolesId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_manageTenants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_manageTenants_manageRoles_ManageRolesId",
                        column: x => x.ManageRolesId,
                        principalTable: "manageRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ViewPayment = table.Column<bool>(type: "bit", nullable: false),
                    ChangeStatus = table.Column<bool>(type: "bit", nullable: false),
                    ManageRolesId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payments_manageRoles_ManageRolesId",
                        column: x => x.ManageRolesId,
                        principalTable: "manageRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_demoRequests_ManageRolesId",
                table: "demoRequests",
                column: "ManageRolesId");

            migrationBuilder.CreateIndex(
                name: "IX_manageTenants_ManageRolesId",
                table: "manageTenants",
                column: "ManageRolesId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_ManageRolesId",
                table: "Payments",
                column: "ManageRolesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "demoRequests");

            migrationBuilder.DropTable(
                name: "manageTenants");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.AddColumn<int>(
                name: "DemoRequests",
                table: "manageRoles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ManageTenants",
                table: "manageRoles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Payments",
                table: "manageRoles",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
