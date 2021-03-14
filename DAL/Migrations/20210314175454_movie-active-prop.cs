using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class movieactiveprop : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Displays_Movies_MovieId",
                table: "Displays");

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Movies",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AlterColumn<long>(
                name: "MovieId",
                table: "Displays",
                type: "bigint",
                nullable: true,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Displays_Movies_MovieId",
                table: "Displays",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Displays_Movies_MovieId",
                table: "Displays");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "Movies");

            migrationBuilder.AlterColumn<long>(
                name: "MovieId",
                table: "Displays",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddForeignKey(
                name: "FK_Displays_Movies_MovieId",
                table: "Displays",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
