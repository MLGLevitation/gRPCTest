using Blog;
using Greeting;
using Grpc.Core;
using Grpc.Reflection;
using Grpc.Reflection.V1Alpha;
using Sqrt;
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
                var reflectionService = new ReflectionServiceImpl(BlogService.Descriptor, ServerReflection.Descriptor);

                var serverCert = File.ReadAllText("ssl/server.crt");
                var serverKey = File.ReadAllText("ssl/server.key");
                var keypair = new KeyCertificatePair(serverCert, serverKey);
                var cacert = File.ReadAllText("ssl/ca.crt");

                var credentials = new SslServerCredentials(new List<KeyCertificatePair>() { keypair }, cacert, true);


                server = new Server()
                {
                    Services =
                    {
                        BlogService.BindService(new BlogServiceImpl()),
                        ServerReflection.BindService(new ReflectionServiceImpl())
                    },
                    //Services = { 
                    //    GreetingService.BindService(new GreetingServiceImpl())
                    //},
                    //Services = { sqrtService.BindService(new SqrtServiceImpl()) },
                    Ports =
                    {
                        new ServerPort("localhost", port, credentials)
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
