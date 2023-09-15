using System;
using System.Net.Sockets;

namespace tcpUdpApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            static void DisplayMenu()
            {
                Console.WriteLine("Select:");
                Console.WriteLine("1: Start TCP Server");
                Console.WriteLine("2: Start UDP Server");
                Console.WriteLine("3: Send TCP-message");
                Console.WriteLine("4: Send UDP-message");
                Console.WriteLine("5: Refresh");
                Console.WriteLine("6: Exit");
                Console.WriteLine("Input: ");
            }

            DisplayMenu();

            while (true)
            {   
                string? userInput = Console.ReadLine();

                if (userInput != null && userInput.Length == 1)
                {
                    char choice = userInput[0];

                    switch (choice)
                    {
                        case '1':
                            TcpServer tcpServer = new TcpServer();
                            Task.Run(() => tcpServer.Start());
                            break;
                        case '2':
                            UdpServer udpServer = new UdpServer();
                            Task.Run(() => udpServer.Start());
                            break;
                        case '3':
                            Client tcpClient = new Client();
                            tcpClient.SendTcpMessage(" Testing TCP");
                            break;
                        case '4':
                            Client udpClient = new Client();
                            udpClient.SendUdpMessage(" Testing UDP");
                            break;
                        case '5':
                            Console.Clear();
                            DisplayMenu();
                            break;
                        case '6':
                            Environment.Exit(0);
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Press Enter to continue...");
                    Console.ReadLine();
                    Console.Clear();
                    DisplayMenu();
                }
            }
        }
    }
}






