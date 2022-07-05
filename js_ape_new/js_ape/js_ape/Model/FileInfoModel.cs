using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace js_ape.Model
{
    /// <summary>
    /// 文件数据实体类
    /// </summary>
    class FileInfoModel
    {
        //private string term;//学期
        //private string dep;//系别
        //private string classname;//班级
        private string course;//课程
        private string teachername;//教师
        private string beginweek; // 开始周
        private string overweek;//结束周
        private string weekclass; // 周学时
        private string notes;//备注

        public FileInfoModel()
        {

        }

        public FileInfoModel(string course, string teachername, string beginweek, string overweek, string weekclass, string notes)
        {
            this.Course = course;
            this.Teachername = teachername;
            this.Beginweek = beginweek;
            this.Overweek = overweek;
            this.Weekclass = weekclass;
            this.Notes = notes;
        }

        public string Course { get => course; set => course = value; }
        public string Teachername { get => teachername; set => teachername = value; }
        public string Beginweek { get => beginweek; set => beginweek = value; }
        public string Overweek { get => overweek; set => overweek = value; }
        public string Weekclass { get => weekclass; set => weekclass = value; }
        public string Notes { get => notes; set => notes = value; }

        public override bool Equals(object obj)
        {
            return obj is FileInfoModel model &&
                   course == model.course &&
                   teachername == model.teachername &&
                   beginweek == model.beginweek &&
                   overweek == model.overweek &&
                   weekclass == model.weekclass &&
                   notes == model.notes;
        }

        public override int GetHashCode()
        {
            int hashCode = 235012816;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(course);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(teachername);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(beginweek);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(overweek);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(weekclass);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(notes);
            return hashCode;
        }
    }
}
