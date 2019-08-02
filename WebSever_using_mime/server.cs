using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace WebSever_using_mime
{
    public class Server
    {
        TcpListener tcp 
        public int port = 1490;
        public Server()
        {
            tcp = new TcpListener(1562);
            tcp.Start();
            Console.WriteLine("Server running");

        }

    }
}
