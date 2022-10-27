using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCore.Controllers
{
    public class DestinationController : Controller
    {
        DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());
        public IActionResult Index()
        {
            var values = destinationManager.GetList();
            return View(values);
        }
    }
}
