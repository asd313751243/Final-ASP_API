using Microsoft.EntityFrameworkCore.Migrations;

namespace Web_Api.Migrations
{
    public partial class borrar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Contra_Empleado",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "Usuario_Empleado",
                table: "Empleados");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Contra_Empleado",
                table: "Empleados",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Usuario_Empleado",
                table: "Empleados",
                nullable: true);
        }
    }
}
