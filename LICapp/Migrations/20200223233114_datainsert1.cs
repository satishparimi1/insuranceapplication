using Microsoft.EntityFrameworkCore.Migrations;

namespace LICapp.Migrations
{
    public partial class datainsert1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Advisors",
                keyColumn: "Id",
                keyValue: 1,
                column: "First_Name",
                value: "satish Advisor");

            migrationBuilder.UpdateData(
                table: "Advisors",
                keyColumn: "Id",
                keyValue: 2,
                column: "First_Name",
                value: "Raj Advisor");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Advisors",
                keyColumn: "Id",
                keyValue: 1,
                column: "First_Name",
                value: "satish");

            migrationBuilder.UpdateData(
                table: "Advisors",
                keyColumn: "Id",
                keyValue: 2,
                column: "First_Name",
                value: "Raj");
        }
    }
}
