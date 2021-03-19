using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Week2HWW.Model;

namespace Week2HWW.Extensions
{
    public static class MappingExtension
    {
        public static List<ScanPrintModel> ToScanPrints(this List<ScanPrint> scanPrints)
        {
            List<ScanPrintModel> result = new List<ScanPrintModel>();

            foreach (var item in scanPrints)
            {
                result.Add(new ScanPrintModel
                {
                    Id = item.Id,
                    Name = item.Name,
                    Model = item.Model,
                    Copy = item.Copy
                });

            }
           
            return result;
        }
    }
}
