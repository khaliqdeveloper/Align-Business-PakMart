using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PakMart.Web.Areas.Admin.Controllers.Customers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class CustomerRoleController : Controller
    {
        public IActionResult List()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Edit()
        {
            return View();
        }
    }
}
