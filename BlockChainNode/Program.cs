
using System;

namespace BlockChainNode
{

    class Program
    {
       
        static void Main(string[] args)
        {
            string base_url = "https://rpc.tzkt.io/mainnet/";
            string url = "chains/main/blocks/head/header";
            СlassBlockchainNode classBlockchain = new СlassBlockchainNode(base_url);
            Console.WriteLine("Hello World!");
         
            _ = new Head();
            Head head = classBlockchain.GetHead(url);
            Console.WriteLine(head.Chain_id);
            Console.ReadKey();
        }
    }
}
