using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Controller;
using WindowsFormsApp1.Controller.MixStr;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            MixStrInitialize();
        }

        private void HelloWorldBtnClick(object sender, EventArgs e)
        {
            HelloWorldLabel.Text = "Hello world";
        }

        private void HelloWorldBtnKeyUp(object sender, KeyEventArgs e)
        {            
            Console.Out.WriteLine(e.KeyCode.ToString());
        }

        private void HimitsuBoxDrop(object sender, DragEventArgs e)
        {
            FileDropTest.Drop(sender, e);
        }

        private void HimitsuBoxDragEnter(object sender, DragEventArgs e)
        {
            FileDropTest.EnterDropSpace(sender, e);
        }

        private void SquareParamY_TextChanged(object sender, EventArgs e)
        {
            SquareCalculator.UpdateText(this.SquareParamX, this.SquareParamY, this.SquareCalcResult);
        }

        private void SquareParamX_TextChanged(object sender, EventArgs e)
        {
            SquareCalculator.UpdateText(this.SquareParamX, this.SquareParamY, this.SquareCalcResult);
        }

        private void MixStrInitialize()
        {
            MixStrController.Update(this.mixStrElem1, this.mixStrElem2, this.mixStrResult);
        }
        private void MixStrUpdate(object sender, EventArgs e)
        {
            MixStrController.Update(this.mixStrElem1, this.mixStrElem2, this.mixStrResult);
        }
    }
}
