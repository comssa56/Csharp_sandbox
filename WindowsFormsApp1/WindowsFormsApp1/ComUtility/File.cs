using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComUtility
{
    class File
    {
        /// 使用者がファイルへの入出力に集中できるように実装した関数群をもつ
        /// 使用者はリソースの解放については考えなくてよい

        /// <summary>
        /// 書き込み専用FSへの操作を行う
        /// ファイルは新規作成される
        /// </summary>
        /// <param name="filepath"></param>
        /// <param name="func"></param>
        /// <returns>書き込みに成功したか</returns>
        public static bool Write(string filepath, Func<System.IO.FileStream, bool> func)
        {
            try
            {
                using (var fs = System.IO.File.Create(filepath))
                {
                    if(func(fs))
                    {
                        fs.Flush();
                        return true;
                    }
                }
            }
            catch (Exception e)
            {
                Debug.WriteLog(e.ToString());
            }
            return false;
        }

        /// <summary>
        /// StreamWriterによるファイルへの新規書き込みを行う
        /// </summary>
        /// <param name="filepath"></param>
        /// <param name="func"></param>
        /// <returns>書き込みに成功したか</returns>
        public static bool WriteByWriter(string filepath, Func<System.IO.StreamWriter, bool> func)
        {
            bool f(System.IO.FileStream fs)
            {
                using (var sw = new System.IO.StreamWriter(fs))
                {
                    return func(sw);
                }
            }

            return Write(filepath, f);
        }
        
        /// <summary>
        /// StreamWriterによるファイルへの追加書き込みを行う。
        /// </summary>
        /// <param name="filepath"></param>
        /// <param name="func"></param>
        /// <returns></returns>
        public static bool AppendByWriter(string filepath, Func<System.IO.StreamWriter, bool> func)
        {
            try
            {
                using (var sw = System.IO.File.AppendText(filepath))
                {
                    if( func(sw) )
                    {
                        sw.Flush();
                        return true;
                    }
                }
            }
            catch (Exception e)
            {
                Debug.WriteLog(e.ToString());
            }
            return false;
        }

        /// <summary>
        /// 読み込み専用FSへの操作を行う
        /// </summary>
        /// <param name="filepath"></param>
        /// <param name="func"></param>
        /// <returns>読み込みに成功したか</returns>
        public static bool Read(string filepath, Func<System.IO.FileStream, bool> func)
        {
            try
            {
                using (var fs = System.IO.File.OpenRead(filepath))
                {
                    return func(fs);
                }
            }
            catch (Exception e)
            {
                Debug.WriteLog(e.ToString());
                return false;
            }
        }

        /// <summary>
        /// StreamReaderによるファイルへの追加書き込みを行う。
        /// </summary>
        /// <param name="filepath"></param>
        /// <param name="func"></param>
        /// <returns>読み込みに成功したか</returns>
        public static bool ReadByReader(string filepath, Func<System.IO.StreamReader, bool> func)
        {
            bool f(System.IO.FileStream fs)
            {
                using (var sr = new System.IO.StreamReader(fs))
                {
                    return func(sr);
                }
            }

            return Read(filepath, f);
        }


    }


}
