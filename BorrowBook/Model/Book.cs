using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace BorrowBook.Model
{
    internal class Book
    {
        [Key]
        public int BookID { get; set; }
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public string? Author { get; set; }
        public string? Publisher { get; set; }

    }
}
