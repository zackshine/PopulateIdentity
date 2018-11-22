using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PopulateIdentity.Models
{
    public class Address
    {
        public int ID { get; set; }
        public string StreetAddress1 { get; set; }
        public string StreetAddress2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public string ApplicationUserId { get; set; }
        public ApplicationUser User { get; set; }

    }
}
