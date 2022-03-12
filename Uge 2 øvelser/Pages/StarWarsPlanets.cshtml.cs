using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pew;
using Pew.Models;

namespace Site.Pages
{
    public class StarWarsPlanetsModel : PageModel
    {
        private readonly StarWarsLogic starWarsLogic;

        [BindProperty]
        public StarWarsPlanetsResponse data { get; set; }

        [TempData]
        public int page { get; set; } = 1;

        public StarWarsPlanetsModel(StarWarsLogic starWarsLogic)
        {
            this.starWarsLogic = starWarsLogic;
        }

        public async Task OnGetAsync()
        {
            data = await starWarsLogic.GetPlanets(page);
        }

        public async Task OnPostPreviousPageAsync()
        {
            page--;
            await OnGetAsync();
        }

        public async Task OnPostNextPageAsync()
        {
            page++;
            await OnGetAsync();
        }
    }
}