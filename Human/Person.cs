using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    class Person
    {
        private string name;
        private string id;
        protected int age;

        public Person(){ }
        public Person(string name, string id, int age)
        {
            this.name = name;
            this.id = id;
            this.age = age;
        }
        public string Name {
            set { this.name = value; }
            get { return name; }
        }
        public string ID {
            set { this.id = value; }
            get { return id; }
        }
        public int Age {
            set { this.age = value; }
            get { return age; }
        }

    }
}
