using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComUtility
{
    class Debug
    {

        /// <summary>
        /// カスタムAssert
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        /// <param name="line"></param>
        /// <param name="name"></param>
        /// <param name="path"></param>
        [ConditionalAttribute("DEBUG")]
        public static void Assert<T>(T lhs, T rhs,
                             [CallerLineNumber]int line = 0,
                             [CallerMemberName]string name = "",
                             [CallerFilePath]string path = "")
            where T : IComparable
        {
            if (lhs.CompareTo(rhs) != 0)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("Assertion Failed:");
                sb.Append(lhs.ToString() + " and " + rhs.ToString() + "\n");
                sb.Append("file:" + path + "\n");
                sb.Append("name:" + name + "\n");
                sb.Append("line:" + line + "\n");
                MessageBox.Show(sb.ToString(), "Assertion Failed", MessageBoxButtons.OK);
                System.Diagnostics.Debug.Assert(false);

                // 保険のdebug break
                System.Diagnostics.Debugger.Break(); // 
            }
        }

        // TODO: きっちりしたロガーつくる 
        [ConditionalAttribute("DEBUG")]
        public static void WriteLog(string text)
        {
            Console.WriteLine(text);
        }
    }
}
