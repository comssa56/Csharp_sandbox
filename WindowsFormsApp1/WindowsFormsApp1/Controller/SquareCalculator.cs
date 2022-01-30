using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model;
using WindowsFormsApp1.View;

namespace WindowsFormsApp1.Controller
{
    class SquareCalculator
    {

        private static Color GetTextColor(bool is_valid)
        {
            return is_valid ? Color.White : Color.Red;
        }

        public static void UpdateText(TextBox textX, TextBox textY, Label result)
        {
            var param = new SquareFormParam(textX.Text, textY.Text);

            string r = "???";
            if(param.IsParamXValid() && param.IsParamYValid())
            {
                var square = new Square(param.GetXAsInt(), param.GetYAsInt());
                r = square.area().ToString();
            }

            SquareCalculatorView.UpdateView(textX, textY, result, 
                textX.Text, textY.Text, r,
                GetTextColor(param.IsParamXValid()), GetTextColor(param.IsParamYValid())
                );
        }

    }
}
