using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class MovieImages_fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Displays_Movie_MovieId",
                table: "Displays");

            migrationBuilder.DropForeignKey(
                name: "FK_Movie_MovieImage_ImageId",
                table: "Movie");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MovieImage",
                table: "MovieImage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Movie",
                table: "Movie");

            migrationBuilder.RenameTable(
                name: "MovieImage",
                newName: "MovieImages");

            migrationBuilder.RenameTable(
                name: "Movie",
                newName: "Movies");

            migrationBuilder.RenameIndex(
                name: "IX_Movie_ImageId",
                table: "Movies",
                newName: "IX_Movies_ImageId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MovieImages",
                table: "MovieImages",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Movies",
                table: "Movies",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Displays_Movies_MovieId",
                table: "Displays",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_MovieImages_ImageId",
                table: "Movies",
                column: "ImageId",
                principalTable: "MovieImages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Displays_Movies_MovieId",
                table: "Displays");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_MovieImages_ImageId",
                table: "Movies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Movies",
                table: "Movies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MovieImages",
                table: "MovieImages");

            migrationBuilder.RenameTable(
                name: "Movies",
                newName: "Movie");

            migrationBuilder.RenameTable(
                name: "MovieImages",
                newName: "MovieImage");

            migrationBuilder.RenameIndex(
                name: "IX_Movies_ImageId",
                table: "Movie",
                newName: "IX_Movie_ImageId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Movie",
                table: "Movie",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MovieImage",
                table: "MovieImage",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Displays_Movie_MovieId",
                table: "Displays",
                column: "MovieId",
                principalTable: "Movie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Movie_MovieImage_ImageId",
                table: "Movie",
                column: "ImageId",
                principalTable: "MovieImage",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
