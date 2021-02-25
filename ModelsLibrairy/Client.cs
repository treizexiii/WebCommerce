using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ModelsLibrairy
{
    public class Client : Model
    {
        public string FirstName { get; set; }
        public int LastName { get; set; }
        [Phone]
        public int Tel { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string Adress { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<Review> Views { get; set; }
        public IdentityUser IdentityUser { get; set; }
    }
}
