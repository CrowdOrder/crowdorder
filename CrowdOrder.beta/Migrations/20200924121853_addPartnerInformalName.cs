using Microsoft.EntityFrameworkCore.Migrations;

namespace CrowdOrder.beta.Migrations
{
    public partial class addPartnerInformalName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MainContactInformalName",
                table: "Partners",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MainContactInformalName",
                table: "Partners");
        }
    }
}
