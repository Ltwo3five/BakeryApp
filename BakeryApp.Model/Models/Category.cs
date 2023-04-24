using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BakeryApp.Model.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public int? ParentCategoryId { get; set; }
        public string? Name { get; set; }

    }
}
