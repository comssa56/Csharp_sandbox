using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    class Square
    {
        private readonly int x;
        private readonly int y;
        public Square(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public long area()
        {
            return x * (long)y;
        }
    }
}
