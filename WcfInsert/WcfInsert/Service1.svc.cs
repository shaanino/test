using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace WcfInsert
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string InsertUserDetails(UserDetails UserInfo)
        {
            string message;

            SqlConnection conn = new SqlConnection("Data Source=localhost; Initial Catalog=trial_user; Integrated Security=True;");
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into tblUserDetails(username) values(@username)", conn );
            cmd.Parameters.AddWithValue("@username", UserInfo.UserName);
            int result = cmd.ExecuteNonQuery();

            if (result == 1)
            {
                message = UserInfo.UserName + "Details inserted successfully jhkjh";

            }

            else
            {
                message = UserInfo.UserName + "Details not inserted";
            }



            conn.Close();
            return message;
            
        }
    }
}
