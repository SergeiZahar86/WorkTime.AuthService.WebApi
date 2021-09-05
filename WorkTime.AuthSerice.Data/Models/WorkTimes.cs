using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace WorkTime.AuthSerice.Data.Models
{
    public class WorkTimes
    {
        public Guid Id { get; set; }
        [Required]
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        [Required]
        public AppUser User { get; set; }
    }
}
