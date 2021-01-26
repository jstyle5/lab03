using Microsoft.EntityFrameworkCore.Migrations;

namespace lab03.Data.Migrations
{
    public partial class M1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Province",
                columns: table => new
                {
                    ProvinceCode = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    ProvinceName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Province", x => x.ProvinceCode);
                });

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    CityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Population = table.Column<int>(type: "int", nullable: false),
                    ProvinceCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProvinceCode1 = table.Column<string>(type: "nvarchar(2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.CityId);
                    table.ForeignKey(
                        name: "FK_City_Province_ProvinceCode1",
                        column: x => x.ProvinceCode1,
                        principalTable: "Province",
                        principalColumn: "ProvinceCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "CityId", "CityName", "Population", "ProvinceCode", "ProvinceCode1" },
                values: new object[,]
                {
                    { 1, "Vancouver", 675218, "BC", null },
                    { 16, "Vaughan", 306233, "ON", null },
                    { 15, "Mississauga", 721599, "ON", null },
                    { 14, "Ottawa", 934234, "ON", null },
                    { 13, "Toronto", 2615000, "ON", null },
                    { 12, "The Pas", 5513, "MB", null },
                    { 11, "Dauphin", 8457, "MB", null },
                    { 9, "Winnipeg", 749534, "MB", null },
                    { 10, "Selkirk", 10278, "MB", null },
                    { 7, "Red Deer", 100418, "AB", null },
                    { 6, "Edmonton", 981280, "AB", null },
                    { 5, "Calgary", 1336000, "AB", null },
                    { 4, "Burnaby", 249197, "BC", null },
                    { 3, "Surrey", 518467, "BC", null },
                    { 2, "Richmond", 216288, "BC", null },
                    { 8, "Lethbridge", 99769, "AB", null }
                });

            migrationBuilder.InsertData(
                table: "Province",
                columns: new[] { "ProvinceCode", "ProvinceName" },
                values: new object[,]
                {
                    { "ON", "Ontario" },
                    { "BC", "British Columbia" },
                    { "AB", "Alberta" },
                    { "MB", "Manitoba" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_City_ProvinceCode1",
                table: "City",
                column: "ProvinceCode1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "Province");
        }
    }
}
