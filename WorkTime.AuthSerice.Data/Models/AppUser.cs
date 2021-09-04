using Microsoft.AspNetCore.Identity;
using System;

namespace WorkTime.AuthSerice.Data.Models
{
    public class AppUser : IdentityUser<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
