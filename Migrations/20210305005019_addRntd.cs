using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviesRentalEF.Migrations
{
    public partial class addRntd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Movie",
                table: "RentedMovies",
                newName: "Movies");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Movies",
                table: "RentedMovies",
                newName: "Movie");
        }
    }
}
