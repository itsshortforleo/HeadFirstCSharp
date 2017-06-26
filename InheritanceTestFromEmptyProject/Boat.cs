using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTest
{
    class Boat
    {
        private int length;

        public int GetLength()
        {
            return length;
        }

        public void SetLength(int len)
        {
            length = len;
        }
        public virtual string move()
        {
            return "drift ";
        }
    }
}
