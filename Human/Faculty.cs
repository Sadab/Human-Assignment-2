using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    class Faculty:Instructor
    {
        private int roomNo;
        public Faculty() { }
        public Faculty(int roomNo) { this.roomNo = roomNo; }
        public int RoomNo {
            set { this.roomNo = value; }
            get { return roomNo; }
        }
    }
}
