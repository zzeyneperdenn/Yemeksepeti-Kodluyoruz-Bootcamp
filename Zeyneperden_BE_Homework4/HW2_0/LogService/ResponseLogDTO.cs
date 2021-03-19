using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomMiddleWare.LogService
{
    public class ResponseLogDTO
    {
        public Guid Id { get; set; }
        public int StatusCode { get; set; }
        public DateTime CreatedTime { get; set; }
    }
}
