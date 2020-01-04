using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exams.Core.Entities
{
    public class ExamCategories
    {
        public int Id { get; set; }
        public string Name { get; set; } // Branch Name
        public List<QuestionPaper> QuestionPapers { get; set; }
        public float CategoryPrice { get; set; }
    }
}
