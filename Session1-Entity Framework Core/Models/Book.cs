using System;
using System.Collections.Generic;
using System.Text;

namespace Session1_Entity_Framework_Core.Models
{
    internal class Book
    {
        public int Id { get; set; }
        public string? Title { get; set; } 
        public string? ISBN { get; set; } 
        public decimal Price { get; set; }
        public int NumberOfPages { get; set; }
        public int PublicationYear { get; set; }
        public bool IsInStock { get; set; }
    }
}
