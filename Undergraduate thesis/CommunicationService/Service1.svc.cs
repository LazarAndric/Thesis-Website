using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CommunicationService
{
    public class Service1 : IService1
    {
        public string Insert(string name, string email)
        {
            string msg;
            SqlConnection con = new SqlConnection("Data Source=(localdb)/ProjectsV13;Initial Catalog=Database1;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False");
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into Table1 (Name, Email) values(@Name, @Email)",con);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Email", email);
            int g = cmd.ExecuteNonQuery();
            msg = "Succesfully inserted";
            return msg;
        }
    }
}
