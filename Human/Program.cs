using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Faculty f1 = new Faculty();
            f1.Name = "William Sherlock Scott Holmes";
            f1.ID = "1111-1111-1";
            f1.Age = 30;
            f1.Salary = 10000;
            f1.RoomNo = 412;
            Student s1 = new Student();
            s1.Name = "John Hamish Watson";
            s1.ID = "11-11111-1";
            s1.Age = 24;
            s1.CGPA = 3.95;
            System.Console.WriteLine(s1.Name);
            System.Console.WriteLine(s1.ID);
            System.Console.WriteLine(s1.CGPA);
            System.Console.WriteLine(f1.Name);
            System.Console.WriteLine(f1.ID);
            System.Console.WriteLine(f1.Age);
            System.Console.WriteLine(f1.Salary);
            System.Console.WriteLine(f1.RoomNo);
        }
    }
}
