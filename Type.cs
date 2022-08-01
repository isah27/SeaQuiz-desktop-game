using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApplication
{
    public class Type
    {
        int questionId;
        string typeName;

        public Type(int id, string an)
        {
            questionId = id;
            typeName = an;

        }

        public int QuestionId { get => questionId; set => questionId = value; }
        public string TypeName { get => typeName; set => typeName = value; }
    }
}

