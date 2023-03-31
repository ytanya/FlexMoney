using Microsoft.EntityFrameworkCore.Migrations;

namespace FlexMoney.Infrastructure.Migrations
{
    public partial class deadsection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CurrentSection",
                table: "MemberLines",
                newName: "DeadSection");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DeadSection",
                table: "MemberLines",
                newName: "CurrentSection");
        }
    }
}
