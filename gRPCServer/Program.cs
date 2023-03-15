﻿using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gRPCServer
{
    internal class Program
    {
        const int port = 50051;
        static void Main(string[] args)
        {
            Server server = null;
            try
            {
                server = new Server()
                {
                    Ports =
                    {
                        new ServerPort("localhost", port, ServerCredentials.Insecure)
                    }
                };
                server.Start();
                Console.WriteLine("The server is lestening on the port : " + port);
                Console.ReadKey();
            }
            catch (IOException e)
            {
                Console.WriteLine("The server failed to start : " + e.Message);
                throw;
            }
            finally
            {
                if (server != null)
                {
                    server.ShutdownAsync().Wait();
                }
            }
        }
    }
}