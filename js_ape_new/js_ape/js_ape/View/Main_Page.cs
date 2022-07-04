using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using js_ape.Utils;
using js_ape.BLL;


namespace js_ape
{
    public partial class Main_Page : Form
    {
        public Main_Page()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 上传文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_send_File_Click(object sender, EventArgs e)
        {
            ofd_Excel.Title = "请打开符合格式的Excel文件";//标题
            ofd_Excel.Filter = "所有文件(*.*)|*.*|Excel文件(*.xls)|*.xls|Excel文件(*.xlsx)|*.xlsx";//设置打开文件类型
            if (ofd_Excel.ShowDialog() != DialogResult.OK)//判断是否选择文件
                return;
            string FileName = ofd_Excel.FileName;
            if (!Utility.IsExcelFile(FileName))//不为Excel文件
            {
                MessageBox.Show("请选择Excel文件！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string FilePath = Path.GetFullPath(FileName);
            if (Utility.IsFileOpen(FilePath))//判断文件是否已经打开 
            {
                MessageBox.Show("该文件已打开！请关闭！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Main_BLL bll = new Main_BLL();
            bll.DataProcessing(FilePath);

        }
    }
}
