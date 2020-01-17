using System;
using Exams.ServiceInterfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exams.Core.Entities
{
    
    public class Instructions : IModel
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
