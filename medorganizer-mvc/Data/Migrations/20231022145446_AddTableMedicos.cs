using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MedOrganizer.Data.Migrations
{
    public partial class AddTableMedicos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Fabricante",
                table: "Medicamentos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            // migrationBuilder.AddColumn<string>(
            //     name: "Nome",
            //     table: "Medicamentos",
            //     type: "nvarchar(max)",
            //     nullable: false,
            //     defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Medicos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Crm = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Celular = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ValorConsulta = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Especialidade = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Anotacoes = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Medicos");

            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Medicamentos");

            migrationBuilder.AlterColumn<string>(
                name: "Fabricante",
                table: "Medicamentos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
