using core_forms_validation.Models;
using Microsoft.AspNetCore.Mvc;

namespace core_forms_validation.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult WeeklyTypedLogin()
        {
            return View();
        }

        [HttpPost]

        public IActionResult LoginPost(string username, string password)
        {
            ViewBag.Username = username;
            ViewBag.Password = password;
            return View();
        }
        public IActionResult StronglyTypedLogin()
        {
            return View();
        }

        [HttpPost]

        public IActionResult LoginSuccess(LoginViewModel login)
        {
            ViewBag.Username = login.Username;    
            ViewBag.Password = login.Password;

            return View();
        }

        public IActionResult UserDetail()
        {
            var user = new LoginViewModel()
            {
                Username = "Saqib",
                Password = "12345"
            };

            return View(user);
        }

        public IActionResult UserList()
        {
            var users = new List<LoginViewModel>()
            {
               new LoginViewModel() {  Username = "Saqib", Password = "12345"},
               new LoginViewModel() {  Username = "Ahsan", Password = "19876"},
            };

            return View(users);
        }

        public IActionResult GetAccount()
        {

            return View();
        }

        [HttpPost]
        public IActionResult PostAccount(Account account)
        {
            if(ModelState.IsValid) //if validation success
            {
                return View("Success");
            }
            return RedirectToAction("GetAccount");
        }
    }
}
