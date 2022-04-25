using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductCatalogManagement.Migrations
{
    public partial class isaadded2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Discount",
                table: "People",
                type: "float",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discount",
                table: "People");
        }
    }
}
