using FakeItEasy;
using Mastery.Region.API.Controllers;
using Mastery.Region.Entity.Models;
using Mastery.Region.Repos.Contracts;
using Mastery.Region.UnitTests.TestData;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;

namespace Mastery.Region.UnitTests.Tests
{
    [TestFixture]
    public class BatchInfoControllerTests
    {
        BatchInfoController _batchInfoController;
        BatchInfoTestData _testData;
        IRepositoryWrapper _repos;
        
        [SetUp]
        public void Setup()
        {
            _repos = A.Fake<IRepositoryWrapper>();
            _batchInfoController = new BatchInfoController(_repos);
            _testData = new BatchInfoTestData();
        }

        [Test]
        public void Process_PostReturns_OKStatusCode()
        {
            //Arrange
            BatchInfo testData = _testData.GeneratePutMethodInput();

            //Act
            var response = _batchInfoController.Post(testData);
            var res = (StatusCodeResult)response;

            //Assert
            Assert.AreEqual(200, res.StatusCode);
        }

        [Test]
        public void Process_GetReturns_OKStatusCode()
        {
            //Act
            var response = _batchInfoController.Get();
            var res = response.StatusCode;

            //Assert
            Assert.AreEqual(200, res);
        }

        [Test]
        public void Process_GetByIdReturns_OKStatusCode()
        {
            //Arrange
            var testId = "7a31519b-1614-4784-9b34-ac055b0ca571";

            //Act
            var response = _batchInfoController.GetById(testId);
            var res = response.StatusCode;

            //Assert
            Assert.AreEqual(200, res);
        }

        [Test]
        public void Process_EditReturns_OKStatusCode()
        {
            //Arrange
            BatchInfo testData = _testData.GeneratePutMethodInput();

            //Act
            var response = _batchInfoController.Edit(testData);
            var res = (StatusCodeResult)response;

            //Assert
            Assert.AreEqual(200, res.StatusCode);
        }

        [Test]
        public void Process_DeleteReturns_OKStatusCode()
        {
            //Arrange
            BatchInfo testData = _testData.GeneratePutMethodInput();

            //Act
            var response = _batchInfoController.Delete(testData);
            var res = (StatusCodeResult)response;

            //Assert
            Assert.AreEqual(200, res.StatusCode);
        }
    }
}