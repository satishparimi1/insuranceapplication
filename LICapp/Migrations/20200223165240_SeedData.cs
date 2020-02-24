using Microsoft.EntityFrameworkCore.Migrations;

namespace LICapp.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Carriers",
                columns: new[] { "Id", "Bussiness", "Bussiness_Address", "Bussiness_Phone_Number", "MyProperty", "Name" },
                values: new object[] { 1, "LIC", "satish test business address", "12345678", "testproperty1", "satish" });

            migrationBuilder.InsertData(
                table: "Carriers",
                columns: new[] { "Id", "Bussiness", "Bussiness_Address", "Bussiness_Phone_Number", "MyProperty", "Name" },
                values: new object[] { 2, "LIC NEW", "parimi test business address", "12345678", "testproperty2", "satish" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Carriers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Carriers",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
