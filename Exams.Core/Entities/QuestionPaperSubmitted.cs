using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exams.ServiceInterfaces;

namespace Exams.Core.Entities
{
    public class QuestionPaperSubmitted : IModel
    {
        public int Id { get; set; }
        public QuestionPaper QuestionPaper { get; set; }
        public int QuestionPaperId { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
    }
}
