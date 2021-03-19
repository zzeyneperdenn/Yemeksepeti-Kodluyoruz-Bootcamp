using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CustomMiddleWare.LogService
{
    public class FileService
    {
        private readonly string _filePathRequest = @"Logs/RequestLogs.json";
        private readonly string _filePathResponse = @"Logs/ResponseLogs.json";
        public List<RequestLogDTO> ReadRequest()
        {
            return JsonConvert.DeserializeObject<List<RequestLogDTO>>(File.ReadAllText(_filePathRequest));
        }
        public List<ResponseLogDTO> ReadResponse()
        {
            return JsonConvert.DeserializeObject<List<ResponseLogDTO>>(File.ReadAllText(_filePathResponse));
        }
        public void WriteRequest(List<RequestLogDTO> model)
        {
            File.WriteAllText(_filePathRequest, JsonConvert.SerializeObject(model));
        }
        public void WriteResponse(List<ResponseLogDTO> model)
        {
            File.WriteAllText(_filePathResponse, JsonConvert.SerializeObject(model));
        }
    }
}
