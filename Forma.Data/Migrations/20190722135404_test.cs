using Microsoft.EntityFrameworkCore.Migrations;

namespace Forma.Data.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PID",
                table: "Prijave",
                newName: "ID");

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Prijave",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Prijave",
                nullable: true,
                oldClrType: typeof(string));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Prijave",
                newName: "PID");

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Prijave",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Prijave",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
