using Mastery.Region.Entity.Models;
using Mastery.Region.Repos.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace Mastery.Region.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BatchInfoController : ControllerBase
    {
        IRepositoryWrapper _repositoryWrapper;

        public BatchInfoController(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        [HttpGet]
        public IStatusCodeActionResult Get()
        {
            var data = _repositoryWrapper.BatchInfo.FindAll();
            return StatusCode(200,data);
        }

        [Route("~/batchinfo/GetById")]
        [HttpGet]
        public IStatusCodeActionResult GetById(string id)
        {
            var data = _repositoryWrapper.BatchInfo.FindByCondition( o => o.Id.ToString() == id);
            return StatusCode(200, data);
        }

        [Route("~/batchinfo/postbatch")]
        [HttpPost]
        public IActionResult Post([FromBody] BatchInfo batchInfo)
        {
            _repositoryWrapper.BatchInfo.Create(batchInfo);
            _repositoryWrapper.Save();
            return Ok();
        }

        [Route("~/batchinfo/deletebatch")]
        [HttpDelete]
        public IActionResult Delete([FromBody] BatchInfo batchInfo)
        {
            _repositoryWrapper.BatchInfo.Delete(batchInfo);
            _repositoryWrapper.Save();
            return Ok();
        }

        [Route("~/batchinfo/editbatch")]
        [HttpPut]
        public IActionResult Edit([FromBody] BatchInfo batchInfo)
        {
            _repositoryWrapper.BatchInfo.Update(batchInfo);
            _repositoryWrapper.Save();
            return Ok();
        }
    }
}
