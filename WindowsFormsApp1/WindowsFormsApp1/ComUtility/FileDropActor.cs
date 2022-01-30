using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComUtility
{
    /// <summary>
    /// フォーム用
    /// ファイルのドラッグアンドドロップのヘルパー
    /// </summary>
    class FileDropActor
    {
        public static void Drop(DragEventArgs e, Action<string> action)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] fileNames = (string[])e.Data.GetData(DataFormats.FileDrop, false);
                var files = new List<string>(fileNames);
                files.ForEach(f =>{action(f);});
            }
        }

        public static void EnterDropSpace(DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
    }
}
