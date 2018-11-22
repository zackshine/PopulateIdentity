using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PopulateIdentity.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirsrName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }
    }
}
