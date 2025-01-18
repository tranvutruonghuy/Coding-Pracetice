using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab2_TranVuTruongHuy_CSE422.Migrations
{
    /// <inheritdoc />
    public partial class newVersion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DeviceModel",
                table: "DeviceModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CategoryModel",
                table: "CategoryModel");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "DeviceModel",
                newName: "Devices");

            migrationBuilder.RenameTable(
                name: "CategoryModel",
                newName: "Categories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Devices",
                table: "Devices",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Devices",
                table: "Devices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "User");

            migrationBuilder.RenameTable(
                name: "Devices",
                newName: "DeviceModel");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "CategoryModel");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DeviceModel",
                table: "DeviceModel",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CategoryModel",
                table: "CategoryModel",
                column: "Id");
        }
    }
}
