using Microsoft.AspNetCore.Mvc;

namespace WishList.Controllers
{   public class HomeContollers : Controller
    {
         public IActionResult Index()
        {
            return Index();
        }

        public IActionResult Error()
        {
            return Error();
        }

    }
   
}