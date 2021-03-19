using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace CustomMiddleWare.LogService
{
    public class RequestLogDTO
    {
        public Guid Id { get; set; }
        public string Method { get; set; }
        public string Host { get; set; }
        public PathString Path { get; set; }
        public DateTime CreatedTime { get; set; }
    }
}
