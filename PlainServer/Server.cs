using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PlainServer
{
    class Server
    {
        public void Start()
        {
            TcpListener server = new TcpListener(IPAddress.Loopback, 10001);
            server.Start();

            using (TcpClient client = server.AcceptTcpClient())
                Conn(client);
            Console.ReadLine();
        }

        public Server()
        {

        }


        public void Conn(TcpClient client)
        {
            //vi henter clientens stream/data ind.
            using (NetworkStream ns = client.GetStream())
            using (StreamReader sr = new StreamReader(ns))
            using (StreamWriter sw = new StreamWriter(ns))
            {
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
        }
    }
}
