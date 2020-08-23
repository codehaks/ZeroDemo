using NetMQ;
using NetMQ.Sockets;
using System;

namespace Earth
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from Earth!");
            using var socket = new RequestSocket(">tcp://localhost:5500");

            Console.WriteLine("Message : ");
            var msg = Console.ReadLine();
            socket.SendFrame(msg);

        }
    }
}
