using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using vdivsvirus.Interfaces;
using vdivsvirus.types;

namespace vdivsvirus.Services
{


    [Route("api/[controller]")]
    [ApiController]
    public class FindingApiController : ControllerBase
    {
        private readonly IResponseService responseService;


        public FindingApiController(IResponseService service)
        {
            if (service == null) throw new ArgumentNullException("No response service");
            responseService = service;
        }
            


        // GET api/finding/NewFindingAvailable
        [HttpGet("NewFindingAvailable")]
        public ActionResult<bool> NewFindingAvailable()
        {
            return false;
        }

        // GET api/finding/RequestFinding
        [HttpGet("RequestFinding/{id}")]
        public ActionResult<UserResponseDataSet> RequestFinding(Guid id)
        {
            return new UserResponseDataSet();
        }

        // GET api/finding/RequestFindingHistory
        [HttpGet("RequestFindingHistory/{id}")]
        public ActionResult<UserHistoryDataSet> RequestFindingHistory(Guid id)
        {
            return new UserHistoryDataSet();
        }
    }
}
