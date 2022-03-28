using System;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace FinanceManager.Domain.Entities
{
    public class Saving
    {
        [HiddenInput(DisplayValue = false)]
        public int SavingID { get; set; }

        [Required(ErrorMessage = "Provide a description of the savings!")]
        [Display(Name = "Description")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "The description must be between 3 and 50 characters!")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Choose a savings category!")]
        [Display(Name = "Category")]
        public string Category { get; set; }

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "The amount must be positive!")]
        [Display(Name = "Sum")]
        [RegularExpression(@"^(0|-?\d{0,9}(\,\d{0,2})?)$", ErrorMessage = "The amount can have a maximum of two decimal places!")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Please enter a valid date!")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Data")]
        public DateTime Date { get; set; }
    }
}
