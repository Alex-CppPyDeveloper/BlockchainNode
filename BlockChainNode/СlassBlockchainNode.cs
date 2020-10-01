using System;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


using System.Net;
using System.IO;

namespace BlockChainNode
{
    class Head
    {
        public string Chain_id { get; set; }
        public string Hash { get; set; }
        public string Predecessor { get; set; }
        public int Level { get; set; }
        public DateTime Timestamp { get; set; }


    }
    class СlassBlockchainNode
    {
        public string base_url;
      public СlassBlockchainNode(string base_url)
        {
            this.base_url = base_url ;
        }
        public Head GetHead(string url)
        
        {
            Console.WriteLine("Hello World!");
            url = base_url + url;
            WebRequest request = WebRequest.Create(url);
            WebResponse response = request.GetResponse();

            Stream stream = response.GetResponseStream();
            StreamReader sr = new StreamReader(stream);
            string s = sr.ReadToEnd();
            Console.WriteLine(s);
            _ = JObject.Parse(s);

            Head parsed = JsonConvert.DeserializeObject<Head>(s);




            Console.WriteLine($"Head.ChainId: {parsed.Chain_id}");
            Console.WriteLine($"Head.Hash: {parsed.Hash}");
            Console.WriteLine($"Head.Predecessor: {parsed.Predecessor}");
            Console.WriteLine($"Head.Level: {parsed.Level}");
            Console.WriteLine($"Head.Timestamp: {parsed.Timestamp}");

            Console.ReadLine();

            return parsed;

        }
    }

   
}
