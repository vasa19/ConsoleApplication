using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityAdmissionPortal_EntityLayer
{
    public class CourseEntity
    {
        public int Course_id { get; set; }
        public string Course_name { get; set; }
        public CourseEntity(string cn)
        {
            this.Course_name = cn;
        }
        public CourseEntity(int cid)
        {
            this.Course_id = cid;
        }

        public CourseEntity(int cid, string cn)
        {
            this.Course_id = cid;
            this.Course_name = cn;
        }
    }
}
