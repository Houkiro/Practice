using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_1;

namespace Task_1
{
    internal class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Student(int id, string name)
        {
            ID = id;
            Name = name;
        }
        public int[] Marks{ get; set; }
        public double GetAvgMark() => Marks.Average(x => x);
        public void ResetAllMarks()
        {
            int [] zero = { 0 };
            Marks = zero;
        }
        public void SetMark(List<Mark> mks)
        {
            List<int> value = new();
            for (int i = 0; i < mks.Count; i++)
            {
                if (ID == mks[i].StudentID)
                    value.Add(mks[i].Value);
            }
            Marks = value.ToArray();
        }
    }
}
