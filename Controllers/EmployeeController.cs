using Microsoft.AspNetCore.Mvc;  
using System.Text.Encodings.Web;
namespace MvcMovie.Controllers  
{  
    public class EmployeeController : Controller  
    {  
        // GET: /Employee/Index  
        public IActionResult Index()  
        {  
            return View();  
        }  

        // GET: /Employee/Details  
        public IActionResult Details()  
        {  
            return View();  
        }  
    }  
}  