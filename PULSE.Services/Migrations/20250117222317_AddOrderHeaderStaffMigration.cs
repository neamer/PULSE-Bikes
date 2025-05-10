using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PULSE.Services.Migrations
{
    public partial class AddOrderHeaderStaffMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StaffId",
                table: "OrderHeader",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderHeader_StaffId",
                table: "OrderHeader",
                column: "StaffId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderHeader_Staff",
                table: "OrderHeader",
                column: "StaffId",
                principalTable: "Staff",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderHeader_Staff",
                table: "OrderHeader");

            migrationBuilder.DropIndex(
                name: "IX_OrderHeader_StaffId",
                table: "OrderHeader");

            migrationBuilder.DropColumn(
                name: "StaffId",
                table: "OrderHeader");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                column: "BrandID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                column: "BrandID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                column: "BrandID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                column: "BrandID",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                column: "BrandID",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                column: "BrandID",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Servicing",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 2);
        }
    }
}
