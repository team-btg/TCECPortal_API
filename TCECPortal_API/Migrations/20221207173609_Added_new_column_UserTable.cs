using Microsoft.EntityFrameworkCore.Migrations;

namespace TCECPortal_API.Migrations
{
    public partial class Added_new_column_UserTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MemberId",
                table: "Users");

            migrationBuilder.AddColumn<string>(
                name: "FacebookId",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MemberType",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MiddleInitial",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FacebookId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "MemberType",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "MiddleInitial",
                table: "Users");

            migrationBuilder.AddColumn<int>(
                name: "MemberId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
