using ComUtility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Controller
{
    class FileDropTest
    {
        FileDropTest() { }

        public static void EnterDropSpace(object sender, DragEventArgs e)
        {
            FileDropActor.EnterDropSpace(e);
        }

        public static void Drop(object sender, DragEventArgs e)
        {
            Action yesAction = () => MessageBox.Show("Yes!!");
            Action noAction = () => MessageBox.Show("No!!");

            FileDropActor.Drop(e, 
                f => {
                    Dialog.ShowYesNo("hakken!!", f, yesAction, noAction);
                }
            );
        }

    }
}
