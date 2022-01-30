using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model.MixStr;

namespace WindowsFormsApp1.Controller.MixStr
{
    class MixStrView
    {
        public static void UpdateView(
            TextBox text1, TextBox text2, Label result,
            string strResult, Color colorX, Color colorY
            )
        {
            text1.BackColor = colorX;
            text2.BackColor = colorY;
            result.Text = strResult;
        }
    }
}
