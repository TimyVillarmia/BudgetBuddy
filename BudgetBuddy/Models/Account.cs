﻿using System;
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
        private string firstName;
        private string lastName;
        private string email;
        private string password;

        [DisplayName("Account Id")]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        [DisplayName("First name")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "First Name is required")]
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }


        [DisplayName("Last name")]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "First Name is required")]
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }


        [DisplayName("Email Address")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Email address is required")]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Enter a valid Email.")]
        public string Email { get { return email; } set { email = value; } }

        [DisplayName("Password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password is required")]
        [StringLength(8, ErrorMessage = "Password must be greater than 8")]
        public string Password { get { return password; } set { password = value; } }

    }
}

