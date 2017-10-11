using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enties
{
    public class Job
    {
        public int JobId { get; set; }
        public string SourcePath { get; set; }
        public string DestinationPath { get; set; }
        public DateTime Started { get; set; }
        public DateTime Ended { get; set; }
        public bool Ftp { get; set; }
        public virtual StatusCodeEnum StatusCode { get; set; }
    }
}
