using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    AnimalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(20) CHARACTER SET utf8mb4", maxLength: 20, nullable: false),
                    Species = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Breed = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    Description = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    Gender = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.AnimalId);
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Age", "Breed", "Description", "Gender", "Name", "Species" },
                values: new object[,]
                {
                    { 1, 7, "Calico", "Very timid, very beautiful scareddy-cat. Aloofness is result of a bad psychedilic experience. Please be gentle", "Female", "Suzie Cream Cheese", "Cat" },
                    { 2, 3, "Irish Wolfhound", "A gentle, giant, good boy. Loves snuggles and laying in fields of flowers.", "Male", "Jerry", "Dog" },
                    { 3, 2, "Maine Coon", "One cool customer, doesn't give a flying fig. Has lots of floofs.", "Male", "King Friday", "Cat" },
                    { 4, 4, "Pomeranian", "Tough and tiny, this little fuzzball has lots of spunk and sass. Enjoys treats, bellyrubs, and squeaky toys.", "Female", "Pancake", "Dog" },
                    { 5, 7, "Tuxedo", "Very vocal, very affectionate mama cat just wants all of your love", "Female", "Milk Cow", "Cat" },
                    { 6, 5, "Husky", "This sweet, magical creature will accompany you through the forest, over mountains, and love you unconditionally.", "Female", "Butterfly", "Dog" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animals");
        }
    }
}
