using Microsoft.EntityFrameworkCore.Migrations;

namespace RestApiTask.Migrations
{
    public partial class newRelationAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RoleName",
                table: "manageRoles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "userManagements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ManageRolesId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userManagements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_userManagements_manageRoles_ManageRolesId",
                        column: x => x.ManageRolesId,
                        principalTable: "manageRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "manageUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateUser = table.Column<bool>(type: "bit", nullable: false),
                    UpdateUser = table.Column<bool>(type: "bit", nullable: false),
                    Inactive = table.Column<bool>(type: "bit", nullable: false),
                    Reset = table.Column<bool>(type: "bit", nullable: false),
                    UserManagementsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_manageUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_manageUsers_userManagements_UserManagementsId",
                        column: x => x.UserManagementsId,
                        principalTable: "userManagements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "rolesManages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateUser = table.Column<bool>(type: "bit", nullable: false),
                    ViewRole = table.Column<bool>(type: "bit", nullable: false),
                    UpdateRole = table.Column<bool>(type: "bit", nullable: false),
                    UserManagementsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rolesManages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_rolesManages_userManagements_UserManagementsId",
                        column: x => x.UserManagementsId,
                        principalTable: "userManagements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_manageUsers_UserManagementsId",
                table: "manageUsers",
                column: "UserManagementsId");

            migrationBuilder.CreateIndex(
                name: "IX_rolesManages_UserManagementsId",
                table: "rolesManages",
                column: "UserManagementsId");

            migrationBuilder.CreateIndex(
                name: "IX_userManagements_ManageRolesId",
                table: "userManagements",
                column: "ManageRolesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "manageUsers");

            migrationBuilder.DropTable(
                name: "rolesManages");

            migrationBuilder.DropTable(
                name: "userManagements");

            migrationBuilder.AlterColumn<string>(
                name: "RoleName",
                table: "manageRoles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
