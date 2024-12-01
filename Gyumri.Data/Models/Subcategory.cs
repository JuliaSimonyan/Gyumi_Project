﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Gyumri.Data.Models
{
    public class Subcategory
    {
        public int SubcategoryId { get; set; }
        public string? Name { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public List<Place> Places { get; set; }
    }
}