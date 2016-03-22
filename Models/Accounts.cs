using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace IntakeQuestionnaire.Models
{
    public class login
    {
        [Required]
        [Display(Name = "User Name")]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
        //password and username
        /// Checks if user with given password exists in the database
        public bool IsValid(string _username, string _password) //sends a true or false 
        {
            using (var cn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename"+
            @"='C:\Users\sue\Documents\Visual Studio 2013\Projects\IntakeQuestionnaire\IntakeQuestionnaire\App_Data\Login.mdf';Integrated Security=True"))
            {
                string _sql = @"SELECT [Username] FROM [dbo].[System_Users] " +
                       @"WHERE [Username] = @u AND [Password] = @p";
                var cmd = new SqlCommand(_sql, cn);
                cmd.Parameters
                    .Add(new SqlParameter("@u", SqlDbType.NVarChar))
                    .Value = _username;
                cmd.Parameters
                    .Add(new SqlParameter("@p", SqlDbType.NVarChar))
                    .Value = _password;
                cn.Open();
                var reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Dispose();
                    cmd.Dispose();
                    return true;
                }
                else
                {
                    reader.Dispose();
                    cmd.Dispose();
                    return false;
                }
            }
        }
    }
    public class Register
    {
        [Required]
        [Display(Name="User Name")]
        public String UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(20,ErrorMessage="The {0} must be at least {2} characters long.",MinimumLength=6)]
        [Display(Name="Password")]
        public String Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage="The passwords do not match.")]
        public String ConfirmPassword { get; set; }
        [Required]
        [Display(Name="Email")]
        [EmailAddress]
        public String Email { get; set; }
    }
}