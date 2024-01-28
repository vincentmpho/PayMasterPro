using Microsoft.AspNetCore.Mvc;
using PayMasterPro.Models;

namespace PayMasterPro.Controllers
{
    public class DepartmentController : Controller
    {
        public async Task <IActionResult> Index()
        {
            List<Department> list = new List<Department>();
            HttpClient client = new HttpClient();
            HttpResponseMessage responseMessage = await client.GetAsync("");
            return View();
        }

        public IActionResult Add()
        
        {
            return View();
        }
    }
}
