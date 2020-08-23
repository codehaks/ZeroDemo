using NetMQ;
using NetMQ.Sockets;
using System;

namespace Mars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello From Mars!");
            using var socket = new ResponseSocket("@tcp://localhost:5500");

            var msg = socket.ReceiveFrameString();

            Console.WriteLine($"From Earth : {msg}");            

        }
    }
}
