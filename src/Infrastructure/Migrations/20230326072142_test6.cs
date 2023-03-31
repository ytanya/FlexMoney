using Microsoft.EntityFrameworkCore.Migrations;

namespace FlexMoney.Infrastructure.Migrations
{
    public partial class test6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MoneyLines_Types_TypeId",
                table: "MoneyLines");

            migrationBuilder.DropIndex(
                name: "IX_MoneyLines_TypeId",
                table: "MoneyLines");
        }
    }
}
