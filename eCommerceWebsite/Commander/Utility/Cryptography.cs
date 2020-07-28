using System;
using AutoMapper;
using Commander.Dtos;
using Commander.Models;
using System.Security.Cryptography;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace Commander.Utility
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
            // tryCry=PrivatKeyString();
            // File.WriteAllText("PrivateKey",tryCry);
        }
        public string PublicKeyString(){
            var sw= new StringWriter();
            var xml = new XmlSerializer(typeof(RSAParameters));
            var _publicKey=rsa.ExportParameters(false);
            xml.Serialize(sw,_publicKey);
            return sw.ToString();
        }
        // public string PrivatKeyString(){
        //     var sw= new StringWriter();
        //     var xml = new XmlSerializer(typeof(RSAParameters));
        //     var _privateKey=rsa.ExportParameters(true);
        //     xml.Serialize(sw,_privateKey);
        //     return sw.ToString();
        // }

        public string Encrypt(string data){
            // rsa.FromXmlString(xml);
            Console.WriteLine("Encrypt" + rsa.ToXmlString(false));
            Byte[] bytes = Encoding.UTF32.GetBytes(data);
            var cypher = rsa.Encrypt(bytes,false);
            return Convert.ToBase64String(cypher);
        }

        public string Decrypt(string cypher){
            Console.WriteLine("Decrypt: " + rsa.ToXmlString(true));
            var bytes = Convert.FromBase64String(cypher);
            // var xmlString = File.ReadAllText("PrivateKey");
            // rsa.FromXmlString(xmlString);
            var data = rsa.Decrypt(bytes,false);
            return Encoding.UTF32.GetString(data);
        }
    }
}