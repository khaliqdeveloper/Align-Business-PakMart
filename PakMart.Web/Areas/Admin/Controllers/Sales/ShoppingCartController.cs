using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PakMart.Web.Areas.Admin.Controllers.Sales
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class ShoppingCartController : Controller
    {
        public IActionResult CurrentCarts()
        {
            return View();
        }
    }
}
