using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Pet.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Animals_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    AnimalId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Animals_AnimalId",
                        column: x => x.AnimalId,
                        principalTable: "Animals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Mammals" },
                    { 2, "Birds" },
                    { 3, "Fish" },
                    { 4, "Reptiles" },
                    { 5, "Amphibians" }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "Id", "Age", "CategoryId", "Description", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { 1, 4, 2, "<p>A seagull is a type of bird that lives near the sea and feeds on fish, insects, and other animals. Seagulls have white or gray feathers, long wings, and webbed feet. They can fly long distances and often travel in flocks. Seagulls are known for their loud and distinctive calls, which they use to communicate with each other and to scare away predators.</p>", "\\images\\animal\\a8ae797a-4197-4cb4-9a2d-b8e6311c3c55.jpg", "Seagull" },
                    { 2, 4, 1, "<p>A dog is a domesticated animal that belongs to the family Canidae and the order Carnivora. It is a subspecies of the gray wolf and has many different breeds that vary in size, shape, and color. Dogs have fur, four legs, a tail, and a pair of ears and eyes. They have sharp teeth and a strong jaw that help them eat meat and bones. Dogs have a keen sense of smell and hearing, and can communicate with each other and humans through barks, growls, whines, and body language. Dogs are loyal, friendly, protective, and intelligent animals that can be trained to perform various tasks such as hunting, herding, guarding, guiding, or assisting. Dogs are also popular pets that provide companionship and love to their owners.</p>", "\\images\\animal\\f2f61e0c-b0b0-42d0-a919-9c834350c372.jpg", "Dog" },
                    { 3, 4, 4, "<p>A snake is a limbless reptile that belongs to the suborder Serpentes. It has a long and slender body covered with scales that overlap each other. Some snakes have venomous fangs that they use to inject toxins into their prey, while others kill by constriction or suffocation. Snakes can vary greatly in size, from a few inches to over 20 feet long. Snakes are found in almost every habitat, except for the polar regions. They are predators that feed on a variety of animals, such as rodents, birds, frogs, and lizards.</p>", "\\images\\animal\\d418c401-5a31-440f-8dd5-ad84ff716cac.jpg", "Snake" },
                    { 4, 4, 1, "<p>Monkey: Monkeys are primates that come in all shapes and sizes. They have opposable thumbs and toes, which means they can grasp things just like humans can. They also have long tails that help them balance.</p>", "\\images\\animal\\ce96ca49-cebf-4da6-8fa1-42bc763d0f99.jpg", "Monkey" },
                    { 5, 4, 1, "<p>Giraffe: Giraffes are the tallest living terrestrial animal and the largest ruminant on Earth. They have long legs, long necks, and relatively short bodies.&nbsp;<a class=\"tooltip-target\" href=\"https://en.wikipedia.org/wiki/Giraffe\" target=\"_blank\" rel=\"noopener\" data-citationid=\"486d9dcd-e1fd-7b7d-e43f-be0a325015a5-14-group\">Their heads are topped with bony horns, and their tails are tipped with a tuft of fur</a><a class=\"ac-anchor sup-target\" href=\"https://en.wikipedia.org/wiki/Giraffe\" target=\"_blank\" rel=\"noopener\" data-citationid=\"486d9dcd-e1fd-7b7d-e43f-be0a325015a5-8\" aria-label=\"Giraffe - Wikipedia\"><sup>1</sup></a><a class=\"ac-anchor sup-target\" href=\"https://www.britannica.com/animal/giraffe\" target=\"_blank\" rel=\"noopener\" data-citationid=\"486d9dcd-e1fd-7b7d-e43f-be0a325015a5-10\" aria-label=\"Giraffe | Facts, Information, Habitat, Species, &amp; Lifespan\"><sup>2</sup></a><a class=\"ac-anchor sup-target\" href=\"https://animals.net/giraffe/\" target=\"_blank\" rel=\"noopener\" data-citationid=\"486d9dcd-e1fd-7b7d-e43f-be0a325015a5-12\" aria-label=\"Giraffe - Description, Habitat, Image, Diet, and Interesting Facts\"><sup>3</sup></a><a class=\"ac-anchor sup-target\" href=\"https://www.nationalgeographic.com/animals/mammals/facts/giraffe\" target=\"_blank\" rel=\"noopener\" data-citationid=\"486d9dcd-e1fd-7b7d-e43f-be0a325015a5-14\" aria-label=\"Giraffe | National Geographic\"><sup>4</sup></a>.</p>", "\\images\\animal\\9d9bdc35-3897-43d9-ac11-4559b07cd777.jpg", "Giraffe" },
                    { 6, 4, 2, "<p>Eagle: Eagles are large birds of prey that are known for their sharp talons and powerful beaks. They have excellent eyesight and can spot prey from great distances. Eagles are found all over the world and come in many different species.</p>", "\\images\\animal\\c8e9aa54-f49c-4c0a-b3c5-d7d0986a101e.jpg", "Eagle" }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "AnimalId", "Text" },
                values: new object[,]
                {
                    { 1, 1, "<p>This seagull is so white and clean</p>" },
                    { 2, 2, "<p>This dog has saved my day</p>" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Animals_CategoryId",
                table: "Animals",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_AnimalId",
                table: "Comments",
                column: "AnimalId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Animals");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
