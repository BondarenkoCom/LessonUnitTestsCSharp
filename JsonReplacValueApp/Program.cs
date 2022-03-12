using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;


namespace JsonReplacValueApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckAndRewriteJson.ReadJson();
        }
    }


    public class CheckAndRewriteJson
    {
        public static void WriteJson()
        {
            StringBuilder sb = new StringBuilder();
            StringWriter sw = new StringWriter();

            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                writer.Formatting = Formatting.Indented;


                writer.WriteStartObject();
                //writer.WritePropertyName("Logging");
                //writer.WriteRawValue("IncludeScopes");

                writer.WritePropertyName("Logging");

                writer.WriteStartObject();
                writer.WritePropertyName("IncludeScopes");
                writer.WriteValue("false");

                writer.WritePropertyName("LogLevel");
                writer.WriteStartObject();
                writer.WritePropertyName("Default");
                writer.WriteValue("Trace");
                writer.WritePropertyName("Microsoft");
                writer.WriteValue("Warning");
                writer.WritePropertyName("Microsoft.Hosting.Lifetime");
                writer.WriteValue("Information");
                writer.WritePropertyName("System.Net.Http.HttpClient.ITransport.LogicalHandler");
                writer.WriteValue("Warning");
                writer.WriteEnd();
                writer.WritePropertyName("StatCollectablesInfo");
                writer.WriteStartObject();

                writer.WritePropertyName("Period");
                writer.WriteValue("30");
                writer.WritePropertyName("SaveToLocalOnly");
                writer.WriteValue("true");

                writer.WriteEnd();
                writer.WritePropertyName("AllowedHosts");
                writer.WriteValue("*");

                writer.WriteEnd();
                writer.WriteEnd();

            }

            Console.WriteLine(sw.ToString());

            //string json = JsonConvert.SerializeObject(sw.ToString(), Formatting.Indented);
            System.IO.File.WriteAllText(
                @"C:\Users\BondarenkoAS\MyRepos\LessonBaseCSharp\JsonReplacValueApp\myfile.json", sw.ToString());


        }

        class JsonValues
        {
            [JsonProperty("LastCheckTime")]
            public object LastCheckTime { get; set; }

            [JsonProperty("MethodStats")]
            public MethodStats MethodStats { get; set; }

        }

        public partial class MethodStats
        {
            [JsonProperty("Succeeded")]
            public Succeeded Succeeded { get; set; }
        }

        public partial class Succeeded
        {
            [JsonProperty("GetVersion")]
            public long GetVersion { get; set; }

            [JsonProperty("TokenInitialize")]
            public long TokenInitialize { get; set; }

            [JsonProperty("TokenGetCertificates")]
            public long TokenGetCertificates { get; set; }

            [JsonProperty("GetCertificatesFromStore")]
            public long GetCertificatesFromStore { get; set; }

            [JsonProperty("MrSign")]
            public long MrSign { get; set; }

            [JsonProperty("GetCSPVersion")]
            public long GetCspVersion { get; set; }
        }
        public static void ReadJson()
        {
            //var myObj =
            string filePath = File.ReadAllText(@"C:\Users\BondarenkoAS\AppData\Roaming\TaxcomAgent\2.0.1.12\statinfo.json");

            var check = JsonConvert.DeserializeObject<JsonValues>(filePath);
            //Console.WriteLine(check.MethodStats);
            //Console.WriteLine(check.LastCheckTime.ToString());
            Console.WriteLine(check.MethodStats.Succeeded);

            //{
            //    "Version": "2.0.1.17",
            //    "Size": 0,
            //    "md5": "."
            //}

            //while (reader.Read())
            //{
            //    if (reader.Value != null)
            //    {
            //
            //        JsonConvert.DeserializeObject(reader.ToString());
            //        Console.WriteLine(reader);
            //        
            //        //Console.WriteLine("Version: {0},Value: {1}", reader.TokenType, reader.Value);
            //        //Console.WriteLine("Token: {0},Value: {1}", reader.TokenType , reader.Value);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Token: {0}", reader.TokenType);
            //    }
            //}
        }
    }
}
