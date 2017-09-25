using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.IO;
using ModelLib;


namespace PlainClient
{
    public class Client
    {
        public void Start()
        {
            Car Acar = new Car(); 
            Acar.Model = "Toyota";
            Acar.Color = "Black";
            Acar.RegNo = "123ABC12";

            using (TcpClient tcpc = new TcpClient("localhost", 10001))
            using (NetworkStream ns = tcpc.GetStream())
            using (StreamReader sr = new StreamReader(ns))
            using (StreamWriter sw = new StreamWriter(ns))
            {

                string line = "Model: " + Acar.Model; 
                sw.WriteLine(line);
                sw.Flush();

            }
        }
    }
}
