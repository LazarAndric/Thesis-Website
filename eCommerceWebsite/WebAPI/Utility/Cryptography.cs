using System;
using AutoMapper;
using WebAPI.Dtos;
using WebAPI.Models;
using System.Security.Cryptography;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace WebAPI.Utility
{
    public class Cryptography
    {
        public RSACryptoServiceProvider rsa;
        public string tryCry;

        public Cryptography()
        {
            rsa = new RSACryptoServiceProvider();
            tryCry=File.ReadAllText("RsaKey");
            rsa.FromXmlString(tryCry);
        }
        public string PublicKeyString(){
            var sw= new StringWriter();
            var xml = new XmlSerializer(typeof(RSAParameters));
            var _publicKey=rsa.ExportParameters(false);
            xml.Serialize(sw,_publicKey);
            return sw.ToString();
        }

        public string Encrypt(string data){
            Byte[] bytes = Encoding.UTF32.GetBytes(data);
            var cypher = rsa.Encrypt(bytes,false);
            return Convert.ToBase64String(cypher);
        }

        public string Decrypt(string cypher){
            var bytes = Convert.FromBase64String(cypher);
            var data = rsa.Decrypt(bytes,false);
            return Encoding.UTF32.GetString(data);
        }
    }
}