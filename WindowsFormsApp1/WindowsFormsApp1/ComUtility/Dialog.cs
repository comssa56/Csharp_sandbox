using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComUtility
{
    /// <summary>
    /// ダイアログのヘルパー
    /// </summary>
    class Dialog
    {
        public static void ShowYesNo(string title, string msg, Action yesAction, Action noAction)
        {
            var result = MessageBox.Show(msg, title, MessageBoxButtons.YesNoCancel);
            switch (result)
            {
            case DialogResult.Yes:
                yesAction();
                break;
            case DialogResult.No:
                noAction();
                break;
            default:
                MessageBox.Show("Unhandling MessageBox result:" + result.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                break;
            }
        }

    }
}
