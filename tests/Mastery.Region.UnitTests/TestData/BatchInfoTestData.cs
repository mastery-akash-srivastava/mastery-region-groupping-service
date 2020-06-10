using Mastery.Region.Entity.Models;
using System;

namespace Mastery.Region.UnitTests.TestData
{
    class BatchInfoTestData
    {
        public BatchInfo GeneratePutMethodInput()
        {
            BatchInfo batchInfo = new BatchInfo();
            batchInfo.FileName = "UnitTest.xlsx";
            batchInfo.Comment = "Unit testing";
            batchInfo.ExpiryDate = new DateTime();
            batchInfo.CreatedAt = new DateTime();
            batchInfo.CreatedBy = "TestUser";
            batchInfo.UpdatedAt = new DateTime();
            batchInfo.UpdatedBy = "TestUser";

            return batchInfo;
        }
    }
}
