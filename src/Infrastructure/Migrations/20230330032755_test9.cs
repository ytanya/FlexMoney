using Microsoft.EntityFrameworkCore.Migrations;

namespace FlexMoney.Infrastructure.Migrations
{
    public partial class test9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDead",
                table: "MemberLines");

            migrationBuilder.RenameColumn(
                name: "Section",
                table: "MemberLines",
                newName: "CurrentSection");

            migrationBuilder.AddColumn<int>(
                name: "currentSection",
                table: "MoneyLines",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "currentSection",
                table: "MoneyLines");

            migrationBuilder.RenameColumn(
                name: "CurrentSection",
                table: "MemberLines",
                newName: "Section");

            migrationBuilder.AddColumn<bool>(
                name: "IsDead",
                table: "MemberLines",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
