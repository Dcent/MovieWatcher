using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransfer.Interfaces;
using Enties;

namespace JobController
{
    public class JobCreater
    {
        private readonly IJobTransfer _jt;

        public JobCreater(IJobTransfer jt)
        {
            _jt = jt;
        }

        public Job SendJobToTransfer(Job job)
        {
            Job j = _jt.SaveJob(job);
            return j;
        }
    }
}
