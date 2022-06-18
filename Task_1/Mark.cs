using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Mark
    {
        public int ID { get; set; }
        public int StudentID { get; set; }
        public string SubjectName { get; set; }
        public int Value { get; set; }
        public Mark(int id, int studentID, string subjectName, int value)
        {
            ID = id;
            StudentID = studentID;
            SubjectName = subjectName;
            Value = value;
        }
    }
}
