using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Site.Pages
{
    public class StarWarsModel : PageModel
    {
        private readonly ILogger<StarWarsModel> _logger;

        public StarWarsModel(ILogger<StarWarsModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}