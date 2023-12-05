using Microsoft.AspNetCore.Mvc;
using appRollPayDemo.Models;

namespace appRollPayDemo.Controllers
{
    public class UserController : Controller
    {
        int insertId;
        int deleteId;
        EmployeeDb empDB = new EmployeeDb();
        public IActionResult Index()
        {
            List<Employee> listEmp = new List<Employee>();
            listEmp = this.ListUser();
            return View(listEmp);
        }
        [HttpPost]
        public JsonResult CreateUser([FromBody] Employee emp)
        {
            insertId = empDB.AddUser(emp);
            return Json(insertId);

        }
        public JsonResult DeleteUser([FromBody] string data)
        {
            deleteId = empDB.deteleUser(data);
            return Json("Dã xóa thành công");

        }

        public List<Employee> ListUser()
        {
            return empDB.ListAll();
        }
    }
}
