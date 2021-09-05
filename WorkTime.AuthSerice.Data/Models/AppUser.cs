using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace WorkTime.AuthSerice.Data.Models
{
    public class AppUser : IdentityUser<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<WorkTimes> WorkTimeList { get; set; }
    }
}
