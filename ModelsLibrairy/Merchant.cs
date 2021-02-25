using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace ModelsLibrairy
{
    public class Merchant : Model
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }
        public Shop Shop { get; set; }
        public List<Order> Orders { get; set; }
        public IdentityUser IdentityUser { get; set; }
    }
}
