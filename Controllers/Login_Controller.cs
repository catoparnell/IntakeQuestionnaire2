using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace IntakeQuestionnaire.Controllers
{
    public class Login_Controller : Controller
    {
        //
        // GET: /Login_/

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Models.login user)
        {
            if (ModelState.IsValid)
            {
                if (user.IsValid(user.UserName, user.Password)) //fetches wether the method is 'Accounts class' is true
                {
                    return RedirectToAction("Questionnaire", "Questionnaire");
                }
                else
                {
                    ModelState.AddModelError("", "Login data is incorrect!");
                }
            }
            return View(user);
        }
        [AllowAnonymous]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(Models.Register register)
        {
            
            if (ModelState.IsValid)
            {
                if (register.UserName != null && register.Email != null && register.Password != null && register.ConfirmPassword != null)
                {
                    if (register.Password == register.ConfirmPassword)
                    {
                        System.Data.SqlClient.SqlConnection sqlConnection1 =
                        new System.Data.SqlClient.SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename"+
                        @"='C:\Users\sue\Documents\Visual Studio 2013\Projects\IntakeQuestionnaire\IntakeQuestionnaire\App_Data\Login.mdf';Integrated Security=True");

                        System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.CommandText = "INSERT INTO [dbo].[System_Users] ( [Username], [Password], [Email] )VALUES ('" + register.UserName + "','" + register.Password + "','"+register.Email+"')";
                        cmd.Connection = sqlConnection1;
                        sqlConnection1.Open();
                        cmd.ExecuteNonQuery();
                        sqlConnection1.Close();
                        return RedirectToAction("");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Password login data is incorrect!");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Registration data is incorrect!");
                }
            }
            return View(register);
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}
