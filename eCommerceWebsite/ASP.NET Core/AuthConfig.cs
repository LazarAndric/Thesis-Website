using System;
using System.IO;
using System.Globalization;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1
{
    public class AuthConfig
    {
        public string BaseAddress { get; set; }
        //public static AuthConfig ReadJsonFromFile (string path)
        //{
        //    IConfiguration Configuration;

        //    var builder = new ConfigurationBuilder()
        //        .SetBasePath(Directory.GetCurrentDirectory())
        //        .AddJsonFile(path);

        //    Configuration = builder.Build();

        //    return Configuration.Get<AuthConfig>();
        //}


    }
}
