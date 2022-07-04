using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using js_ape.Utils;
using js_ape.Model;

namespace js_ape.BLL
{
    class Main_BLL
    {
        /// <summary>
        /// 将Excel表格数据进行处理
        /// </summary>
        public void DataProcessing(string path)
        {
            List<DataTable> DtList = GetAllSheet(path);
            
        }

        /// <summary>
        /// 得到所有符合规范的表，并转换成datatable，返回集合
        /// </summary>
        /// <param name="path">文件路径</param>
        /// <returns></returns>
        private List<DataTable> GetAllSheet(string path)
        {
            List<string> sheetName = new List<string>();
            string strCon = $@"Provider = Microsoft.Jet.OLEDB.4.0;Extended Properties=Excel 8.0;Data Source ={path}";
            OleDbConnection conn = new OleDbConnection(strCon);
            conn.Open();
            //获取所有表名
            DataTable Tables = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
            for (int i = 0; i < Tables.Rows.Count; i++)
            {
                string sheetname = Tables.Rows[i]["Table_Name"].ToString();
                sheetname = sheetname.Substring(0, sheetname.Length - 1);
                sheetName.Add(sheetname);
            }
            conn.Close();
            conn.Dispose();

            List<DataTable> list = new List<DataTable>();
            foreach (string sname in sheetName) //循环 所有表
            {
                if (!sname.Contains("系"))
                {
                    continue;
                }
                DataTable dt = ExcelHelper.ExcelToDataTable(path, sname, false);
                list.Add(dt);//将所有表添加到集合里
            }
            return list;
        }

        /// <summary>
        /// 将表数据封装到实体类
        /// </summary>
        private List<FileInfo> DisposalData(List<DataTable> dtlist)
        {
            List<FileInfo> InfoList = new List<FileInfo>();
            foreach (DataTable dt in dtlist)
            {
                string term = string.Empty;//学期
                string dep = string.Empty;//系别
                string classname = string.Empty;//班级
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    //获取学期
                    if (dt.Rows[i][0].ToString().Contains("学期") && dt.Rows[i][0].ToString().Contains("中山市技师学院"))
                    {
                        term = dt.Rows[i][0].ToString();
                        continue;
                    }
                    //获取系别
                    if (dt.Rows[i][0].ToString().Contains("系"))
                    {
                        dep = dt.Rows[i][0].ToString();
                        continue;
                    }
                    if (dt.Rows[i][0] == DBNull.Value)
                    {
                        continue;
                    }
                    if (dt.Rows[i][0].ToString() != "班级")
                    {
                        continue;
                    }
                    //读到班级
                    //处理左边
                    for (int j = i; j < dt.Rows.Count; j++)
                    {
                        //结束
                        if (dt.Rows[j][0].ToString() == "班级" || j == dt.Rows.Count)
                            break;
                        //获取班级
                        classname = dt.Rows[i + 1][0].ToString();
                        if (dt.Rows[j][1].ToString() != "" && dt.Rows[j][3].ToString() != "")
                        {
                            FileInfo fileInfo = new FileInfo();
                            fileInfo.Term = term;
                            fileInfo.Dep = dep;
                            fileInfo.Classname = classname;
                            fileInfo.Course = dt.Rows[j][1].ToString();
                            fileInfo.Teachername = dt.Rows[j][2].ToString();
                            fileInfo.Weekclass = dt.Rows[j][3].ToString();
                            fileInfo = mksf(fileInfo);//格式化实体类数据
                        }
                    }
                    //处理右边
                    for (int j = i; j < dt.Rows.Count; j++)
                    {
                        //结束
                        if (dt.Rows[j][6].ToString() == "班级" || j == dt.Rows.Count)
                            break;
                        //获取班级
                        classname = dt.Rows[i + 1][6].ToString();
                        if (dt.Rows[j][7].ToString() != "" && dt.Rows[j][9].ToString() != "")
                        {
                            FileInfo fileInfo = new FileInfo();
                            fileInfo.Term = term;
                            fileInfo.Dep = dep;
                            fileInfo.Classname = classname;
                            fileInfo.Course = dt.Rows[j][7].ToString();
                            fileInfo.Teachername = dt.Rows[j][8].ToString();
                            fileInfo.Weekclass = dt.Rows[j][9].ToString();
                            fileInfo = mksf(fileInfo);//格式化实体类数据
                        }
                    }
                }
            }


            return InfoList;
        }


        private FileInfo mksf(FileInfo fileInfo)
        {
            if (fileInfo.Classname != "" && fileInfo.Classname != null)
                fileInfo.Classname = fileInfo.Classname.Replace("\n", "").Replace("\t", "").Replace("\r", "");
            if (fileInfo.Teachername != "" && fileInfo.Teachername != null)
                fileInfo.Teachername = fileInfo.Teachername.Replace("\n", "").Replace("\t", "").Replace("\r", "");
            if (fileInfo.Course != "" && fileInfo.Course != null)
                fileInfo.Course = fileInfo.Course.Replace("\n", "").Replace("\t", "").Replace("\r", "");
            if (fileInfo.Weekclass != "" && fileInfo.Weekclass != null)
                fileInfo.Weekclass = fileInfo.Weekclass.Replace("\n", "").Replace("\t", "").Replace("\r", "");
            if (fileInfo.Dep != "" && fileInfo.Dep != null)
                fileInfo.Dep = fileInfo.Dep.Replace("\n", "").Replace("\t", "").Replace("\r", "");
            if (fileInfo.Term != "" && fileInfo.Term != null)
                fileInfo.Term = fileInfo.Term.Replace("\n", "").Replace("\t", "").Replace("\r", "");
            return fileInfo;
        }

    }
}
