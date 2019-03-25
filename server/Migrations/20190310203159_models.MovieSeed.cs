using Microsoft.EntityFrameworkCore.Migrations;

namespace server.Migrations
{
    public partial class modelsMovieSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Genre", "Name" },
                values: new object[] { 3, "Ridley Scott", "Sci-Fi, Thriller", "Alien: Covenant" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Genre", "Name" },
                values: new object[] { 4, "Peter Jackson", "Adventure, Drama, Fantasy", "The Lord Of The Rings" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "Genre", "Name" },
                values: new object[] { 6, "Michael Cristofer", "Drama, Mystery, Romance", "Original Sin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
