using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewYork.Models
{
    public class DBInitializer : System.Data.Entity.DropCreateDatabaseAlways<DBContext>
    {
        protected override void Seed(DBContext context)
        {
            var genres = AddGenres(context);
            /*
            context.Genres.Add(new Genre { Name = "Musical" });
            context.Genres.Add(new Genre { Name = "Play" });
            context.Genres.Add(new Genre { Name = "Children's Theater" });
            context.Genres.Add(new Genre { Name = "Experimental" });
            context.Genres.Add(new Genre { Name = "Comedy" });
            context.Genres.Add(new Genre { Name = "Drama" });
            */

            context.Shows.Add(new Show { Genre = genres.Single(g => g.Name == "Musical"), Title = "Aladdin", Theatre = "New Amsterdam Theatre", ImageUrl = "~/Images/aladdin.jpg", Price = 139.50M });
            context.Shows.Add(new Show { Genre = genres.Single(g => g.Name == "Comedy"), Title = "The Book of Mormon", Theatre = "Eugene O'Neill Theatre", ImageUrl = "~/Images/bookofmormon.jpg", Price = 231.75M });
            context.Shows.Add(new Show { Genre = genres.Single(g => g.Name == "Musical"), Title = "Chicago", Theatre = "Ambassador Theatre", ImageUrl = "~/Images/chicago.jpg", Price = 129.50M });
            context.Shows.Add(new Show { Genre = genres.Single(g => g.Name == "Play"), Title = "The Curious Incident of the Dog in the Night-Time", Theatre = "Ethel Barrymore Theatre", ImageUrl = "~/Images/curiousIncident.jpg", Price = 156.00M });
            context.Shows.Add(new Show { Genre = genres.Single(g => g.Name == "Musical"), Title = "Hamilton", Theatre = "Richard Rodgers Theatre", ImageUrl = "~/Images/hamilton.jpg", Price = 0.00M });
            context.Shows.Add(new Show { Genre = genres.Single(g => g.Name == "Musical"), Title = "Jersey Boys", Theatre = "August Wilson Theatre", ImageUrl = "~/Images/jerseyBoys.jpg", Price = 124.00M });
            context.Shows.Add(new Show { Genre = genres.Single(g => g.Name == "Musical"), Title = "Kinky Boots", Theatre = "Al Hirschfeld Theatre", ImageUrl = "~/Images/kinkyBoots.jpg", Price = 111.50M });
            context.Shows.Add(new Show { Genre = genres.Single(g => g.Name == "Musical"), Title = "The Lion King", Theatre = "Minskoff Theatre", ImageUrl = "~/Images/lionking.jpg", Price = 140.05M });
            context.Shows.Add(new Show { Genre = genres.Single(g => g.Name == "Musical"), Title = "Matilda the Musical", Theatre = "Shubert Theatre", ImageUrl = "~/Images/matilda.jpg", Price = 136.50M });
            context.Shows.Add(new Show { Genre = genres.Single(g => g.Name == "Musical"), Title = "The Phantom of the Opera", Theatre = "Majestic Theatre", ImageUrl = "~/Images/phantom.jpg", Price = 124.00M });

            context.Shows.Add(new Show { Genre = genres.Single(g => g.Name == "Musical"), Title = "Wicked", Theatre = "Gershwin Theatre", ImageUrl = "~/Images/wicked.jpg", Price = 148.00M });
            context.Shows.Add(new Show { Genre = genres.Single(g => g.Name == "Musical"), Title = "An American in Paris", Theatre = "Palace Theatre", ImageUrl = "~/Images/amerian.jpg", Price = 137.50M });
            context.Shows.Add(new Show { Genre = genres.Single(g => g.Name == "Drama"), Title = "Beautiful: The Carole King Musical", Theatre = "Stephen Sondheim Theatre", ImageUrl = "~/Images/beautifulCarolKing.jpg", Price = 139.50M });
            context.Shows.Add(new Show { Genre = genres.Single(g => g.Name == "Musical"), Title = "The Color Purple", Theatre = "Bernard B. Jacobs Theatre", ImageUrl = "~/Images/colorPurple.jpg", Price = 134.00M }); context.Shows.Add(new Show { Genre = new Genre { Name = "Musical" }, Title = "Aladdin", Theatre = "New Amsterdam Theatre", ImageUrl = "~/Images/aladdin.jpg", Price = 139.50M });
            context.Shows.Add(new Show { Genre = genres.Single(g => g.Name == "Musical"), Title = "Fiddler on the Roof", Theatre = "Broadway Theatre", ImageUrl = "~/Images/fiddlerOnTheRoof.jpg", Price = 136.50M });
            context.Shows.Add(new Show { Genre = genres.Single(g => g.Name == "Musical"), Title = "Finding Neverland", Theatre = "Lunt-Fontanne Theatre", ImageUrl = "~/Images/findingNeverland.jpg", Price = 139.00M });
            context.Shows.Add(new Show { Genre = genres.Single(g => g.Name == "Musical"), Title = "Fun Home", Theatre = "Circle in the Square Theatre", ImageUrl = "~/Images/funHome.jpg", Price = 171.00M });
            context.Shows.Add(new Show { Genre = genres.Single(g => g.Name == "Drama"), Title = "The Humans", Theatre = "Helen Hayes Theatre", ImageUrl = "~/Images/humans.jpg", Price = 106.50M });
            context.Shows.Add(new Show { Genre = genres.Single(g => g.Name == "Musical"), Title = "The King and I", Theatre = "Lincoln Center Theater", ImageUrl = "~/Images/kingAndI.jpg", Price = 153.00M });

            context.Shows.Add(new Show { Genre = genres.Single(g => g.Name == "Musical"), Title = "Les Misérables", Theatre = "Imperial Theatre", ImageUrl = "~/Images/lesMiserables.jpg", Price = 119.00M });
            context.Shows.Add(new Show { Genre = genres.Single(g => g.Name == "Musical"), Title = "On Your Feet! The Story of Emilio and Gloria Estefan", Theatre = "Marquis Theatre", ImageUrl = "~/Images/onYourFeet.jpg", Price = 151.50M });
            context.Shows.Add(new Show { Genre = genres.Single(g => g.Name == "Musical"), Title = "School of Rock", Theatre = "Winter Garden Theatre", ImageUrl = "~/Images/schoolOfRock.jpg", Price = 110.00M });
            context.Shows.Add(new Show { Genre = genres.Single(g => g.Name == "Musical"), Title = "Something Rotten", Theatre = "St. James Theatre", ImageUrl = "~/Images/somethingRotten.jpg", Price = 124.00M });
            /*
            context.Shows.Add(new Show { Genre = new Genre { Name = "Musical" }, Title = "Aladdin", Theatre = "New Amsterdam Theatre", ImageUrl = "~/Images/aladdin.jpg", Price = 139.50M });
            context.Shows.Add(new Show { Genre = new Genre { Name = "Musical" }, Title = "Aladdin", Theatre = "New Amsterdam Theatre", ImageUrl = "~/Images/aladdin.jpg", Price = 139.50M });
            context.Shows.Add(new Show { Genre = new Genre { Name = "Musical" }, Title = "Aladdin", Theatre = "New Amsterdam Theatre", ImageUrl = "~/Images/aladdin.jpg", Price = 139.50M });
            context.Shows.Add(new Show { Genre = new Genre { Name = "Musical" }, Title = "Aladdin", Theatre = "New Amsterdam Theatre", ImageUrl = "~/Images/aladdin.jpg", Price = 139.50M });
            context.Shows.Add(new Show { Genre = new Genre { Name = "Musical" }, Title = "Aladdin", Theatre = "New Amsterdam Theatre", ImageUrl = "~/Images/aladdin.jpg", Price = 139.50M });
            context.Shows.Add(new Show { Genre = new Genre { Name = "Musical" }, Title = "Aladdin", Theatre = "New Amsterdam Theatre", ImageUrl = "~/Images/aladdin.jpg", Price = 139.50M });
            */

            context.SaveChanges();
        }

        private static List<Genre> AddGenres(DBContext context)
        {
            var genres = new List<Genre>
            {
                new Genre { Name = "Musical" },
                new Genre { Name = "Play" },
                new Genre { Name = "Children's Theater" },
                new Genre { Name = "Experimental" },
                new Genre { Name = "Comedy" },
                new Genre { Name = "Drama" },

            };

            genres.ForEach(s => context.Genres.Add(s));
            context.SaveChanges();
            return genres;
        }
    }
}