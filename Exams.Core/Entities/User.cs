using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exams.Core.Entities
{
    public class User : IdentityUser
    {       
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsAdmin { get; set; }
        public UserAccess UserAccessRights { get; set; }
        public bool IsPaid { get; set; }
    }
}
