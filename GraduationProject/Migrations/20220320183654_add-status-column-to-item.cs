using Microsoft.EntityFrameworkCore.Migrations;

namespace GraduationProject.Migrations
{
    public partial class addstatuscolumntoitem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "BarCode",
                table: "Items",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Items",
                type: "nvarchar(1)",
                maxLength: 1,
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ShortCutName",
                table: "Category",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(7)",
                oldMaxLength: 7,
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Items");

            migrationBuilder.AlterColumn<string>(
                name: "BarCode",
                table: "Items",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ShortCutName",
                table: "Category",
                type: "nvarchar(7)",
                maxLength: 7,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3,
                oldNullable: true);
        }
    }
}
