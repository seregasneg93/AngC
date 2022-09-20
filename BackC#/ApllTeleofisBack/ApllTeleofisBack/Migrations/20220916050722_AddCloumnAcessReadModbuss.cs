using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApllTeleofisBack.Migrations
{
    public partial class AddCloumnAcessReadModbuss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "AcessReadModbuss",
                table: "Terminals",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AcessReadModbuss",
                table: "Terminals");
        }
    }
}
