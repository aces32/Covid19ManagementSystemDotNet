using Microsoft.EntityFrameworkCore.Migrations;

namespace COVID_19PCR.TestManagement.Persistence.Migrations
{
    public partial class TableChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Individuals_IndividualLabs_IndividualLabId",
                table: "Individuals");

            migrationBuilder.DropIndex(
                name: "IX_Individuals_IndividualLabId",
                table: "Individuals");

            migrationBuilder.DropColumn(
                name: "IndividualLabId",
                table: "Individuals");

            migrationBuilder.AddColumn<int>(
                name: "IndividualId",
                table: "IndividualLabs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_IndividualLabs_IndividualId",
                table: "IndividualLabs",
                column: "IndividualId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_IndividualLabs_Individuals_IndividualId",
                table: "IndividualLabs",
                column: "IndividualId",
                principalTable: "Individuals",
                principalColumn: "IndividualId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IndividualLabs_Individuals_IndividualId",
                table: "IndividualLabs");

            migrationBuilder.DropIndex(
                name: "IX_IndividualLabs_IndividualId",
                table: "IndividualLabs");

            migrationBuilder.DropColumn(
                name: "IndividualId",
                table: "IndividualLabs");

            migrationBuilder.AddColumn<int>(
                name: "IndividualLabId",
                table: "Individuals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Individuals_IndividualLabId",
                table: "Individuals",
                column: "IndividualLabId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Individuals_IndividualLabs_IndividualLabId",
                table: "Individuals",
                column: "IndividualLabId",
                principalTable: "IndividualLabs",
                principalColumn: "IndividualLabId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
