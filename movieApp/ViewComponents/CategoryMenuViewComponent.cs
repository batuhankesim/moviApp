using Microsoft.AspNetCore.Mvc;
using movieApp.Data;

namespace movieApp.ViewComponents
{
    public class CategoryMenuViewComponent: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
           // if (RouteData.Values["action"].ToString()=="index")
                 ViewBag.SelectedCategory = RouteData?.Values["id"];
            return View(CategoryRepository.Categories);
        }
    }
}