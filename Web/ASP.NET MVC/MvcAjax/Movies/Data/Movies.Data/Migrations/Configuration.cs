namespace Movies.Data.Migrations
{
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;

    public sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = false;
            this.AutomaticMigrationDataLossAllowed = false;
        }

        protected override void Seed(ApplicationDbContext context)
        {
            // This method will be called after migrating to the latest version.

            // You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            if (!context.Users.Any())
            {
                var roleStore = new RoleStore<IdentityRole>(context);
                var roleManager = new RoleManager<IdentityRole>(roleStore);
                var userStore = new UserStore<ApplicationUser>(context);
                var userManager = new UserManager<ApplicationUser>(userStore);

                // Add missing roles
                var role = roleManager.FindByName("Admin");
                if (role == null)
                {
                    role = new IdentityRole("Admin");
                    roleManager.Create(role);
                }

                // Create test users
                var user = userManager.FindByName("admin");
                if (user == null)
                {
                    var newUser = new ApplicationUser()
                    {
                        UserName = "admin@admin.bg",
                        Email = "admin@admin.bg",
                        PhoneNumber = "5551234567",
                    };
                    userManager.Create(newUser, "Password1");
                    userManager.SetLockoutEnabled(newUser.Id, false);
                    userManager.AddToRole(newUser.Id, "Admin");
                }
            }

            // Seed Actors and Movies
            if (!context.Actors.Any())
            {
                var warnerBros = new Studio()
                {
                    StudioName = "Warner Bros. Pictures",
                    StudioAddress = "4000 Warner Blvd.Burbank, CA 91505 Burbank (818) 954 - 3000."
                };

                var universal = new Studio()
                {
                    StudioName = "Universal Pictures",
                    StudioAddress = "100 Universal City Plaza. Universal City, CA 91608 1 - 800 - UNIVERSAL(864 - 8377)"
                };

                var paramountStudio = new Studio()
                {
                    StudioName = "Paramount Pictures",
                    StudioAddress = "Paramount Pictures Studios. 5555 Melrose Ave, Los Angeles, CA 90038.(323) 956 - 5000."
                };

                var foxStudio = new Studio()
                {
                    StudioName = "20th Century Fox",
                    StudioAddress = "Century City 10201 W Pico Blvd Los Angeles"
                };

                var movies = new HashSet<Movie>()
                {
                    new Movie()
                    {
                        Title = "Warcraft",
                        Studio = universal,
                        Year = 2016,
                        MovieDesciption = @"Legendary Pictures' WARCRAFT, a 3D epic adventure of world-colliding conflict based upon Blizzard Entertainment's globally-renowned universe, is directed by Duncan Jones (Moon, Source Code) and is written by Charles Leavitt and rewritten by Duncan Jones. The producers are Charles Roven, Thomas Tull, Jon Jashni and Alex Gartner. Stuart Fenegan, Jillian Share and Brent O'Connor serve as executive producers. Blizzard's Chris Metzen co-produces. (C) Universal",
                        Actors = new HashSet<Actor>()
                        {
                            new Actor() { Name = "Paula Patton", Age = 32, Gender = GenderEnum.Female },
                            new Actor() { Name = "Travis Fimmel ", Age = 35, Gender = GenderEnum.Male }
                        }
                    },
                    new Movie()
                    {
                        Title = "The Conjuring 2",
                        Studio = warnerBros,
                        Year = 2016,
                        MovieDesciption = @"Reprising their roles, Oscar nominee Vera Farmiga (""Up In the Air, "" TV's ""Bates Motel"") and Patrick Wilson (the ""Insidious"" films), star as Lorraine and Ed Warren, who, in one of their most terrifying paranormal investigations, travel to north London to help a single mother raising four children alone in a house plagued by malicious spirits.",
                        Actors = new HashSet<Actor>()
                        {
                            new Actor() { Name = "Vera Farmiga", Age = 43, Gender = GenderEnum.Female },
                            new Actor() { Name = "Patrick Wilson", Age = 42, Gender = GenderEnum.Male }
                        }
                    },

                    new Movie()
                    {
                        Title = "Star Trek Beyond",
                        Studio = paramountStudio,
                        Year = 2016,
                        MovieDesciption = "Beyond continues the franchise's post-reboot hot streak with an epic sci-fi adventure that honors the series' sci-fi roots without skimping on the blockbuster action.",
                        Actors = new HashSet<Actor>()
                        {
                            new Actor() { Name = "Zoe Saldana", Age = 32, Gender = GenderEnum.Female },
                            new Actor() { Name = "Chris Pine", Age = 35, Gender = GenderEnum.Male }
                        }
                    },
                    new Movie()
                    {
                        Title = "Ice Age: Collision Course",
                        Studio = foxStudio,
                        Year = 2016,
                        MovieDesciption = "Scrat's epic pursuit of the elusive acorn catapults him into the universe where he accidentally sets off a series of cosmic events that transform and threaten the Ice Age World. To save themselves, Sid, Manny, Diego, and the rest of the herd must leave their home and embark on a quest full of comedy and adventure, travelling to exotic new lands and encountering a host of colorful new characters.",
                        Actors = new HashSet<Actor>()
                        {
                            new Actor() { Name = "Jennifer Lopez", Age = 32, Gender = GenderEnum.Female },
                            new Actor() { Name = "Ray Romano ", Age = 35, Gender = GenderEnum.Male }
                        }
                    },
                    new Movie()
                    {
                        Title = "LIGHTS OUT",
                        Studio = warnerBros,
                        Year = 2016,
                        MovieDesciption = "Critics Consensus: Lights Out makes skillful use of sturdy genre tropes -- and some terrific performances -- for an unsettling, fright-filled experience that delivers superior chills without skimping on story.",
                        Actors = new HashSet<Actor>()
                        {
                            new Actor() { Name = "Teresa Palmer", Age = 32, Gender = GenderEnum.Female },
                            new Actor() { Name = "Billy Burke ", Age = 35, Gender = GenderEnum.Male }
                        }
                    },
                    new Movie()
                    {
                        Title = "ABSOLUTELY FABULOUS: THE MOVIE",
                        Studio = warnerBros,
                        Year = 2016,
                        MovieDesciption = "Appropriate for their big screen debut, Edina and Patsy are still oozing glitz and glamour, living the high life they are accustomed to; shopping, drinking and clubbing their way around London's trendiest hotspots. Blamed for a major incident at an uber fashionable launch party, they become entangled in a media storm and are relentlessly pursued by the paparazzi. Fleeing penniless to the glamorous playground of the super-rich, the French Riviera, they hatch a plan to make their escape permanent and live the high life forever more!",
                        Actors = new HashSet<Actor>()
                        {
                            new Actor() { Name = "Jennifer Saunders", Age = 32, Gender = GenderEnum.Female },
                            new Actor() { Name = "Chris Colfer", Age = 35, Gender = GenderEnum.Male }
                        }
                    },
                    new Movie()
                    {
                        Title = "DON'T THINK TWICE",
                        Studio = warnerBros,
                        Year = 2016,
                        MovieDesciption = "Don't Think Twice offers a bittersweet look at the comedian's life that's as genuinely moving as it is laugh-out-loud funny -- and a brilliant calling card for writer-director Mike Birbiglia.",
                        Actors = new HashSet<Actor>()
                        {
                            new Actor() { Name = "Gillian Jacobs ", Age = 32, Gender = GenderEnum.Female },
                            new Actor() { Name = "Keegan-Michael Key", Age = 35, Gender = GenderEnum.Male }
                        }
                    },
                    new Movie()
                    {
                        Title = "THE SECRET LIFE OF PETS",
                        Studio = warnerBros,
                        Year = 2016,
                        MovieDesciption = " Fast-paced, funny, and blessed with a talented voice cast, The Secret Life of Pets offers a beautifully animated, cheerfully undemanding family-friendly diversion.",
                        Actors = new HashSet<Actor>()
                        {
                            new Actor() { Name = "Ellie Kemper", Age = 32, Gender = GenderEnum.Female },
                            new Actor() { Name = "Louis C.K.", Age = 35, Gender = GenderEnum.Male }
                        }
                    },
                    new Movie()
                    {
                        Title = "THE INFILTRATOR",
                        Studio = warnerBros,
                        Year = 2016,
                        MovieDesciption = "The Infiltrator's compelling fact-based story and tremendously talented cast are often just enough to balance out its derivative narrative and occasionally clunky execution.",
                        Actors = new HashSet<Actor>()
                        {
                            new Actor() { Name = "Diane Kruger", Age = 32, Gender = GenderEnum.Female },
                            new Actor() { Name = "Bryan Cranston ", Age = 35, Gender = GenderEnum.Male }
                        }
                    },
                    new Movie()
                    {
                        Title = "Ghostbusters",
                        Studio = warnerBros,
                        Year = 2016,
                        MovieDesciption = "Ghostbusters does an impressive job of standing on its own as a freewheeling, marvelously cast supernatural comedy -- even if it can't help but pale somewhat in comparison with the classic original.",
                        Actors = new HashSet<Actor>()
                        {
                            new Actor() { Name = "Melissa McCarthy ", Age = 32, Gender = GenderEnum.Female },
                            new Actor() { Name = "Charles Dance", Age = 35, Gender = GenderEnum.Male }
                        }
                    },
                    new Movie()
                    {
                        Title = "THE LEGEND OF TARZAN",
                        Studio = warnerBros,
                        Year = 2016,
                        MovieDesciption = "The Legend of Tarzan has more on its mind than many movies starring the classic character, but that isn't enough to make up for its generic plot or sluggish pace",
                        Actors = new HashSet<Actor>()
                        {
                            new Actor() { Name = "Margot Robbie", Age = 32, Gender = GenderEnum.Female },
                            new Actor() { Name = "Alexander Skarsgård", Age = 35, Gender = GenderEnum.Male }
                        }
                    },
                };

                foreach (var movie in movies)
                {
                    context.Movies.Add(movie);
                }

                context.SaveChanges();
            }
        }
    }
}
