using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace js_ape.Model
{
    /// <summary>
    /// 班级实体类
    /// </summary>
    class ClassInfo
    {
        private string term;//学期
        private string dep;//系别
        private string classname;//班级

        public ClassInfo()
        {
        }

        public ClassInfo(string term, string dep, string classname)
        {
            this.Term = term;
            this.Dep = dep;
            this.Classname = classname;
        }

        public string Term { get => term; set => term = value; }
        public string Dep { get => dep; set => dep = value; }
        public string Classname { get => classname; set => classname = value; }

        public override bool Equals(object obj)
        {
            return obj is ClassInfo info &&
                   term == info.term &&
                   dep == info.dep &&
                   classname == info.classname;
        }

        public override int GetHashCode()
        {
            int hashCode = -246160951;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(term);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(dep);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(classname);
            return hashCode;
        }
    }
}
