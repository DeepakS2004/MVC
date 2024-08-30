using Jspotal.Models;
using Microsoft.AspNetCore.Mvc;


namespace Jsportal.Controllers
{
    [Route("[Controller]")]
    [Route("")]
    public class HomeController : Controller
    {
        [Route("")]
        [Route("[action]")]
        public IActionResult Index()
        {
            Employee employee = new Employee();
            employee.Employee_name = "Test";
            employee.Employee_dept = "cs";
            employee.Employee_id = 1;

            ViewData["username"] = "deepak";
            ViewData["score"] = 20;
            ViewData["emp"] = employee;

            ViewBag.username= "dev";
            ViewBag.score = 20;
            ViewBag.emp= employee;

            TempData["username"] = "raj";
            TempData["mark"] = 30;


            return View();
        }
        [Route("ab")]
        [Route("[action]")]
        [Route("home/aboutus/{eid?}/{ename?}")]
        public IActionResult Aboutus([FromRoute]int eid,[FromQuery]string ename) 
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee { Employee_id = 1, Employee_name = "Arun", Employee_email = "arun@gmail.com", Employee_phone = "9874563210", Employee_Description = "I'm a Dot Net Developer", Employee_image = "/images/demo.jpeg" });
            employees.Add(new Employee { Employee_id = 2, Employee_name = "Bharath", Employee_email = "Bharath@gmail.com", Employee_phone = "8574123690", Employee_Description = "I'm a  Full Stack developer", Employee_image = "/Images/pic2.jpeg" });
            employees.Add(new Employee { Employee_id = 3, Employee_name = "Deepak", Employee_email = "dk@gmail.com", Employee_phone = "9874563210", Employee_Description = "I'm a  Phython Programmer", Employee_image = "/Images/pic3.jpeg" });
            employees.Add(new Employee { Employee_id = 4, Employee_name = "Faizan", Employee_email = "faizan@gmail.com", Employee_phone = "9874563210", Employee_Description = "I'm a Frond-End Developer", Employee_image = "/Images/pic4.jpeg" });
            employees.Add(new Employee { Employee_id = 5, Employee_name = "Janani", Employee_email = "jana@gmail.com", Employee_phone = "9874563210", Employee_Description = "I'm a Tester", Employee_image = "/Images/pic5.jpeg" });
            
            Employee val = employees.Where(x => x.Employee_id == eid).FirstOrDefault();
           
            return View(val);
        }
        [Route("[action]")]
        public IActionResult Contactus()
        {
            return View();
        }
    }
}
