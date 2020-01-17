using System;
using Exams.ServiceInterfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exams.Core.Entities
{
    public class MCQOptions : IModel
    {
        public int Id { get; set; }
        public string Key { get; set; }
        public string Option { get; set; }
    }
}
