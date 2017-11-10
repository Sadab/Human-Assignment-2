using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    class Student:Person
    {
        private double cgpa;
        public Student() { }
        public Student(double cgpa) { this.cgpa = cgpa; }
        
        public double CGPA {
            set { this.cgpa = value; }
            get { return cgpa; }
        }
    }
}
