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
    class FileInfo
    {
        private string term;//学期
        private string dep;//系别
        private string classname;//班级
        private string course;//课程
        private string teachername;//教师
        private string beginweek; // 开始周
        private string overweek;//结束周
        private string weekclass; // 周课时

        public FileInfo()
        {

        }
        public FileInfo(string term, string dep, string classname, string teachername, string beginweek, string overweek, string weekclass)
        {
            this.term = term;
            this.dep = dep;
            this.classname = classname;
            this.teachername = teachername;
            this.beginweek = beginweek;
            this.overweek = overweek;
            this.weekclass = weekclass;
        }

        public string Term { get => term; set => term = value; }
        public string Dep { get => dep; set => dep = value; }
        public string Classname { get => classname; set => classname = value; }
        public string Teachername { get => teachername; set => teachername = value; }
        public string Beginweek { get => beginweek; set => beginweek = value; }
        public string Overweek { get => overweek; set => overweek = value; }
        public string Weekclass { get => weekclass; set => weekclass = value; }

        public override bool Equals(object obj)
        {
            return obj is FileInfo info &&
                   term == info.term &&
                   dep == info.dep &&
                   classname == info.classname &&
                   teachername == info.teachername &&
                   beginweek == info.beginweek &&
                   overweek == info.overweek &&
                   weekclass == info.weekclass;
        }

        public override int GetHashCode()
        {
            int hashCode = -1357735129;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(term);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(dep);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(classname);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(teachername);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(beginweek);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(overweek);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(weekclass);
            return hashCode;
        }
    }
}
