using FizzBuzzWeb2.Forms;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FizzBuzzWeb2.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        [BindProperty(SupportsGet = true)]

        public FizzBuzzForm FizzBuzz { get; set; } 
        [BindProperty(SupportsGet = true)]
        public string Name {  get; set; }
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                
            }
            UpdateResponse();
            return Page();
            return RedirectToPage("./Privacy");
        }

        public void UpdateResponse()
        {
            if(FizzBuzz.Number%3==0 && FizzBuzz.Number%5==0)
            {
                FizzBuzz.Response = "FizzBuzz";
            }
            else if(FizzBuzz.Number%3==0)
            {
                FizzBuzz.Response = "Fizz";
            }
            else if(FizzBuzz.Number%5==0)
            {
                FizzBuzz.Response = "Buzz";
            }
            else
            {
                FizzBuzz.Response = "Liczba: " + FizzBuzz.Number + " nie spełnia kryteriów FizzBuzz";
            }
        }

        public void OnGet()
        {
            if(string.IsNullOrWhiteSpace(Name))
            {
                Name = "User";
            }
        }
    }
}