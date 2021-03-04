using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviesRentalEF.Migrations
{
    public partial class AddRentMov : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RentedMovies_Movie_MoviesMovieID",
                table: "RentedMovies");

            migrationBuilder.DropIndex(
                name: "IX_RentedMovies_MoviesMovieID",
                table: "RentedMovies");

            migrationBuilder.DropColumn(
                name: "MoviesMovieID",
                table: "RentedMovies");

            migrationBuilder.RenameColumn(
                name: "MovieRefId",
                table: "RentedMovies",
                newName: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_RentedMovies_MovieId",
                table: "RentedMovies",
                column: "MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_RentedMovies_Movie_MovieId",
                table: "RentedMovies",
                column: "MovieId",
                principalTable: "Movie",
                principalColumn: "MovieID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RentedMovies_Movie_MovieId",
                table: "RentedMovies");

            migrationBuilder.DropIndex(
                name: "IX_RentedMovies_MovieId",
                table: "RentedMovies");

            migrationBuilder.RenameColumn(
                name: "MovieId",
                table: "RentedMovies",
                newName: "MovieRefId");

            migrationBuilder.AddColumn<int>(
                name: "MoviesMovieID",
                table: "RentedMovies",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RentedMovies_MoviesMovieID",
                table: "RentedMovies",
                column: "MoviesMovieID");

            migrationBuilder.AddForeignKey(
                name: "FK_RentedMovies_Movie_MoviesMovieID",
                table: "RentedMovies",
                column: "MoviesMovieID",
                principalTable: "Movie",
                principalColumn: "MovieID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
