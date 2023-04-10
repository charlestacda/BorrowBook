using BorrowBook.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorrowBook.Data
{
    internal class BookBorrow : DbContext
    {
        public DbSet<Book> Books { get; set; } = null!;
        public DbSet<Employee> Employees { get; set; } = null!;
        public DbSet<Library_Card> LibraryCards { get; set; } = null!;
        public DbSet<Student> Student { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BookBorrow_DB;Integrated Security=True;");
        }
    }
}
