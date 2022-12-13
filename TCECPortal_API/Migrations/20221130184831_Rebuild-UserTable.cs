using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace TCECPortal_API.Migrations
{
    public partial class RebuildUserTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                   name: "Users",
                   columns: table => new
                   {
                       UserId = table.Column<int>(type: "int", nullable: false)
                           .Annotation("SqlServer:Identity", "1, 1"),
                       UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                       Pssword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                       Postion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                       Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                       Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                       MobilePhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                       ClubName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                       CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                       CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                       ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                       ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                       Profession = table.Column<string>(type: "nvarchar(max)", nullable: true),
                       BirthDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                       JoinedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                       Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                       isAdmin = table.Column<bool>(type: "bit", nullable: false),
                       Avatar = table.Column<string>(type: "nvarchar(max)", nullable: true)
                   },
                   constraints: table =>
                   {
                       table.PrimaryKey("PK_Users", x => x.UserId);
                   });

            migrationBuilder.AddColumn<int>(
                name: "MemberId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropColumn(
                name: "MemberId",
                table: "Users");
        }
    }
}
