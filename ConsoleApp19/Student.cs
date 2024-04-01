using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class Student
    {
        public int[] Grades;


        public void FilteredGrades()
        {
            int count = 0;
            foreach(int grade in Grades)
            {
                if(grade % 2 == 0)
                {
                    count++;
                }
            }

            int[] filteredGrades = new int[count];
            int i = 0;
            foreach (int grade in Grades)
            {
               if( grade % 2 == 0)
                {
                    filteredGrades[i++] = grade;
                }
            }

            foreach (int grade in filteredGrades)
            {
                Console.WriteLine(grade);
            }
        }

        public Student() 
        {
        }

    }
}
