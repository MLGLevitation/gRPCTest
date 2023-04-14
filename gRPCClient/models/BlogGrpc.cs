// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Blog.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Blog {
  public static partial class BlogService
  {
    static readonly string __ServiceName = "blog.BlogService";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Blog.CreateBlogRequest> __Marshaller_blog_CreateBlogRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Blog.CreateBlogRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Blog.CreateBlogResponse> __Marshaller_blog_CreateBlogResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Blog.CreateBlogResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Blog.ReadBlogRequest> __Marshaller_blog_ReadBlogRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Blog.ReadBlogRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Blog.ReadBlodResponse> __Marshaller_blog_ReadBlodResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Blog.ReadBlodResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Blog.UpdateBlogRequest> __Marshaller_blog_UpdateBlogRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Blog.UpdateBlogRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Blog.UpdateBlogResponse> __Marshaller_blog_UpdateBlogResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Blog.UpdateBlogResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Blog.DeleteBlogRequest> __Marshaller_blog_DeleteBlogRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Blog.DeleteBlogRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Blog.DeleteBlogResponse> __Marshaller_blog_DeleteBlogResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Blog.DeleteBlogResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Blog.ListBlogRequest> __Marshaller_blog_ListBlogRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Blog.ListBlogRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Blog.ListBlogResponse> __Marshaller_blog_ListBlogResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Blog.ListBlogResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Blog.CreateBlogRequest, global::Blog.CreateBlogResponse> __Method_CreateBlog = new grpc::Method<global::Blog.CreateBlogRequest, global::Blog.CreateBlogResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateBlog",
        __Marshaller_blog_CreateBlogRequest,
        __Marshaller_blog_CreateBlogResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Blog.ReadBlogRequest, global::Blog.ReadBlodResponse> __Method_ReadBlog = new grpc::Method<global::Blog.ReadBlogRequest, global::Blog.ReadBlodResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ReadBlog",
        __Marshaller_blog_ReadBlogRequest,
        __Marshaller_blog_ReadBlodResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Blog.UpdateBlogRequest, global::Blog.UpdateBlogResponse> __Method_UpdateBlog = new grpc::Method<global::Blog.UpdateBlogRequest, global::Blog.UpdateBlogResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateBlog",
        __Marshaller_blog_UpdateBlogRequest,
        __Marshaller_blog_UpdateBlogResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Blog.DeleteBlogRequest, global::Blog.DeleteBlogResponse> __Method_DeleteBlog = new grpc::Method<global::Blog.DeleteBlogRequest, global::Blog.DeleteBlogResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteBlog",
        __Marshaller_blog_DeleteBlogRequest,
        __Marshaller_blog_DeleteBlogResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Blog.ListBlogRequest, global::Blog.ListBlogResponse> __Method_ListBlog = new grpc::Method<global::Blog.ListBlogRequest, global::Blog.ListBlogResponse>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "ListBlog",
        __Marshaller_blog_ListBlogRequest,
        __Marshaller_blog_ListBlogResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Blog.BlogReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of BlogService</summary>
    [grpc::BindServiceMethod(typeof(BlogService), "BindService")]
    public abstract partial class BlogServiceBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Blog.CreateBlogResponse> CreateBlog(global::Blog.CreateBlogRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Blog.ReadBlodResponse> ReadBlog(global::Blog.ReadBlogRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Blog.UpdateBlogResponse> UpdateBlog(global::Blog.UpdateBlogRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Blog.DeleteBlogResponse> DeleteBlog(global::Blog.DeleteBlogRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task ListBlog(global::Blog.ListBlogRequest request, grpc::IServerStreamWriter<global::Blog.ListBlogResponse> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for BlogService</summary>
    public partial class BlogServiceClient : grpc::ClientBase<BlogServiceClient>
    {
      /// <summary>Creates a new client for BlogService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public BlogServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for BlogService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public BlogServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected BlogServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected BlogServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Blog.CreateBlogResponse CreateBlog(global::Blog.CreateBlogRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateBlog(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Blog.CreateBlogResponse CreateBlog(global::Blog.CreateBlogRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CreateBlog, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Blog.CreateBlogResponse> CreateBlogAsync(global::Blog.CreateBlogRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateBlogAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Blog.CreateBlogResponse> CreateBlogAsync(global::Blog.CreateBlogRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CreateBlog, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Blog.ReadBlodResponse ReadBlog(global::Blog.ReadBlogRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ReadBlog(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Blog.ReadBlodResponse ReadBlog(global::Blog.ReadBlogRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ReadBlog, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Blog.ReadBlodResponse> ReadBlogAsync(global::Blog.ReadBlogRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ReadBlogAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Blog.ReadBlodResponse> ReadBlogAsync(global::Blog.ReadBlogRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ReadBlog, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Blog.UpdateBlogResponse UpdateBlog(global::Blog.UpdateBlogRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateBlog(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Blog.UpdateBlogResponse UpdateBlog(global::Blog.UpdateBlogRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UpdateBlog, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Blog.UpdateBlogResponse> UpdateBlogAsync(global::Blog.UpdateBlogRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateBlogAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Blog.UpdateBlogResponse> UpdateBlogAsync(global::Blog.UpdateBlogRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UpdateBlog, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Blog.DeleteBlogResponse DeleteBlog(global::Blog.DeleteBlogRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteBlog(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Blog.DeleteBlogResponse DeleteBlog(global::Blog.DeleteBlogRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeleteBlog, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Blog.DeleteBlogResponse> DeleteBlogAsync(global::Blog.DeleteBlogRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteBlogAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Blog.DeleteBlogResponse> DeleteBlogAsync(global::Blog.DeleteBlogRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeleteBlog, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncServerStreamingCall<global::Blog.ListBlogResponse> ListBlog(global::Blog.ListBlogRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListBlog(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncServerStreamingCall<global::Blog.ListBlogResponse> ListBlog(global::Blog.ListBlogRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_ListBlog, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override BlogServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new BlogServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(BlogServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_CreateBlog, serviceImpl.CreateBlog)
          .AddMethod(__Method_ReadBlog, serviceImpl.ReadBlog)
          .AddMethod(__Method_UpdateBlog, serviceImpl.UpdateBlog)
          .AddMethod(__Method_DeleteBlog, serviceImpl.DeleteBlog)
          .AddMethod(__Method_ListBlog, serviceImpl.ListBlog).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, BlogServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_CreateBlog, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Blog.CreateBlogRequest, global::Blog.CreateBlogResponse>(serviceImpl.CreateBlog));
      serviceBinder.AddMethod(__Method_ReadBlog, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Blog.ReadBlogRequest, global::Blog.ReadBlodResponse>(serviceImpl.ReadBlog));
      serviceBinder.AddMethod(__Method_UpdateBlog, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Blog.UpdateBlogRequest, global::Blog.UpdateBlogResponse>(serviceImpl.UpdateBlog));
      serviceBinder.AddMethod(__Method_DeleteBlog, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Blog.DeleteBlogRequest, global::Blog.DeleteBlogResponse>(serviceImpl.DeleteBlog));
      serviceBinder.AddMethod(__Method_ListBlog, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::Blog.ListBlogRequest, global::Blog.ListBlogResponse>(serviceImpl.ListBlog));
    }

  }
}
#endregion
