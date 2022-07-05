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
        public Dictionary<ClassInfo, List<FileInfoModel>> DataProcessing(string path)
        {
            Dictionary<ClassInfo, List<FileInfoModel>> dic = DisposalData(GetAllSheet(path));
            //foreach (var item in fileInfos)
            //{
            //    Console.WriteLine(item.Term + "\t" + item.Dep + "\t" + item.Classname + "\t" + item.Course + "\t" + item.Notes);
            //    Console.WriteLine("----------------------");
            //}
            return dic;
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
        private Dictionary<ClassInfo, List<FileInfoModel>> DisposalData(List<DataTable> dtlist)
        {
            Dictionary<ClassInfo, List<FileInfoModel>> dic = new Dictionary<ClassInfo, List<FileInfoModel>>();
            foreach (DataTable dt in dtlist)
            {
                string term = string.Empty;//学期
                string dep = string.Empty;//系别
                //string classname = string.Empty;//班级
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
                        continue;
                    if (dt.Rows[i][0].ToString() != "班级")
                        continue;
                    //读到班级
                    //处理左边
                    ClassInfo classInfo_left = new ClassInfo();
                    classInfo_left.Term = term;
                    classInfo_left.Dep = dep;
                    classInfo_left.Classname = dt.Rows[i + 1][0].ToString();//获取班级
                    if (!classInfo_left.Classname.Contains('班'))
                        continue;
                    classInfo_left = mksfclassInfo(classInfo_left);
                    List<FileInfoModel> InfoList_left = new List<FileInfoModel>();
                    for (int j = i + 1; j < dt.Rows.Count; j++)
                    {
                        //结束
                        if (dt.Rows[j][0].ToString() == "班级" || j == dt.Rows.Count)
                            break;
                        if (dt.Rows[j][1].ToString() != "" && dt.Rows[j][3].ToString() != "")
                        {
                            FileInfoModel fileInfo = new FileInfoModel();
                            fileInfo.Course = dt.Rows[j][1].ToString();
                            fileInfo.Teachername = dt.Rows[j][2].ToString();
                            fileInfo.Weekclass = dt.Rows[j][3].ToString();
                            fileInfo.Notes = dt.Rows[j][4].ToString();
                            fileInfo = mksf(fileInfo);//格式化实体类数据
                            InfoList_left.Add(fileInfo);
                        }
                    }
                    dic.Add(classInfo_left, InfoList_left);

                    //处理右边
                    ClassInfo classInfo_right = new ClassInfo();
                    classInfo_right.Term = term;
                    classInfo_right.Dep = dep;
                    classInfo_right.Classname = dt.Rows[i + 1][6].ToString();//获取班级
                    if (!classInfo_right.Classname.Contains('班'))
                        continue;
                    classInfo_right = mksfclassInfo(classInfo_right);
                    List<FileInfoModel> InfoList_right = new List<FileInfoModel>();
                    for (int j = i + 1; j < dt.Rows.Count; j++)
                    {
                        //结束
                        if (dt.Rows[j][6].ToString() == "班级" || j == dt.Rows.Count)
                            break;
                        if (dt.Rows[j][7].ToString() != "" && dt.Rows[j][9].ToString() != "")
                        {
                            FileInfoModel fileInfo = new FileInfoModel();
                            fileInfo.Course = dt.Rows[j][7].ToString();
                            fileInfo.Teachername = dt.Rows[j][8].ToString();
                            fileInfo.Weekclass = dt.Rows[j][9].ToString();
                            fileInfo.Notes = dt.Rows[j][10].ToString();
                            fileInfo = mksf(fileInfo);//格式化实体类数据
                            InfoList_right.Add(fileInfo);
                        }
                    }
                    dic.Add(classInfo_right, InfoList_right);
                }
            }
            return dic;
        }

        /// <summary>
        /// 格式化数据
        /// </summary>
        /// <param name="fileInfo"></param>
        /// <returns></returns>
        private FileInfoModel mksf(FileInfoModel fileInfo)
        {
            //课程
            if (fileInfo.Course != "" && fileInfo.Course != null)
                fileInfo.Course = Utility.CutSL(fileInfo.Course);
            //教师
            if (fileInfo.Teachername != "" && fileInfo.Teachername != null)
                fileInfo.Teachername = Utility.CutSL(fileInfo.Teachername);
            //周学时
            if (fileInfo.Weekclass != "" && fileInfo.Weekclass != null)
                fileInfo.Weekclass = Utility.CutSL(fileInfo.Weekclass);
            //备注
            if (fileInfo.Notes != "" && fileInfo.Notes != null)
                fileInfo.Notes = MksfNotes(fileInfo.Notes);
            return fileInfo;
        }

        private ClassInfo mksfclassInfo(ClassInfo classInfo)
        {
            if (classInfo.Term != "" && classInfo.Term != null)
                classInfo.Term = MksfTerm(classInfo.Term);
            if (classInfo.Dep != "" && classInfo.Dep != null)
                classInfo.Dep = Utility.CutSL(classInfo.Dep);
            if (classInfo.Classname != "" && classInfo.Classname != null)
                classInfo.Classname = MksfClassName(classInfo.Classname);
            return classInfo;
        }

        /// <summary>
        /// 处理学期
        /// </summary>
        /// <param name="str">学期</param>
        /// <returns></returns>
        private string MksfTerm(string str)
        {
            str = Utility.CutSL(str).Substring(7, 15);
            return str;
        }
        /// <summary>
        /// 处理班级
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private string MksfClassName(string str)
        {
            str = Utility.CutSL(str);
            int index = str.IndexOf('班', 1);
            str = str.Substring(0, index);
            return str;
        }
        /// <summary>
        /// 处理备注
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private string MksfNotes(string str)
        {
            str = Utility.CutSL(str);
            if (!(str.Contains('周') || str.Contains('-')))
                return "";
            return str;
        }

    }
}
