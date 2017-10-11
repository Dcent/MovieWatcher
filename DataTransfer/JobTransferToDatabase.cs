using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransfer.DbMapper;
using DataTransfer.Interfaces;
using Enties;

namespace DataTransfer
{
    public class JobTransferToDatabase : IJobTransfer
    {
        public Job SaveJob(Job j)  
        {
            using (var db = new JobContent())
            {
               db.Jobs.Add(j);
            }

            return j;
        }
    }
}
