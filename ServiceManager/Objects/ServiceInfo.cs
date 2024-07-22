using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceManager
{
    public class ServiceInfo
    {
        public string ServiceName {  get; set; }

        public int ServiceVersion { get; set; }

        public string ServiceDescription { get; set; }

        public DateTime ServiceAdditionDate { get; set; }

        public string ServiceFilePath { get; set; }
    }
}
