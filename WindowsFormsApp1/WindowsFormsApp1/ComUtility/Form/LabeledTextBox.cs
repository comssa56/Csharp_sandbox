using ComUtility.Form;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComUtility.Form
{

    class LabeledTextBox : Parts, IInput
    {
        public TextBox m_textBox;
        public Label m_label;

        public LabeledTextBox(TextBox textBox, Label label)
        {
            m_textBox = textBox;
            m_label = label;
        }

        public bool IsInputValid()
        {
            return m_textBox.IsInputValid(); 
        }

    }

  
}
