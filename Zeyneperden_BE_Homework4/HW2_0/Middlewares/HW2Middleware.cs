using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomMiddleWare.LogService;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace CustomMiddleWare.Middlewares
{
    public class HW2Middleware
    {
        private readonly RequestDelegate _requestDelegate;
        private readonly ILogger _logger;
        private FileService _fileService;
        Guid _id;

        public HW2Middleware(RequestDelegate requestDelegate,ILoggerFactory loggerFactory)
        {
            _requestDelegate = requestDelegate;
            _logger = loggerFactory.CreateLogger<RequestDelegate>();
            _fileService = new FileService();
        }

        public async Task Invoke(HttpContext context)
        {
            _id = Guid.NewGuid();
            var request = context.Request;
            RequestMiddleware(request);
            await _requestDelegate(context);

            var response = context.Response;
            ResponseMiddleware(response);
        }

        public void RequestMiddleware(HttpRequest request)
        {
            List<RequestLogDTO> mylogs = _fileService.ReadRequest();
            RequestLogDTO requestLog = new RequestLogDTO
            {
                Id = _id,
                Host = request.Host.Value,
                CreatedTime = DateTime.Now,
                Method = request.Method,
                Path = request.Path
            };

            mylogs.Add(requestLog);

            _fileService.WriteRequest(mylogs);
        }

        public void ResponseMiddleware(HttpResponse response)
        {
            List<ResponseLogDTO> mylogs = _fileService.ReadResponse();

            ResponseLogDTO responseLog = new ResponseLogDTO
            {
                Id = _id,
                StatusCode = response.StatusCode,
                CreatedTime = DateTime.Now
            };
            mylogs.Add(responseLog);

            _fileService.WriteResponse(mylogs);

        }
    }
}
