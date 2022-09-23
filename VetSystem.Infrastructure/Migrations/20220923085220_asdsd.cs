using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VetSystem.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class asdsd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animals_Clinics_ClinicId",
                table: "Animals");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicationCategories_Clinics_ClinicId",
                table: "MedicationCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_Medications_Clinics_ClinicId",
                table: "Medications");

            migrationBuilder.DropForeignKey(
                name: "FK_Owners_Clinics_ClinicId",
                table: "Owners");

            migrationBuilder.DropTable(
                name: "Clinics");

            migrationBuilder.DropIndex(
                name: "IX_Owners_ClinicId",
                table: "Owners");

            migrationBuilder.DropIndex(
                name: "IX_Medications_ClinicId",
                table: "Medications");

            migrationBuilder.DropIndex(
                name: "IX_MedicationCategories_ClinicId",
                table: "MedicationCategories");

            migrationBuilder.DropIndex(
                name: "IX_Animals_ClinicId",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "ClinicId",
                table: "Owners");

            migrationBuilder.DropColumn(
                name: "ClinicId",
                table: "Medications");

            migrationBuilder.DropColumn(
                name: "ClinicId",
                table: "MedicationCategories");

            migrationBuilder.DropColumn(
                name: "ClinicId",
                table: "Animals");

            migrationBuilder.AlterColumn<int>(
                name: "PhoneNumber",
                table: "Owners",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PhoneNumber",
                table: "Owners",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClinicId",
                table: "Owners",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClinicId",
                table: "Medications",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClinicId",
                table: "MedicationCategories",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClinicId",
                table: "Animals",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Clinics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clinics", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Owners_ClinicId",
                table: "Owners",
                column: "ClinicId");

            migrationBuilder.CreateIndex(
                name: "IX_Medications_ClinicId",
                table: "Medications",
                column: "ClinicId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicationCategories_ClinicId",
                table: "MedicationCategories",
                column: "ClinicId");

            migrationBuilder.CreateIndex(
                name: "IX_Animals_ClinicId",
                table: "Animals",
                column: "ClinicId");

            migrationBuilder.AddForeignKey(
                name: "FK_Animals_Clinics_ClinicId",
                table: "Animals",
                column: "ClinicId",
                principalTable: "Clinics",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MedicationCategories_Clinics_ClinicId",
                table: "MedicationCategories",
                column: "ClinicId",
                principalTable: "Clinics",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Medications_Clinics_ClinicId",
                table: "Medications",
                column: "ClinicId",
                principalTable: "Clinics",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Owners_Clinics_ClinicId",
                table: "Owners",
                column: "ClinicId",
                principalTable: "Clinics",
                principalColumn: "Id");
        }
    }
}
