using System.Collections.Generic;
using CallManagement.DataAccess.Interfaces;
using DeliveryManagement.DataAccess.Entities.SQLEntities;
using Microsoft.AspNetCore.Mvc;

namespace DeliveryAppAdoDapperWebApi.WEBAPI.Controllers
{
    public class CallController : ControllerBase
    {
        #region Properties

        private ISqlCallService _callService;

        #endregion

        #region Constructors

        public CallController()
        {

        }

        public CallController(ISqlCallService callService)
        {
            _callService = callService;
        }

        #endregion
        [Route("Calls")]
        [HttpGet]
        public IEnumerable<SqlCall> Get()
        {
            return _callService.GetAllCalls();
        }

        [Route("Call/{Id}")]
        [HttpGet]
        public SqlCall Get(int id)
        {
            return _callService.GetCallById(id);
        }

        [Route("Call")]
        [HttpPost]
        public long Post([FromBody]SqlCall call)
        {
            return _callService.AddCall(call);
        }

        [Route("Call/{Call}")]
        [HttpPut]
        public void Put([FromBody]SqlCall call)
        {
            _callService.UpdateCall(call);
        }

        [Route("Call/{Call}")]
        [HttpDelete]
        public void Delete([FromBody]SqlCall call)
        {
            _callService.DeleteCall(call);
        }
    }
}
