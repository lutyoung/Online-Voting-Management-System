using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineVotingSystem.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Candidates",
                maxLength: 160,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Candidates",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 160);
        }
    }
}
