using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cats",
                columns: table => new
                {
                    CatId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 20, nullable: false),
                    Breed = table.Column<string>(nullable: false),
                    Color = table.Column<string>(nullable: false),
                    Age = table.Column<int>(nullable: false),
                    Gender = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cats", x => x.CatId);
                });

            migrationBuilder.CreateTable(
                name: "Dogs",
                columns: table => new
                {
                    DogId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 20, nullable: false),
                    Breed = table.Column<string>(nullable: false),
                    Color = table.Column<string>(nullable: false),
                    Age = table.Column<int>(nullable: false),
                    Gender = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dogs", x => x.DogId);
                });

            migrationBuilder.InsertData(
                table: "Cats",
                columns: new[] { "CatId", "Age", "Breed", "Color", "Gender", "Name" },
                values: new object[,]
                {
                    { 1, 7, "Tortoiseshell", "Black/Brown", "Female", "Bijou" },
                    { 2, 10, "Ragamuffin", "Grey", "Male", "George" },
                    { 3, 13, "Short-Hair", "Black", "Female", "Ebe" },
                    { 4, 4, "Ragamuffin", "Orange/White", "Female", "White Shoes" },
                    { 5, 1, "Ragamuffin", "Orange", "Female", "Peachy Cat" }
                });

            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "DogId", "Age", "Breed", "Color", "Gender", "Name" },
                values: new object[,]
                {
                    { 6, 7, "Labrador", "Yellow", "Male", "Comet" },
                    { 7, 10, "Labrador", "Yellow", "Female", "Lizzie" },
                    { 8, 4, "Pug", "Black", "Female", "Georgia" },
                    { 9, 10, "Unknown", "Black/Grey", "Male", "Ruffin" },
                    { 10, 6, "Rottweiler", "Black/Brown", "Male", "Sir" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cats");

            migrationBuilder.DropTable(
                name: "Dogs");
        }
    }
}
