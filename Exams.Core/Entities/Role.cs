﻿using Exams.ServiceInterfaces;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exams.Core.Entities
{
    public class Role : IdentityRole<int, UserRole>, IModel
    {

    }
}
