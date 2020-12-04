using Microsoft.EntityFrameworkCore.Migrations;

namespace FreidrdEventApp4.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    EventId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventName = table.Column<string>(maxLength: 50, nullable: false),
                    EventCity = table.Column<string>(maxLength: 50, nullable: false),
                    EventDate = table.Column<string>(maxLength: 50, nullable: false),
                    VenueName = table.Column<string>(maxLength: 50, nullable: false),
                    VenueAddress = table.Column<string>(maxLength: 50, nullable: false),
                    PromoterName = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.EventId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Events");
        }
    }
}
