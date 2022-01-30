using ComUtility.Form;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComUtility.Form
{

    class TextBox : Parts, IInput
    {
        public System.Windows.Forms.TextBox m_textBox;
        protected readonly int m_maxCharNum;

        public TextBox(System.Windows.Forms.TextBox textBox, int maxCharNum = 1024)
        {
            m_textBox = textBox;
            m_maxCharNum = maxCharNum;
        }

        public bool IsInputValid()
        {
            return m_textBox.Text.Length <= m_maxCharNum; 
        }
    }


}
