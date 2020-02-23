using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exams.ServiceInterfaces;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Exams.Core.Entities
{
    public class UserRole : IdentityUserRole<int>, IModel
    {
        public int Id { get ; set ; }
    }
}
