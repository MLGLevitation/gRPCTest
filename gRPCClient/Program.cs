using Blog;
using Dummy;
using Greeting;
using Grpc.Core;
using Sqrt;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gRPCClient
{
    internal class Program
    {
        //const string target = "127.0.0.1:50051";
        static async Task Main(string[] args)
        {
            var clientCert = File.ReadAllText("ssl/client.crt");
            var clientKey = File.ReadAllText("ssl/client.key");
            var caCrt = File.ReadAllText("ssl/ca.crt");

            var channelCredential = new SslCredentials(caCrt, new KeyCertificatePair(clientCert, clientKey));

            Channel channel = new Channel("localhost", 50051, channelCredential);

            await channel.ConnectAsync().ContinueWith(t =>
            {
                if (t.Status == TaskStatus.RanToCompletion)
                {
                    Console.WriteLine("The client connected successfuly");
                }
            });

            var client = new BlogService.BlogServiceClient(channel);

            //var newBlog = CreateBlog(client);
            //ReadBlog(client, newBlog.Id);
            //UpdateBlog(client, newBlog);
            //DeleteBlog(client, newBlog);
            await ListBlog(client);

            #region 1
            //var client = new sqrtService.sqrtServiceClient(channel);

            //var client = new GreetingService.GreetingServiceClient(channel);

            //try
            //{
            //    var response = client.GreetWithDeadline(new GreetReq() { Name = "John" } , deadline: DateTime.UtcNow.AddMilliseconds(1000));
            //    Console.WriteLine(response.Result);
            //}
            //catch (RpcException e) when (e.StatusCode == StatusCode.DeadlineExceeded)
            //{
            //    Console.WriteLine("Error : " + e.Status.Detail);
            //    throw;
            //}
            #endregion

            channel.ShutdownAsync().Wait();
            Console.ReadKey();
        }

        private static Blog.Blog CreateBlog(BlogService.BlogServiceClient client)
        {
            var response = client.CreateBlog(new CreateBlogRequest()
            {
                Blog = new Blog.Blog()
                {
                    AuthorId = "My Author",
                    Title = "Some title",
                    Conttent = "send help pls"
                }
            });

            Console.WriteLine("The blog " + response.Blog.Id + " was created");
            return response.Blog;
        }

        private static void ReadBlog(BlogService.BlogServiceClient client, string id)
        {
            try
            {
                var response = client.ReadBlog(new ReadBlogRequest()
                {
                    BlogId = id
                });

                Console.WriteLine("Requested blog " + response.Blog.ToString());
            }
            catch (RpcException e)
            {
                Console.WriteLine(e.Status.Detail);
                throw;
            }
        }

        private static void UpdateBlog(BlogService.BlogServiceClient client, Blog.Blog blog)
        {
            try
            {
                blog.AuthorId = "Updated author";
                blog.Title = "Updated title";
                blog.Conttent = "Updated content";

                var response = client.UpdateBlog(new UpdateBlogRequest()
                {
                    Blog = blog
                });

                Console.WriteLine(response.Blog.ToString());
            }
            catch (RpcException e)
            {
                Console.WriteLine(e.Status.Detail);
                throw;
            }
        }

        private static void DeleteBlog(BlogService.BlogServiceClient client, Blog.Blog blog)
        {
            try
            {
                var response = client.DeleteBlog(new DeleteBlogRequest() { BlogId = blog.Id });

                Console.WriteLine("The blog with id " + response.BlogId + " was deleted");
            }
            catch (RpcException e)
            {
                Console.WriteLine(e.Status.Detail);
                throw;
            }
        }

        private static async Task ListBlog(BlogService.BlogServiceClient client)
        {
            try
            {
                var response = client.ListBlog(new ListBlogRequest() { });

                while (await response.ResponseStream.MoveNext())
                {
                    Console.WriteLine(response.ResponseStream.Current.Blog.ToString());
                }
            }
            catch (RpcException e)
            {
                Console.WriteLine(e.Status.Detail);
                throw;
            }
        }
    }
}
