using Microsoft.EntityFrameworkCore.Migrations;

namespace BillingManagement.UI.Migrations
{
    public partial class InitialCreatev2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "SubTotal",
                table: "Invoices",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SubTotal",
                table: "Invoices");
        }
    }
}
