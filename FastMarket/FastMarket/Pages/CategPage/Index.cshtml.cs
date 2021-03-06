using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FastMarket.Models;
using FastMarket.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FastMarket.Pages.CategPage
{
    public class IndexModel : PageModel
    {
        private readonly ICategories _categories;

        public IndexModel(ICategories categories1)
        {
            _categories = categories1;
        }
        // to git and view all categories list
        public List<Categories> list1 { get; set; }
        public async Task OnGet()
        {
            list1 = await _categories.GetCategories();
        }
    }
}
