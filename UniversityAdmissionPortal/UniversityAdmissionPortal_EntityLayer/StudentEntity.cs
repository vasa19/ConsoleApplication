using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityAdmissionPortal_EntityLayer
{
    public class StudentEntity
    {
            public int Student_id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public string App_Status { get; set; }
            public string Email { get; set; }
            public string Contact_no { get; set; }
            public string Pay_details { get; set; }
            public string Docs { get; set; }
            public string Pay_Date { get; set; }
            public int Course_id { get; set; }
            public string Course_name { get; set; }
            public StudentEntity(int id)
            {
                this.Student_id = id;
            }

            public StudentEntity(string name, string email, string contact)
            {
                this.Name = name;
                this.Email = email;
                this.Contact_no = contact;
            }

            public StudentEntity(int sid, string paydet)
            {
                this.Student_id = sid;
                this.Pay_details = paydet;
            }

            public StudentEntity(string sname, int sage, string email, string contact, string cname)
            {
                this.Name = sname;
                this.Age = sage;
                this.Email = email;
                this.Contact_no = contact;
                this.Course_name = cname;
            }
        }

        public class EntityName
        {
            public int Student_id { get; set; }
            public string Name { get; set; }

            public EntityName(int sid, string name)
            {
                this.Student_id = sid;
                this.Name = name;
            }
        }

        public class EntityEmail
        {
            public int Student_id { get; set; }
            public string Email { get; set; }

            public EntityEmail(int sid, string email)
            {
                this.Student_id = sid;
                this.Email = email;
            }
        }


        public class EntityContact
        {
            public int Student_id { get; set; }
            public string Contact_no { get; set; }

            public EntityContact(int sid, string contact)
            {
                this.Student_id = sid;
                this.Contact_no = contact;
            }
        }
    }