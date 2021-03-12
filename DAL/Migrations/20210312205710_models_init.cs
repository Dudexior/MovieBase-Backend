using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class models_init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Movies",
                table: "Movies");

            migrationBuilder.RenameTable(
                name: "Movies",
                newName: "Movie");

            migrationBuilder.AddColumn<long>(
                name: "ImageId",
                table: "Movie",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Movie",
                table: "Movie",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "MovieImage",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieImage", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SourceTypes",
                columns: table => new
                {
                    SourceTypeId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SourceTypes", x => x.SourceTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Displays",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DisplayDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MovieId = table.Column<long>(type: "bigint", nullable: true),
                    SourceTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Displays", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Displays_Movie_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Displays_SourceTypes_SourceTypeId",
                        column: x => x.SourceTypeId,
                        principalTable: "SourceTypes",
                        principalColumn: "SourceTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "SourceTypes",
                columns: new[] { "SourceTypeId", "Name" },
                values: new object[] { 0, "Api" });

            migrationBuilder.InsertData(
                table: "SourceTypes",
                columns: new[] { "SourceTypeId", "Name" },
                values: new object[] { 1, "UI" });

            migrationBuilder.CreateIndex(
                name: "IX_Movie_ImageId",
                table: "Movie",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_Displays_MovieId",
                table: "Displays",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Displays_SourceTypeId",
                table: "Displays",
                column: "SourceTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movie_MovieImage_ImageId",
                table: "Movie",
                column: "ImageId",
                principalTable: "MovieImage",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movie_MovieImage_ImageId",
                table: "Movie");

            migrationBuilder.DropTable(
                name: "Displays");

            migrationBuilder.DropTable(
                name: "MovieImage");

            migrationBuilder.DropTable(
                name: "SourceTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Movie",
                table: "Movie");

            migrationBuilder.DropIndex(
                name: "IX_Movie_ImageId",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "ImageId",
                table: "Movie");

            migrationBuilder.RenameTable(
                name: "Movie",
                newName: "Movies");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Movies",
                table: "Movies",
                column: "Id");
        }
    }
}
