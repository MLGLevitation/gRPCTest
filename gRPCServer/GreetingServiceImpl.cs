using Greeting;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Greeting.GreetingService;

namespace gRPCServer
{
    public class GreetingServiceImpl : GreetingServiceBase
    {
        public override async Task<GreetResp> GreetWithDeadline(GreetReq request, ServerCallContext context)
        {
            await Task.Delay(300);

            return new GreetResp() { Result = "hello" + request.Name };
        }
    }
}
