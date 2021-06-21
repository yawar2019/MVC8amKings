using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC8amKings.Models
{
    public class RegistrationModel
    {
        public int UserId { get; set; }
        [Required(ErrorMessage ="UserName Cannot be Empty")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password Cannot be Empty")]
        public string Password { get; set; }
        [Compare("Password",ErrorMessage ="pwd and cpwd is not matching")]
        public string ConfirmPassword { get; set; }
        [DataType(DataType.EmailAddress,ErrorMessage ="Invalid Email Id")]
        public string EmailId { get; set; }
        [Range(18,50,ErrorMessage ="Age should be between 18-50")]
        public int Age { get; set; }
        [StringLength(10,ErrorMessage ="Address Lengtj shold be max 10")]
        public string Address { get; set; }
    }
}