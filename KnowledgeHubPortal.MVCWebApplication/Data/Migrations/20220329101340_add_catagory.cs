using Microsoft.EntityFrameworkCore.Migrations;

namespace KnowledgeHubPortal.MVCWebApplication.Data.Migrations
{
    public partial class add_catagory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Catagories",
                columns: new[] { "CatagoryID", "CatagoryName", "Description" },
                values: new object[] { 222, "Technology", "All the latest technologies of computer science" });

            migrationBuilder.InsertData(
                table: "Catagories",
                columns: new[] { "CatagoryID", "CatagoryName", "Description" },
                values: new object[] { 333, "Entertinment", "Better way of passing time" });

            migrationBuilder.InsertData(
                table: "Catagories",
                columns: new[] { "CatagoryID", "CatagoryName", "Description" },
                values: new object[] { 444, "Social", "Get a social network" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Catagories",
                keyColumn: "CatagoryID",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Catagories",
                keyColumn: "CatagoryID",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "Catagories",
                keyColumn: "CatagoryID",
                keyValue: 444);
        }
    }
}
