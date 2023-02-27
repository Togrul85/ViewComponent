using FrontToBack1.DAL;
using FrontToBack1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FrontToBack1.ViewComponents
{
 
        public class ProductViewComponent : ViewComponent
        {
            private readonly AppDbContext _appDbContext;

            public ProductViewComponent(AppDbContext appDbContext)
            {
                _appDbContext = appDbContext;
            }

            public async Task<IViewComponentResult> InvokeAsync()
            {
            var products = _appDbContext.Products;
           
                return View(await Task.FromResult(products));
            }
        }
}



