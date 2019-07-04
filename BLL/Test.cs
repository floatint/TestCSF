using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Test
    {
        public List<Question> Questions;
        public string Name;
        public string FailMessage;
        public string PassMessage;
        public double FailScore;
        public double PassScore;
        public string FailEvaluation;
        public string PassEvaluation;
        public double QuestionTime; // in sec

        public Test(string name)
        {
            Name = name;
            Questions = new List<Question>();
        }
    }
}
