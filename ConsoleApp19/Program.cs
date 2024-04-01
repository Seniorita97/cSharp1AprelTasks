using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Grades = new int[] {1, 4, 5, 6, 7, 8, 2 };
            student.FilteredGrades();
        }

    }
}
