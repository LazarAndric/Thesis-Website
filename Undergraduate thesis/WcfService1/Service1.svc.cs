using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    public class Service1 : IService1
    {
        string n;
        float rez=0;

        public void SaveData(string name)
        {
            Console.WriteLine(name);
            n = name;
        }
        public string LoadData()
        {
            if (n == null)
                return n="Ne radi";
            else return n;
        }
        public void Sum(float x, float y)
        {
            rez = x + y;
        }

        public float PrintEnd()
        {
            return rez;
        }
    }
}
