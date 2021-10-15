using LMS.WEB.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.WEB.Models
{
    public partial class User : BaseEntity
    {
       
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PassportNumber { get; set; }

        public DateTime RegistrationDate { get; set; }

        public DateTime DOB { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }
       

    }
}
