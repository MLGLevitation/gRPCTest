using Grpc.Core;
using Sqrt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Sqrt.sqrtService;

namespace gRPCServer
{
    public class SqrtServiceImpl : sqrtServiceBase
    {
        public override async Task<sqrtResp> sqrt(sqrtReq request, ServerCallContext context)
        {
            int number = request.Number;

            if (number >= 0) { 
                return new sqrtResp() { Root = Math.Sqrt(number) };    
            }
            else {
                throw new RpcException(new Status(StatusCode.InvalidArgument, "number < 0"));
            }
        }
    }
}
