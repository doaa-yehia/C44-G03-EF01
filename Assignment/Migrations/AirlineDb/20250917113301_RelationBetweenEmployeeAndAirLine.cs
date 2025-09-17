using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment.Migrations.AirlineDb
{
    /// <inheritdoc />
    public partial class RelationBetweenEmployeeAndAirLine : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Employees_AL_Id",
                table: "Employees",
                column: "AL_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Airlines_AL_Id",
                table: "Employees",
                column: "AL_Id",
                principalTable: "Airlines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Airlines_AL_Id",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_AL_Id",
                table: "Employees");
        }
    }
}
