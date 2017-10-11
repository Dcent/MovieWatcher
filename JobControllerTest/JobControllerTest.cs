using System;
using Enties;
using JobController;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JobControllerTest
{
    [TestClass]
    public class JobControllerTest
    {
        [TestMethod]
        public void ShouldBeAbleToSaveAJob()
        {
            //Assign
            var j = new Job()
            {
                SourcePath = "",
                DestinationPath = "",
                Started = DateTime.Now,
                Ended = DateTime.Now.AddMinutes(1),
                Ftp = true,
                StatusCode = StatusCodeEnum.Success
            };
            JobCreater jc = new JobCreater(new JobTransferMockup());

            //Action
            var savedJob = jc.SendJobToTransfer(j);

            //Assert
            Assert.AreSame(savedJob, j, "The jobs are not the same.");
        }
    }
}
