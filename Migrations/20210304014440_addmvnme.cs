using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviesRentalEF.Migrations
{
    public partial class addmvnme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "RentedMovies");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "RentedMovies");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "RentedMovies");

            migrationBuilder.AddColumn<int>(
                name: "Movie",
                table: "RentedMovies",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Movie",
                table: "RentedMovies");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "RentedMovies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "RentedMovies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Phone",
                table: "RentedMovies",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
