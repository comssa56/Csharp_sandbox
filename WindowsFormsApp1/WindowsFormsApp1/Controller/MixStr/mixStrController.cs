using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model.MixStr;

namespace WindowsFormsApp1.Controller.MixStr
{
    class MixStrController
    {
        public static void Update(TextBox text1, TextBox text2, Label resultLabel)
        {
            var elem1 = new MixStrElem( text1 );
            var elem2 = new MixStrElem( text2 );
            var result = new MixStrResult(elem1, elem2);

            MixStrView.UpdateView(
                text1, text2, resultLabel,
                result.GetMixStr(), elem1.GetExpectedColor(), elem2.GetExpectedColor()
            );
        }


    }
}
