using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace js_ape.Utils
{
    public class Utility
    {
        [DllImport("kernel32.dll")]
        public static extern IntPtr _lopen(string lpPathName, int iReadWrite);

        [DllImport("kernel32.dll")]
        public static extern bool CloseHandle(IntPtr hObject);
        public const int OF_READWRITE = 2;
        public const int OF_SHARE_DENY_NONE = 0x40;
        public static readonly IntPtr HFILE_ERROR = new IntPtr(-1);
        /// <summary>
        /// 判断是否是Excel文件
        /// 如果是则返回true,反之返回false
        /// </summary>
        /// <param name="extension"></param>
        /// <returns></returns>
        public static bool IsExcelFile(string FileName)
        {
            if (FileName.IndexOf(".xlsx") > 0)
                return true;
            else if (FileName.IndexOf(".xls") > 0)
                return true;
            else if (FileName.IndexOf(".csv") > 0)
                return true;
            return false;
        }

        /// <summary>
        /// 文件是否被打开
        /// 打开返回true,反之false
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static bool IsFileOpen(string path)
        {
            if (!File.Exists(path))
            {
                return false;
            }
            IntPtr vHandle = _lopen(path, OF_READWRITE | OF_SHARE_DENY_NONE);//windows Api上面有定义扩展方法
            if (vHandle == HFILE_ERROR)
            {
                return true;
            }
            CloseHandle(vHandle);
            return false;
        }

        /// <summary>
        /// 去除字符串换行、空格等
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string CutSL(string str)
        {
            str = str.Replace("\n", "").Replace("\t", "").Replace("\r", "").Replace(" ","");
            return str;
        }


    }
}
