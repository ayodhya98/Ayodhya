using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace vehicleBooking.Migrations
{
    /// <inheritdoc />
    public partial class availabilityStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "AvailabiltyStatus",
                table: "Chauffeur",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AvailabiltyStatus",
                table: "Chauffeur");
        }
    }
}
