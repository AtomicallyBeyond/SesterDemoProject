using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoProducts.Migrations
{
    public partial class CustomerNotes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CustomerNotes",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerNotes",
                table: "Customers");
        }
    }
}
