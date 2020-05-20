using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CommunicationService
{
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string Insert(string name, string email);
    }

    [DataContract]
    public class InsertUser
    {
        string name = String.Empty;
        string email = String.Empty;

        [DataMember]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        [DataMember]
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
    }
}
