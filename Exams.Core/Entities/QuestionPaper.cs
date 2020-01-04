using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exams.Core.Entities
{
    public class QuestionPaper
    {
        public int Id { get; set; }
        public string Name { get; set; } // branch name + 
        public Instructions Instruction { get; set; } // need to check kiske andar aayega
        public TimeSpan Duration { get; set; }
        public List<Question> Questions { get; set; }
        public bool IsSubmitted { get; set; }
        public bool IsFree { get; set; }
    }
}
