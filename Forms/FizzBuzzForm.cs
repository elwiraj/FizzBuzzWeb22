using System.ComponentModel.DataAnnotations;
namespace FizzBuzzWeb2.Forms
{
    public class FizzBuzzForm
    {
        [Display(Name = "Twój szczęśliwy numerek")]
        [Range(1, 1000, ErrorMessage = "Oczekiwana wartość {0} z zakresu {1} i {2}.")] 
        [Required(ErrorMessage= "Pole jest obowiązkowe")]
        public int? Number { get; set; }
        public string? Response { get; set; } = "";

    }
}
