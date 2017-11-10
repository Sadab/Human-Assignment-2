using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    class Instructor:Person
    {
        private double salary;

        public Instructor(){ }
        public Instructor(double salary) { this.salary = salary; }
        
        public double Salary {
            set { this.salary = value; }
            get { return salary; }
        }
    }
}
