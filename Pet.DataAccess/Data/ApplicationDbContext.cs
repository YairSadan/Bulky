using Microsoft.EntityFrameworkCore;
using Pet.Models;

namespace Pet.DataAccess.Data
{
    public class ApplicationDbContext : DbContext {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Animal> Animals { get; set; }
        public DbSet<Comment> Comments { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            var category1 = new Category { Id = 1, Name = "Mammals" };
            var category2 = new Category { Id = 2, Name = "Birds" };
            var category3 = new Category { Id = 3, Name = "Fish" };
            var category4 = new Category { Id = 4, Name = "Reptiles" };
            var category5 = new Category { Id = 5, Name = "Amphibians" };

            modelBuilder.Entity<Category>().HasData(category1, category2, category3, category4, category5);

            var animal1 = new Animal { Id = 1, Name = "Seagull", Age = 4, CategoryId = 2, Description = "<p>A seagull is a type of bird that lives near the sea and feeds on fish, insects, and other animals. Seagulls have white or gray feathers, long wings, and webbed feet. They can fly long distances and often travel in flocks. Seagulls are known for their loud and distinctive calls, which they use to communicate with each other and to scare away predators.</p>", ImageUrl = "\\images\\animal\\a8ae797a-4197-4cb4-9a2d-b8e6311c3c55.jpg" };
            var animal2 = new Animal { Id = 2, Name = "Dog", Age = 4, CategoryId = 1, Description = "<p>A dog is a domesticated animal that belongs to the family Canidae and the order Carnivora. It is a subspecies of the gray wolf and has many different breeds that vary in size, shape, and color. Dogs have fur, four legs, a tail, and a pair of ears and eyes. They have sharp teeth and a strong jaw that help them eat meat and bones. Dogs have a keen sense of smell and hearing, and can communicate with each other and humans through barks, growls, whines, and body language. Dogs are loyal, friendly, protective, and intelligent animals that can be trained to perform various tasks such as hunting, herding, guarding, guiding, or assisting. Dogs are also popular pets that provide companionship and love to their owners.</p>", ImageUrl = "\\images\\animal\\f2f61e0c-b0b0-42d0-a919-9c834350c372.jpg" };
            var animal3 = new Animal { Id = 3, Name = "Snake", Age = 4, CategoryId = 4, Description = "<p>A snake is a limbless reptile that belongs to the suborder Serpentes. It has a long and slender body covered with scales that overlap each other. Some snakes have venomous fangs that they use to inject toxins into their prey, while others kill by constriction or suffocation. Snakes can vary greatly in size, from a few inches to over 20 feet long. Snakes are found in almost every habitat, except for the polar regions. They are predators that feed on a variety of animals, such as rodents, birds, frogs, and lizards.</p>", ImageUrl = "\\images\\animal\\d418c401-5a31-440f-8dd5-ad84ff716cac.jpg" };
            var animal4 = new Animal { Id = 4, Name = "Monkey", Age = 4, CategoryId = 1, Description = "<p>Monkey: Monkeys are primates that come in all shapes and sizes. They have opposable thumbs and toes, which means they can grasp things just like humans can. They also have long tails that help them balance.</p>", ImageUrl = "\\images\\animal\\ce96ca49-cebf-4da6-8fa1-42bc763d0f99.jpg" };
            var animal5 = new Animal { Id = 5, Name = "Giraffe", Age = 4, CategoryId = 1, Description = "<p>Giraffe: Giraffes are the tallest living terrestrial animal and the largest ruminant on Earth. They have long legs, long necks, and relatively short bodies.&nbsp;<a class=\"tooltip-target\" href=\"https://en.wikipedia.org/wiki/Giraffe\" target=\"_blank\" rel=\"noopener\" data-citationid=\"486d9dcd-e1fd-7b7d-e43f-be0a325015a5-14-group\">Their heads are topped with bony horns, and their tails are tipped with a tuft of fur</a><a class=\"ac-anchor sup-target\" href=\"https://en.wikipedia.org/wiki/Giraffe\" target=\"_blank\" rel=\"noopener\" data-citationid=\"486d9dcd-e1fd-7b7d-e43f-be0a325015a5-8\" aria-label=\"Giraffe - Wikipedia\"><sup>1</sup></a><a class=\"ac-anchor sup-target\" href=\"https://www.britannica.com/animal/giraffe\" target=\"_blank\" rel=\"noopener\" data-citationid=\"486d9dcd-e1fd-7b7d-e43f-be0a325015a5-10\" aria-label=\"Giraffe | Facts, Information, Habitat, Species, &amp; Lifespan\"><sup>2</sup></a><a class=\"ac-anchor sup-target\" href=\"https://animals.net/giraffe/\" target=\"_blank\" rel=\"noopener\" data-citationid=\"486d9dcd-e1fd-7b7d-e43f-be0a325015a5-12\" aria-label=\"Giraffe - Description, Habitat, Image, Diet, and Interesting Facts\"><sup>3</sup></a><a class=\"ac-anchor sup-target\" href=\"https://www.nationalgeographic.com/animals/mammals/facts/giraffe\" target=\"_blank\" rel=\"noopener\" data-citationid=\"486d9dcd-e1fd-7b7d-e43f-be0a325015a5-14\" aria-label=\"Giraffe | National Geographic\"><sup>4</sup></a>.</p>", ImageUrl = "\\images\\animal\\9d9bdc35-3897-43d9-ac11-4559b07cd777.jpg" };
            var animal6 = new Animal { Id = 6, Name = "Eagle", Age = 4, CategoryId = 2, Description = "<p>Eagle: Eagles are large birds of prey that are known for their sharp talons and powerful beaks. They have excellent eyesight and can spot prey from great distances. Eagles are found all over the world and come in many different species.</p>", ImageUrl = "\\images\\animal\\c8e9aa54-f49c-4c0a-b3c5-d7d0986a101e.jpg" };

            modelBuilder.Entity<Animal>().HasData(animal1, animal2, animal3, animal4, animal5, animal6);

            var comment1 = new Comment { Id = 1, AnimalId = 1, Text = "<p>This seagull is so white and clean</p>" };
            var comment2 = new Comment { Id = 2, AnimalId = 2, Text = "<p>This dog has saved my day</p>" };

            modelBuilder.Entity<Comment>().HasData(comment1 , comment2);
        
        }
    }
}
