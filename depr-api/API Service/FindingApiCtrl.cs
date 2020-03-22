using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using vdivsvirus.Interfaces;
using vdivsvirus.Types;

namespace vdivsvirus.Services
{


    [Route("api/[controller]")]
    [ApiController]
    public class FindingController : ControllerBase
    {
        private readonly IResponseService responseService;


        public FindingController(IResponseService service)
        {
            if (service == null) throw new ArgumentNullException("No response service");
            responseService = service;
        }
            


        // GET api/finding/NewFindingAvailable
        [HttpGet("NewFindingAvailable")]
        public ActionResult<bool> NewFindingAvailable([FromQuery] Guid id, [FromQuery]  DateTime time)
        {
            var test = this;

            return responseService.NewFindingAvailable(id, time);
        }

        // GET api/finding/RequestFinding
        [HttpGet("RequestFinding")]
        public ActionResult<UserResponseDataSet> RequestFinding(Guid id, DateTime time)
        {
            return responseService.RequestFinding(id, time);
        }

        // GET api/finding/RequestFindingHistory
        [HttpGet("RequestFindingHistory")]
        public ActionResult<UserHistoryDataSet> RequestFindingHistory(Guid id)
        {
            return responseService.RequestFindingHistory(id);
        }
    }
}
