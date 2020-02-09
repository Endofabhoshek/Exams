using System;
using Exams.ServiceInterfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exams.Core.Entities
{
    public class Question : IModel
    {
        public int Id { get; set; }
        public string ActualQuestion { get; set; }
        public bool IsMCQ { get; set; }
        public string TextAnswer { get; set; }
        public MCQOptions MCQAnswer { get; set; } // how database does it?        
        public int MCQOptionsId { get; set; } 
    }
}
