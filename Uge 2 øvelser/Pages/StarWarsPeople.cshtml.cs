using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pew;
using Pew.Models;

namespace Site.Pages
{
    public class StarWarsPeopleModel : PageModel
    {
        private readonly StarWarsLogic starWarsLogic;

        [BindProperty]
        public StarWarsPeopleResponse data { get; set; }

        [TempData]
        public int page { get; set; } = 1;

        public StarWarsPeopleModel(StarWarsLogic starWarsLogic)
        {
            this.starWarsLogic = starWarsLogic;
        }

        public async Task OnGetAsync()
        {
            data = await starWarsLogic.GetPeople(page);
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