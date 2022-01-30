using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComUtility.Form
{
    class Label : Parts
    {
        public System.Windows.Forms.Label m_label { get; set; }

        public Label(System.Windows.Forms.Label label)
        {
            m_label = label;
        }
    }
}
