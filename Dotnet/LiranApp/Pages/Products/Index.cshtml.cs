using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiranApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace LiranApp.Pages.Products {
    [BindProperties(SupportsGet = true)]
    public class Index : PageModel {
        private readonly LiranDb _dc;

        public int CurrentPage { get; set; } = 1;
        public bool HasMorePages { get; set; }
        public IEnumerable<Product> Products { get; set; }

        public Index(LiranDb dc) {
            _dc = dc;
        }

        public async Task OnGetAsync() {
            var p = await _dc.Products.Skip((CurrentPage - 1) * 10).Take(11).ToListAsync();
            HasMorePages = p.Count == 11;
            Products = p.Take(10);
        }
    }
}
