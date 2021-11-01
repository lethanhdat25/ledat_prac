using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace ShuLee_PRJ_ASP.Models
{
    public class DataContext:DbContext
    {
        public DataContext() : base("T2008M_PRJ")
        {

        }
        public System.Data.Entity.DbSet<ShuLee_PRJ_ASP.Models.Product> Products { get; set; }

        public System.Data.Entity.DbSet<ShuLee_PRJ_ASP.Models.Category> Categories { get; set; }

        public System.Data.Entity.DbSet<ShuLee_PRJ_ASP.Models.Author> Authors { get; set; }

        public System.Data.Entity.DbSet<ShuLee_PRJ_ASP.Models.Book> Books { get; set; }

        public System.Data.Entity.DbSet<ShuLee_PRJ_ASP.Models.Publisher> Publishers { get; set; }

        public System.Data.Entity.DbSet<ShuLee_PRJ_ASP.Models.BookAuthor> BookAuthors { get; set; }

        public System.Data.Entity.DbSet<ShuLee_PRJ_ASP.Models.BookGenre> BookGenres { get; set; }

        public System.Data.Entity.DbSet<ShuLee_PRJ_ASP.Models.Genre> Genres { get; set; }

        public System.Data.Entity.DbSet<ShuLee_PRJ_ASP.Models.Exams> Exams { get; set; }
    }
}