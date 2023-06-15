﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pet.DataAccess.Data;

#nullable disable

namespace Pet.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230615092758_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Pet.Models.Animal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 4,
                            CategoryId = 2,
                            Description = "<p>A seagull is a type of bird that lives near the sea and feeds on fish, insects, and other animals. Seagulls have white or gray feathers, long wings, and webbed feet. They can fly long distances and often travel in flocks. Seagulls are known for their loud and distinctive calls, which they use to communicate with each other and to scare away predators.</p>",
                            ImageUrl = "\\images\\animal\\a8ae797a-4197-4cb4-9a2d-b8e6311c3c55.jpg",
                            Name = "Seagull"
                        },
                        new
                        {
                            Id = 2,
                            Age = 4,
                            CategoryId = 1,
                            Description = "<p>A dog is a domesticated animal that belongs to the family Canidae and the order Carnivora. It is a subspecies of the gray wolf and has many different breeds that vary in size, shape, and color. Dogs have fur, four legs, a tail, and a pair of ears and eyes. They have sharp teeth and a strong jaw that help them eat meat and bones. Dogs have a keen sense of smell and hearing, and can communicate with each other and humans through barks, growls, whines, and body language. Dogs are loyal, friendly, protective, and intelligent animals that can be trained to perform various tasks such as hunting, herding, guarding, guiding, or assisting. Dogs are also popular pets that provide companionship and love to their owners.</p>",
                            ImageUrl = "\\images\\animal\\f2f61e0c-b0b0-42d0-a919-9c834350c372.jpg",
                            Name = "Dog"
                        },
                        new
                        {
                            Id = 3,
                            Age = 4,
                            CategoryId = 4,
                            Description = "<p>A snake is a limbless reptile that belongs to the suborder Serpentes. It has a long and slender body covered with scales that overlap each other. Some snakes have venomous fangs that they use to inject toxins into their prey, while others kill by constriction or suffocation. Snakes can vary greatly in size, from a few inches to over 20 feet long. Snakes are found in almost every habitat, except for the polar regions. They are predators that feed on a variety of animals, such as rodents, birds, frogs, and lizards.</p>",
                            ImageUrl = "\\images\\animal\\d418c401-5a31-440f-8dd5-ad84ff716cac.jpg",
                            Name = "Snake"
                        },
                        new
                        {
                            Id = 4,
                            Age = 4,
                            CategoryId = 1,
                            Description = "<p>Monkey: Monkeys are primates that come in all shapes and sizes. They have opposable thumbs and toes, which means they can grasp things just like humans can. They also have long tails that help them balance.</p>",
                            ImageUrl = "\\images\\animal\\ce96ca49-cebf-4da6-8fa1-42bc763d0f99.jpg",
                            Name = "Monkey"
                        },
                        new
                        {
                            Id = 5,
                            Age = 4,
                            CategoryId = 1,
                            Description = "<p>Giraffe: Giraffes are the tallest living terrestrial animal and the largest ruminant on Earth. They have long legs, long necks, and relatively short bodies.&nbsp;<a class=\"tooltip-target\" href=\"https://en.wikipedia.org/wiki/Giraffe\" target=\"_blank\" rel=\"noopener\" data-citationid=\"486d9dcd-e1fd-7b7d-e43f-be0a325015a5-14-group\">Their heads are topped with bony horns, and their tails are tipped with a tuft of fur</a><a class=\"ac-anchor sup-target\" href=\"https://en.wikipedia.org/wiki/Giraffe\" target=\"_blank\" rel=\"noopener\" data-citationid=\"486d9dcd-e1fd-7b7d-e43f-be0a325015a5-8\" aria-label=\"Giraffe - Wikipedia\"><sup>1</sup></a><a class=\"ac-anchor sup-target\" href=\"https://www.britannica.com/animal/giraffe\" target=\"_blank\" rel=\"noopener\" data-citationid=\"486d9dcd-e1fd-7b7d-e43f-be0a325015a5-10\" aria-label=\"Giraffe | Facts, Information, Habitat, Species, &amp; Lifespan\"><sup>2</sup></a><a class=\"ac-anchor sup-target\" href=\"https://animals.net/giraffe/\" target=\"_blank\" rel=\"noopener\" data-citationid=\"486d9dcd-e1fd-7b7d-e43f-be0a325015a5-12\" aria-label=\"Giraffe - Description, Habitat, Image, Diet, and Interesting Facts\"><sup>3</sup></a><a class=\"ac-anchor sup-target\" href=\"https://www.nationalgeographic.com/animals/mammals/facts/giraffe\" target=\"_blank\" rel=\"noopener\" data-citationid=\"486d9dcd-e1fd-7b7d-e43f-be0a325015a5-14\" aria-label=\"Giraffe | National Geographic\"><sup>4</sup></a>.</p>",
                            ImageUrl = "\\images\\animal\\9d9bdc35-3897-43d9-ac11-4559b07cd777.jpg",
                            Name = "Giraffe"
                        },
                        new
                        {
                            Id = 6,
                            Age = 4,
                            CategoryId = 2,
                            Description = "<p>Eagle: Eagles are large birds of prey that are known for their sharp talons and powerful beaks. They have excellent eyesight and can spot prey from great distances. Eagles are found all over the world and come in many different species.</p>",
                            ImageUrl = "\\images\\animal\\c8e9aa54-f49c-4c0a-b3c5-d7d0986a101e.jpg",
                            Name = "Eagle"
                        });
                });

            modelBuilder.Entity("Pet.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Mammals"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Birds"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Fish"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Reptiles"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Amphibians"
                        });
                });

            modelBuilder.Entity("Pet.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AnimalId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("AnimalId");

                    b.ToTable("Comments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AnimalId = 1,
                            Text = "<p>This seagull is so white and clean</p>"
                        },
                        new
                        {
                            Id = 2,
                            AnimalId = 2,
                            Text = "<p>This dog has saved my day</p>"
                        });
                });

            modelBuilder.Entity("Pet.Models.Animal", b =>
                {
                    b.HasOne("Pet.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Pet.Models.Comment", b =>
                {
                    b.HasOne("Pet.Models.Animal", "Animal")
                        .WithMany()
                        .HasForeignKey("AnimalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Animal");
                });
#pragma warning restore 612, 618
        }
    }
}