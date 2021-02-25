using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace ModelsLibrairy
{
    public class Client : Model
    {
        public string FirstName { get; set; }
        public int LastName { get; set; }
        public int Tel { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }
        public ICollection<Order> Orders { get; set; }
        public IdentityUser IdentityUser { get; set; }
    }
}
