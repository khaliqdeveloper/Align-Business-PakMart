using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PakMart.Web.Areas.Admin.Controllers.Sales
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class OrderController : Controller
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

        public IActionResult ShipmentList()
        {
            return View();
        }
        
        public IActionResult ShipmentDetails()
        {
            return View();
        }
        public IActionResult AddressEdit(int orderId, int addressId)
        {
            return View();
        }
    }
}
