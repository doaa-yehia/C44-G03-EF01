using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment.Migrations.AirlineDb
{
    /// <inheritdoc />
    public partial class RelationBetweenTransactionAndAirLine : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Transactions_AL_Id",
                table: "Transactions",
                column: "AL_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Airlines_AL_Id",
                table: "Transactions",
                column: "AL_Id",
                principalTable: "Airlines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Airlines_AL_Id",
                table: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_Transactions_AL_Id",
                table: "Transactions");
        }
    }
}
