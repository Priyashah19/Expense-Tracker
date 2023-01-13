using System.ComponentModel.DataAnnotations;

namespace assign.Models
{
    public class Transaction
    {
        [Key]
        public int Expense_Id { get; set; }

        [Required]
        public string Expense_Title { get; set;} = string.Empty;

        [Required]
        public string Expense_Description { get; set; } = string.Empty;

        [Required]
        public int Expense_Limit { get; set;}
        public int Category_Id { get; set; }
        public string Category_Title { get; set; } = string.Empty;
        public Category? Category { get; set; }

        [Required]
        public DateTime DateTime { get; set; } = DateTime.Now;

    }
}
