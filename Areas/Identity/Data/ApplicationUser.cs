using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace SocialMVCIdentityFinal.Areas.Identity.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    public string firstName  { get; set; }
    public string middleName { get; set; }
    public string lastName { get; set; }
    public string userPhone { get; set; }
    public string userAddress { get; set; }
    public string userJob { get; set; }
    public string userSex { get; set; }

}


