using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Model.MixStr
{
    class MixStrResult
    {
        private readonly MixStrElem m_elem1;
        private readonly MixStrElem m_elem2;

        public MixStrResult(MixStrElem elem1, MixStrElem elem2)
        {
            m_elem1 = elem1;
            m_elem2 = elem2;
        }

        public string GetMixStr()
        {
            var sb = new StringBuilder();
            sb.Append(m_elem1.GetMixStr());
            sb.Append(m_elem2.GetMixStr());
            return sb.ToString();
        }

    }
}
