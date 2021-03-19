using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HW8.Abstract
{
    public class Resource
    {
        //TODO : HBK - Property Order neden calismiyor
        [JsonProperty(Order = -1)]
        public string Href { get; set; }
    }
}
