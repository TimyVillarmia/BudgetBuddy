using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetBuddy.Models
{
    public class Account
    {
        private int id;
        private string name;
        private string email;
        private string password;

        [DisplayName("Account Id")]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        [DisplayName("Fullname")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Name is required")]
        public string Fullname
        {
            get { return name; }
            set { name = value; }
        }

        [DisplayName("Email Address")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Email address is required")]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Your Email is not valid.")]
        public string Email { get { return email; } set { email = value; } }

        [DisplayName("Password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password is required")]
        [StringLength(8, ErrorMessage = "Password must be greater than 8")]
        public string Password { get { return password; } set { password = value; } }

        public void ForgotPassword(Account acount)
        {
            throw new NotImplementedException();
        }

        public void Login(Account acount)
        {
            throw new NotImplementedException();
        }

        public void Register(Account acount)
        {
            throw new NotImplementedException();
        }
    }
}

