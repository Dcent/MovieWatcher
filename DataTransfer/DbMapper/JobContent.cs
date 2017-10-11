using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enties;

namespace DataTransfer.DbMapper
{
    class JobContent : DbContext
    {
        public DbSet<Job> Jobs { get; set; }
    }
}
