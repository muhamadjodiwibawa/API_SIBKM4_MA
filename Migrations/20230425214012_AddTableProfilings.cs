using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class AddTableProfilings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "phone_number",
                table: "Tb_m_employees",
                type: "varchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(50)");

            migrationBuilder.AlterColumn<string>(
                name: "last_name",
                table: "Tb_m_employees",
                type: "varchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(50)");

            migrationBuilder.AlterColumn<string>(
                name: "first_name",
                table: "Tb_m_employees",
                type: "varchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(50)");

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "Tb_m_employees",
                type: "varchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(50)");

            migrationBuilder.CreateTable(
                name: "tb_tr_profilings",
                columns: table => new
                {
                    employee_nik = table.Column<string>(type: "char(5)", nullable: false),
                    education_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_tr_profilings", x => x.employee_nik);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_tr_profilings");

            migrationBuilder.AlterColumn<string>(
                name: "phone_number",
                table: "Tb_m_employees",
                type: "char(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)");

            migrationBuilder.AlterColumn<string>(
                name: "last_name",
                table: "Tb_m_employees",
                type: "char(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)");

            migrationBuilder.AlterColumn<string>(
                name: "first_name",
                table: "Tb_m_employees",
                type: "char(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)");

            migrationBuilder.AlterColumn<string>(
                name: "email",
                table: "Tb_m_employees",
                type: "char(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)");
        }
    }
}
