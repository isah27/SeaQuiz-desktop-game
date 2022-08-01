using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApplication
{
    public class Questions
    {
        int questionId;
        string question;
        string optionA;
        string optionB;
        string optionC;
        string answer;
        int qCategory;
        int qType;

        public Questions(int id, string qn, string A, string B,string C,string ans, int c, int a)
        {
            questionId = id;
            question = qn;
            optionA = A;
            optionB = B;
            optionC = C;
            answer = ans;
            qCategory = c;
            qType = a;
        }

        public int QuestionId { get => questionId; set => questionId = value; }
        public string Question { get => question; set => question = value; }
        public string OptionA { get => optionA; set => optionA = value; }
        public string OptionB { get => optionB; set => optionB = value; }
        public string OptionC { get => optionC; set => optionC = value; }
        public string Answer { get => answer; set => answer = value; }
        public int QCategory { get => qCategory; set => qCategory = value; }
        public int QType { get => qType; set => qType = value; }
    }
}
