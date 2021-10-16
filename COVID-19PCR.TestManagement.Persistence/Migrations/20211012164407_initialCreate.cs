using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace COVID_19PCR.TestManagement.Persistence.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IndividualLabs",
                columns: table => new
                {
                    IndividualLabId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestType = table.Column<int>(type: "int", nullable: false),
                    TestOutCome = table.Column<int>(type: "int", nullable: false),
                    TestCompleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndividualLabs", x => x.IndividualLabId);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    LocationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocationName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.LocationID);
                });

            migrationBuilder.CreateTable(
                name: "AdminBookingAllocations",
                columns: table => new
                {
                    AdminBookingAllocationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    SpaceAllocated = table.Column<int>(type: "int", nullable: false),
                    BookingDates = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LocationID = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminBookingAllocations", x => x.AdminBookingAllocationId);
                    table.ForeignKey(
                        name: "FK_AdminBookingAllocations_Locations_LocationID",
                        column: x => x.LocationID,
                        principalTable: "Locations",
                        principalColumn: "LocationID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Individuals",
                columns: table => new
                {
                    IndividualId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IndividualFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IndividualLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IndividualEmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IndividualMobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IndividualBookingStatus = table.Column<bool>(type: "bit", nullable: false),
                    AdminBookingAllocationId = table.Column<int>(type: "int", nullable: false),
                    IndividualLabId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Individuals", x => x.IndividualId);
                    table.ForeignKey(
                        name: "FK_Individuals_AdminBookingAllocations_AdminBookingAllocationId",
                        column: x => x.AdminBookingAllocationId,
                        principalTable: "AdminBookingAllocations",
                        principalColumn: "AdminBookingAllocationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Individuals_IndividualLabs_IndividualLabId",
                        column: x => x.IndividualLabId,
                        principalTable: "IndividualLabs",
                        principalColumn: "IndividualLabId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "LocationID", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "LocationName" },
                values: new object[,]
                {
                    { 1, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, "Lagos, Nigeria" },
                    { 2, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, "Ogun, Nigeria" },
                    { 3, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, "Texas, USA" },
                    { 4, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, null, "San Fransisco, USA" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdminBookingAllocations_LocationID",
                table: "AdminBookingAllocations",
                column: "LocationID");

            migrationBuilder.CreateIndex(
                name: "IX_Individuals_AdminBookingAllocationId",
                table: "Individuals",
                column: "AdminBookingAllocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Individuals_IndividualLabId",
                table: "Individuals",
                column: "IndividualLabId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Individuals");

            migrationBuilder.DropTable(
                name: "AdminBookingAllocations");

            migrationBuilder.DropTable(
                name: "IndividualLabs");

            migrationBuilder.DropTable(
                name: "Locations");
        }
    }
}
