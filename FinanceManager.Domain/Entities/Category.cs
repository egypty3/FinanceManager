using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace FinanceManager.Domain.Entities
{
    public class Category
    {
        [HiddenInput(DisplayValue = false)]
        public int CategoryID { get; set; }

        [Required(ErrorMessage = "Enter a name for the category!")]
        [Display(Name = "Category name")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "The category name must be between 3 and 50 characters!")]
        public string Name { get; set; }

        [HiddenInput(DisplayValue = false)]
        public string Type { get; set; }
    }
}
