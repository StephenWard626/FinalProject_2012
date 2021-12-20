using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject_0512.Models
{
    public class Users
    {
        [Key]
        public int UserID { get; set; }
        [DisplayName("Username")]
        [Required]
        public string Username { get; set; }
        [DisplayName("First Name")]
        [Required]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [DisplayName("Email Address")]
        [DataType(DataType.EmailAddress)]
        [Required]
        public string EmailAdd { get; set; }
        [DisplayName("Admin Accounnt?")]
        public bool AdminAcc { get; set; }
        [DisplayName("Premium Account?")]
        public bool PremiumAcc { get; set; }
    }

    public class AdminUsers : Users
    {
        [DisplayName("Password")]
        [Required]
        public string UserPassword { get; set; }
    }

}
