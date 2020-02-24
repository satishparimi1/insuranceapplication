using Microsoft.EntityFrameworkCore.Migrations;

namespace LICapp.Migrations
{
    public partial class updatecoulmn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bussiness",
                table: "Carriers");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Carriers",
                newName: "Bussiness_Name");

            migrationBuilder.UpdateData(
                table: "Carriers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Bussiness_Name",
                value: "satish Lic");

            migrationBuilder.UpdateData(
                table: "Carriers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Bussiness_Name",
                value: "Lic New");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Bussiness_Name",
                table: "Carriers",
                newName: "Name");

            migrationBuilder.AddColumn<string>(
                name: "Bussiness",
                table: "Carriers",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Carriers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Bussiness", "Name" },
                values: new object[] { "Lic", "satish" });

            migrationBuilder.UpdateData(
                table: "Carriers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Bussiness", "Name" },
                values: new object[] { "Lic New", "satish" });
        }
    }
}
