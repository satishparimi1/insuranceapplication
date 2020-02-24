using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LICapp.Migrations
{
    public partial class datainsert : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Advisors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    First_Name = table.Column<string>(nullable: true),
                    Last_Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Phone_Number = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Advisors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MGAs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Bussiness_Name = table.Column<string>(nullable: true),
                    MyProperty = table.Column<string>(nullable: true),
                    Bussiness_Address = table.Column<string>(nullable: true),
                    Bussiness_Phone_Number = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MGAs", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Advisors",
                columns: new[] { "Id", "Address", "First_Name", "Last_Name", "Phone_Number" },
                values: new object[,]
                {
                    { 1, "testproperty1", "satish", "parimi", "12345678" },
                    { 2, "testproperty1", "Raj", "kumar", "12345678" }
                });

            migrationBuilder.InsertData(
                table: "MGAs",
                columns: new[] { "Id", "Bussiness_Address", "Bussiness_Name", "Bussiness_Phone_Number", "MyProperty" },
                values: new object[,]
                {
                    { 1, "satish test business address", "satish MGA", "12345678", "testproperty1" },
                    { 2, "parimi test business address", "Lic New MGA", "12345678", "testproperty2" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Advisors");

            migrationBuilder.DropTable(
                name: "MGAs");
        }
    }
}
