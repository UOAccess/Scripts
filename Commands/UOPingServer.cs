using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace UOPingServer
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("#################################");
            Console.WriteLine("### Ultima Online Ping Server ###");
            Console.WriteLine("###     Created by aj9251     ###");
            Console.WriteLine("#################################");

                UdpClient receivingUdpClient = new UdpClient(12000);

                IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
              
           
            while (true)
                {
                    try
                    {

                        // Blocks until a message returns on this socket from a remote host.
                        Byte[] receiveBytes = receivingUdpClient.Receive(ref RemoteIpEndPoint);

                        IPAddress IP = RemoteIpEndPoint.Address;
                        int Port = RemoteIpEndPoint.Port;
                        int bytes = receiveBytes.Length;
                        string data = Encoding.ASCII.GetString(receiveBytes);

                        Console.WriteLine("[" + System.DateTime.Now.Hour.ToString().PadLeft(2, '0') + ":" +
                            System.DateTime.Now.Minute.ToString().PadLeft(2, '0') + ":" +
                            System.DateTime.Now.Second.ToString().PadLeft(2, '0') + "] " + IP.ToString() +
                            ":" + Port.ToString() + " - " +
                            bytes + " bytes - Data:" + data);

                        receivingUdpClient.Send(receiveBytes, receiveBytes.Length, RemoteIpEndPoint);

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.ToString());
                    }
               }
        }
    }
}
