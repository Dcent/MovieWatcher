using DataTransfer.Interfaces;
using Enties;

namespace JobControllerTest
{
    public class JobTransferMockup : IJobTransfer
    {
        public Job SaveJob(Job j)
        {
            return j;
        }
    }
}