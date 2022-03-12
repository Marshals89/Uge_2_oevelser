using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Site.Pages
{
    public class OwnApiModel : PageModel
    {
        private readonly ILogger<OwnApiModel> _logger;

        public OwnApiModel(ILogger<OwnApiModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}