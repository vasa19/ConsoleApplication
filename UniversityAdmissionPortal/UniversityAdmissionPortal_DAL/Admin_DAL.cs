using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Configuration;
using UniversityAdmissionPortal_EntityLayer;

namespace UniversityAdmissionPortal_DataAccessLayer
{
    public class Admin_DAL
    {
        //public List<StudentEntity> ViewRegisteredUser()
        //{
        //    string c = ConfigurationManager.ConnectionStrings["connection_string"].ConnectionString;
        //    SqlCommand cmd = new SqlCommand();
        //    DataSet ds = new DataSet();
        //    SqlDataAdapter da = new SqlDataAdapter();

        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.CommandText = "view_registered_user";
        //cmd.Connection = c;

        //    da.SelectCommand = cmd;
        //    da.Fill(ds, "view_registered_user");

        //    List<Entity> studentList = new List<Entity>();
        //    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        //    {
        //        Entity student = new Entity
        //        {
        //            Student_id = Convert.ToInt32(ds.Tables[0].Rows[i][0]),
        //            Name = ds.Tables[0].Rows[i][1].ToString(),
        //            Age = Convert.ToInt32(ds.Tables[0].Rows[i][2]),
        //            Email = ds.Tables[0].Rows[i][3].ToString(),
        //            Contact_no = ds.Tables[0].Rows[i][4].ToString(),
        //            App_Status = ds.Tables[0].Rows[i][5].ToString(),
        //            Pay_details = ds.Tables[0].Rows[i][6].ToString(),
        //            Docs = ds.Tables[0].Rows[i][7].ToString(),
        //            Course_name = ds.Tables[0].Rows[i][8].ToString()
        //        };
        //        studentList.Add(student);
        //    }
        //    return studentList;
        //}
    }
}
