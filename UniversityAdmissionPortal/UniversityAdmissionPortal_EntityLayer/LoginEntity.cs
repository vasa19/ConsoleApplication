using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityAdmissionPortal_EntityLayer
{
    public class LoginEntity
    {
        public int Student_id { get; set; }
        public string Password { get; set; }
        public LoginEntity(int sid, string password)
        {
            this.Student_id = sid;
            this.Password = password;
        }
    }
}
