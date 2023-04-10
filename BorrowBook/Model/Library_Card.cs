using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace BorrowBook.Model
{
    internal class Library_Card
    {
        [Key]
        public int LibraryCardID { get; set; }
        public DateTime DateBorrowed { get; set; }
        public DateTime DateofReturn { get; set; }

        public int BookID { get; set; }
        public Book Book { get; set; }

        public int EmployeeID { get; set; }
        public Employee Employee { get; set; }
        public int StudentID { get; set; }
        public Student Student { get; set; }

    }
}
