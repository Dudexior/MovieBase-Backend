using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class added_FK_to_image : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_MovieImages_ImageId",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Movies_ImageId",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "ImageId",
                table: "Movies");

            migrationBuilder.AddColumn<long>(
                name: "MovieId",
                table: "MovieImages",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_MovieImages_MovieId",
                table: "MovieImages",
                column: "MovieId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieImages_Movies_MovieId",
                table: "MovieImages",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieImages_Movies_MovieId",
                table: "MovieImages");

            migrationBuilder.DropIndex(
                name: "IX_MovieImages_MovieId",
                table: "MovieImages");

            migrationBuilder.DropColumn(
                name: "MovieId",
                table: "MovieImages");

            migrationBuilder.AddColumn<long>(
                name: "ImageId",
                table: "Movies",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Movies_ImageId",
                table: "Movies",
                column: "ImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_MovieImages_ImageId",
                table: "Movies",
                column: "ImageId",
                principalTable: "MovieImages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
