﻿using Microsoft.AspNetCore.Identity;

namespace AppIdentity.Models
{
    public class AppUser:IdentityUser
    {

        public string FistName { get; set; }
        public string LastName { get; set; }

    }
}
