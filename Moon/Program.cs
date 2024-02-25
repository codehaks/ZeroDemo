// See https://aka.ms/new-console-template for more information
using NetMQ;
using NetMQ.Sockets;

Console.WriteLine("Hello, World!");

using (PushSocket pushSocket = new PushSocket())
{
    pushSocket.Connect("tcp://127.0.0.1:5556"); // Connect to the PULL socket

    string msg = "";

    do
    {
        Console.WriteLine("Message : ");
        msg = Console.ReadLine();

        pushSocket.SendFrame(msg);
    } while (!string.IsNullOrEmpty(msg));

}