using Microsoft.EntityFrameworkCore.Migrations;

namespace Web_Api.Migrations
{
    public partial class eliminarcolumnas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cantidad",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "Fecha_Empleado_Producto",
                table: "Empleados_Productos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Cantidad",
                table: "Productos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Fecha_Empleado_Producto",
                table: "Empleados_Productos",
                nullable: true);
        }
    }
}
