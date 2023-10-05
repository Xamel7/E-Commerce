using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Models
{
    public class Category
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
    }
}
