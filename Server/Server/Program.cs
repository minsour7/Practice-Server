﻿using ServerCore;
using System;
using System.Net;
using System.Net.Sockets;

namespace Server
{

    class Program
    {
        static Listener _listener = new Listener();
        public static GameRoom Room = new GameRoom();

        static void Main(string[] args)
        {
            // DNS
            string host = Dns.GetHostName();
            IPHostEntry ipHost = Dns.GetHostEntry(host);
            IPAddress ipAddr = ipHost.AddressList[0];
            IPEndPoint endPoint = new IPEndPoint(ipAddr, 7777);

            // 문지기 
            Socket listenSocket = new Socket(endPoint.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            _listener.init(endPoint, () => { return SessionManager.Instance.Generate(); });

            Console.WriteLine("Listening ...");

            while (true)
            {

            }
        }
    }
}
