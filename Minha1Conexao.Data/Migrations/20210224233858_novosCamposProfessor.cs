using Microsoft.EntityFrameworkCore.Migrations;

namespace Minha1Conexao.Data.Migrations
{
    public partial class novosCamposProfessor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Agencia",
                table: "Professor",
                type: "varchar(10)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Banco",
                table: "Professor",
                type: "varchar(50)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Conta",
                table: "Professor",
                type: "varchar(20)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Professor",
                type: "varchar(150)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Turno",
                table: "Professor",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Agencia",
                table: "Professor");

            migrationBuilder.DropColumn(
                name: "Banco",
                table: "Professor");

            migrationBuilder.DropColumn(
                name: "Conta",
                table: "Professor");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Professor");

            migrationBuilder.DropColumn(
                name: "Turno",
                table: "Professor");
        }
    }
}
