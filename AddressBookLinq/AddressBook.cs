using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookLinq
{
    /// <summary>
    /// Created The Class To Declare Properties(UC1)
    /// </summary>
    public class AddressBook
    {
        //Declare properties(UC1)
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public long PhoneNumber { get; set; }
        public int ZipCode { get; set; }
        public string EmailId { get; set; }
    }
}
