using Microsoft.AspNetCore.Mvc;
using appRollPayDemo.Models;

namespace appRollPayDemo.Controllers
{
    public class SalaryController : Controller
    {
        int insertId;

        EmployeeDb empDB = new EmployeeDb();
        public IActionResult Index()
        {
            return View();
        }

        public JsonResult AddSalary([FromBody] Salary sa)
        {
            insertId = empDB.addSalary(sa);

            return Json("Đã thêm thành công" + insertId);
        }
    }
}
