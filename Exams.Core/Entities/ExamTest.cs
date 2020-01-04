using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exams.Core.Entities
{
    public class ExamTest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ExamCategories> Categories { get; set; }
    }
}
