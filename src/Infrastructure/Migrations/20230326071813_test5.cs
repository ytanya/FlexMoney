using Microsoft.EntityFrameworkCore.Migrations;

namespace FlexMoney.Infrastructure.Migrations
{
    public partial class test5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MoneyLines_Types_TypeId",
                table: "MoneyLines");

            migrationBuilder.DropIndex(
                name: "IX_MoneyLines_TypeId",
                table: "MoneyLines");

            migrationBuilder.DropColumn(
                name: "Position",
                table: "MoneyLines");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Position",
                table: "MoneyLines",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_MoneyLines_TypeId",
                table: "MoneyLines",
                column: "TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_MoneyLines_Types_TypeId",
                table: "MoneyLines",
                column: "TypeId",
                principalTable: "Types",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
