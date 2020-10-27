using Microsoft.EntityFrameworkCore.Migrations;

namespace My_Rent.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Property",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PropertyName = table.Column<string>(nullable: true),
                    Owner = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    PricePerNight = table.Column<int>(nullable: false),
                    MaxCapacity = table.Column<int>(nullable: false),
                    NumOfBedrooms = table.Column<int>(nullable: false),
                    NumOfBathrooms = table.Column<int>(nullable: false),
                    ShortDescription = table.Column<string>(nullable: true),
                    LongtDescription = table.Column<string>(nullable: true),
                    HasPool = table.Column<bool>(nullable: false),
                    HasWiFi = table.Column<bool>(nullable: false),
                    HasParking = table.Column<bool>(nullable: false),
                    ImageThumbnailUrl = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    IsAvailable = table.Column<bool>(nullable: false),
                    Category = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Property", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Property");
        }
    }
}
