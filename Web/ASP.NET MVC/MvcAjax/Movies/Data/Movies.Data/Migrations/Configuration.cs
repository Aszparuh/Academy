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
            if (context.Actors.Any())
            {
                var firstMovieActors = new HashSet<Actor>()
                    {
                        new Actor() { Name = "Vera Farmiga", Age = 43, Gender = GenderEnum.Female },
                        new Actor() { Name = "Patrick Wilson", Age = 42, Gender = GenderEnum.Male }
                    };

                var firstMovie = new Movie()
                {
                    Title = "The Conjuring 2",
                    StudioName = "Warner Bros. Pictures",
                    Year = 2016,
                    MovieDesciption = @"Reprising their roles, Oscar nominee Vera Farmiga (""Up In the Air, "" TV's ""Bates Motel"") and Patrick Wilson (the ""Insidious"" films), star as Lorraine and Ed Warren, who, in one of their most terrifying paranormal investigations, travel to north London to help a single mother raising four children alone in a house plagued by malicious spirits.",
                    StudioAddress = "4000 Warner Blvd.Burbank, CA 91505 Burbank (818) 954 - 3000.",
                    Actors = firstMovieActors
                };

                foreach (var actor in firstMovieActors)
                {
                    actor.Movies.Add(firstMovie);
                }

                var secondMovieActors = new HashSet<Actor>()
                    {
                        new Actor() { Name = "Paula Patton", Age = 32, Gender = GenderEnum.Female },
                        new Actor() { Name = "Travis Fimmel ", Age = 35, Gender = GenderEnum.Male }
                    };

                var secondMovie = new Movie()
                {
                    Title = "Warcraft",
                    StudioName = "Universal Pictures",
                    Year = 2016,
                    MovieDesciption = @"Legendary Pictures' WARCRAFT, a 3D epic adventure of world-colliding conflict based upon Blizzard Entertainment's globally-renowned universe, is directed by Duncan Jones (Moon, Source Code) and is written by Charles Leavitt and rewritten by Duncan Jones. The producers are Charles Roven, Thomas Tull, Jon Jashni and Alex Gartner. Stuart Fenegan, Jillian Share and Brent O'Connor serve as executive producers. Blizzard's Chris Metzen co-produces. (C) Universal",
                    StudioAddress = "100 Universal City Plaza. Universal City, CA 91608 1 - 800 - UNIVERSAL(864 - 8377)",
                    Actors = secondMovieActors
                };

                foreach (var actor in secondMovieActors)
                {
                    actor.Movies.Add(secondMovie);
                }

                context.SaveChanges();
            }
        }
    }
}
