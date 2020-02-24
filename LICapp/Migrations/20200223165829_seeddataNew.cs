using Microsoft.EntityFrameworkCore.Migrations;

namespace LICapp.Migrations
{
    public partial class seeddataNew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Carriers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Bussiness",
                value: "Lic");

            migrationBuilder.UpdateData(
                table: "Carriers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Bussiness",
                value: "Lic New");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Carriers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Bussiness",
                value: null);

            migrationBuilder.UpdateData(
                table: "Carriers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Bussiness",
                value: null);
        }
    }
}
