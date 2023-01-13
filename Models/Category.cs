using System.ComponentModel.DataAnnotations;

namespace assign.Models
{
    public class Category
    {
        [Key]
        public int Category_Id { get; set; }
        [System.ComponentModel.DataAnnotations.Required]

        public string Category_Name { get; set; } = string.Empty;
        public float Category_Limit { get; set; }

        public string Category_Description { get; set; } = string.Empty;
    }
}
