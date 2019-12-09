using Microsoft.EntityFrameworkCore.Migrations;

namespace UsedCars.Data.Migrations
{
    public partial class CreateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    Color = table.Column<string>(nullable: true),
                    Year = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Color", "Name", "Price", "Year" },
                values: new object[] { 2, "zwart", "volvo", 28000, 2018 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Color", "Name", "Price", "Year" },
                values: new object[] { 3, "grijs", "volvo", 25000, 2017 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Color", "Name", "Price", "Year" },
                values: new object[] { 4, "grijs", "audi", 35000, 2017 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Color", "Name", "Price", "Year" },
                values: new object[] { 5, "rood", "audi", 30000, 2015 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Color", "Name", "Price", "Year" },
                values: new object[] { 6, "blauw", "renault", 18000, 2015 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Color", "Name", "Price", "Year" },
                values: new object[] { 7, "blauw", "nissan", 21000, 2016 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Color", "Name", "Price", "Year" },
                values: new object[] { 8, "groen", "vw", 15000, 2012 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Color", "Name", "Price", "Year" },
                values: new object[] { 1, "rood", "volvoObj", 23000, 2017 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Color", "Name", "Price", "Year" },
                values: new object[] { 9, "geel", "volvoObj2", 22000, 2017 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Color", "Name", "Price", "Year" },
                values: new object[] { 10, "geel", "volvoObj3", 20000, 2011 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");
        }
    }
}
