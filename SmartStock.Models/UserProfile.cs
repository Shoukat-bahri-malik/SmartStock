using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartStock.Models
{
    public class UserProfile
    {
        public int UserProfileId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string ConfirmPassword { get; set; } = string.Empty;
        public string OldPassword { get; set; } = string.Empty;
        public string ProfilePicture { get; set; } = string.Empty;
        public string AppUserId { get; set; } = string.Empty;

    }
}
