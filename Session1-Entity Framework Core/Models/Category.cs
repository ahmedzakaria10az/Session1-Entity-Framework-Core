using System;
using System.Collections.Generic;
using System.Text;

namespace Session1_Entity_Framework_Core.Models
{
    internal class Category
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public bool IsActive { get; set; }
    }
}
