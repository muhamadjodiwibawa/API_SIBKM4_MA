using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class AddTablesAndRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "education_id",
                table: "tb_tr_profilings",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "role_id",
                table: "tb_tr_Account_Roles",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "account_nik",
                table: "tb_tr_Account_Roles",
                type: "char(5)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "char(5)");

            migrationBuilder.AlterColumn<int>(
                name: "university_id",
                table: "tb_m_Educations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_tb_tr_profilings_education_id",
                table: "tb_tr_profilings",
                column: "education_id",
                unique: true,
                filter: "[education_id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_tb_tr_Account_Roles_account_nik",
                table: "tb_tr_Account_Roles",
                column: "account_nik");

            migrationBuilder.CreateIndex(
                name: "IX_tb_tr_Account_Roles_role_id",
                table: "tb_tr_Account_Roles",
                column: "role_id");

            migrationBuilder.CreateIndex(
                name: "IX_tb_m_Educations_university_id",
                table: "tb_m_Educations",
                column: "university_id");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_m_Accounts_Tb_m_employees_employee_nik",
                table: "tb_m_Accounts",
                column: "employee_nik",
                principalTable: "Tb_m_employees",
                principalColumn: "nik",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_m_Educations_tb_m_Universities_university_id",
                table: "tb_m_Educations",
                column: "university_id",
                principalTable: "tb_m_Universities",
                principalColumn: "id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_tr_Account_Roles_tb_m_Accounts_account_nik",
                table: "tb_tr_Account_Roles",
                column: "account_nik",
                principalTable: "tb_m_Accounts",
                principalColumn: "employee_nik",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_tr_Account_Roles_tb_m_Roles_role_id",
                table: "tb_tr_Account_Roles",
                column: "role_id",
                principalTable: "tb_m_Roles",
                principalColumn: "id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_tr_profilings_Tb_m_employees_employee_nik",
                table: "tb_tr_profilings",
                column: "employee_nik",
                principalTable: "Tb_m_employees",
                principalColumn: "nik",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_tr_profilings_tb_m_Educations_education_id",
                table: "tb_tr_profilings",
                column: "education_id",
                principalTable: "tb_m_Educations",
                principalColumn: "id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_m_Accounts_Tb_m_employees_employee_nik",
                table: "tb_m_Accounts");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_m_Educations_tb_m_Universities_university_id",
                table: "tb_m_Educations");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_tr_Account_Roles_tb_m_Accounts_account_nik",
                table: "tb_tr_Account_Roles");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_tr_Account_Roles_tb_m_Roles_role_id",
                table: "tb_tr_Account_Roles");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_tr_profilings_Tb_m_employees_employee_nik",
                table: "tb_tr_profilings");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_tr_profilings_tb_m_Educations_education_id",
                table: "tb_tr_profilings");

            migrationBuilder.DropIndex(
                name: "IX_tb_tr_profilings_education_id",
                table: "tb_tr_profilings");

            migrationBuilder.DropIndex(
                name: "IX_tb_tr_Account_Roles_account_nik",
                table: "tb_tr_Account_Roles");

            migrationBuilder.DropIndex(
                name: "IX_tb_tr_Account_Roles_role_id",
                table: "tb_tr_Account_Roles");

            migrationBuilder.DropIndex(
                name: "IX_tb_m_Educations_university_id",
                table: "tb_m_Educations");

            migrationBuilder.AlterColumn<int>(
                name: "education_id",
                table: "tb_tr_profilings",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "role_id",
                table: "tb_tr_Account_Roles",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "account_nik",
                table: "tb_tr_Account_Roles",
                type: "char(5)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "char(5)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "university_id",
                table: "tb_m_Educations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
