using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDatabaseSample
{
    /*class Program
    {
        static void Main(string[] args)
        {

            using (var db = new Context.BloggingContext())
            { 
                // Create and save a new blog
                Console.Write("Enter a name for a new Blog: ");
                var name = Console.ReadLine();

                var blog = new Model.BlogModel { Name = name };
                db.BlogsModel.Add(blog);
                db.SaveChanges();

                var query = from b in db.BlogsModel
                            orderby b.Name
                            select b;

                Console.WriteLine("All blogs in the database:");
                foreach (var item in query)
                {

                    var blogView = new View.BlogView { Name = item.Name };
                    Console.WriteLine(blogView.Name);
                }
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }*/
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new Context.BloggingContext())
            {
                db.BlogsModel.Add(new Model.BlogModel { Name = "Another Blog " });
                db.SaveChanges();

                foreach (var blog in db.BlogsModel)
                {
                    Console.WriteLine(blog.Name);
                }
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    } 
}
