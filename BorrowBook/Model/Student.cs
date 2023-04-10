using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace BorrowBook.Model
{
    internal class Student
    {
        [Key]
        public int StudentID { get; set; }
        public string Name { get; set; } = null!;
        public string? Address { get; set; }
        public string? Section { get; set; }
        public string? Email { get; set; }
        public string? ContactNo { get; set; }
    }
}
