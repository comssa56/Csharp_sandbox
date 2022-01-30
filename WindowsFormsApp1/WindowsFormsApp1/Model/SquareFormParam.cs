using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    class SquareFormParam
    {
        private readonly string x;
        private readonly string y;

        public SquareFormParam(string x, string y)
        {
            this.x = x;
            this.y = y;
        }

        private int GetParamAsInt(string str)
        {
            int v = 0;
            int.TryParse(str, out v);
            return v;
        }

        private bool IsIntNumberString(string str)
        {
            int v = 0;
            return int.TryParse(str, out v);
        }

        public bool IsParamXValid() { return IsIntNumberString(this.x); }
        public bool IsParamYValid() { return IsIntNumberString(this.y); }

        public int GetXAsInt() { return GetParamAsInt(this.x); }
        public int GetYAsInt() { return GetParamAsInt(this.y); }

    }
}
