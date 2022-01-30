using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Model.MixStr
{
    class MixStrElem 
    {
        public readonly int MAX_STR_LEN = 4;
        public readonly int MIN_STR_LEN = 1;
        private TextBox m_textBox;

        public MixStrElem(TextBox textBox)
        {
            m_textBox = textBox;
        }

        public bool IsInputValid()
        {
            var len = m_textBox.Text.Length;
            return MIN_STR_LEN <= len && len <= MAX_STR_LEN;
        }

        public string GetMixStr()
        {
            return IsInputValid() ? m_textBox.Text : "";
        }

        public Color GetExpectedColor()
        {
            return IsInputValid() ? Color.White : Color.Pink;
        }
    }
}

