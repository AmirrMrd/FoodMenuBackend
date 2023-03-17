using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodMenuTest.Migrations
{
    /// <inheritdoc />
    public partial class f : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Users",
                newName: "password");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Users",
                newName: "lastName");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Users",
                newName: "firstName");

            migrationBuilder.RenameColumn(
                name: "ConfirmPassword",
                table: "Users",
                newName: "confirmPassword");

            migrationBuilder.RenameColumn(
                name: "EmailOrPhone",
                table: "Users",
                newName: "emailOrMobile");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "password",
                table: "Users",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "lastName",
                table: "Users",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "firstName",
                table: "Users",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "confirmPassword",
                table: "Users",
                newName: "ConfirmPassword");

            migrationBuilder.RenameColumn(
                name: "emailOrMobile",
                table: "Users",
                newName: "EmailOrPhone");
        }
    }
}
