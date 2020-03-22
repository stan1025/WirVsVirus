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
        [HttpPost("NewFindingAvailable")]
        public ActionResult<bool> NewFindingAvailable([FromBody] UserDataRef dataRef)
        {
            return responseService.NewFindingAvailable(dataRef.userID, dataRef.time);
        }

        // GET api/finding/RequestFinding
        [HttpPost("RequestFinding")]
        public ActionResult<UserResponseDataSet> RequestFinding([FromBody] UserDataRef dataRef)
        {
            return responseService.RequestFinding(dataRef.userID, dataRef.time);
        }

        // GET api/finding/RequestFindingHistory
        [HttpGet("RequestFindingHistory")]
        public ActionResult<UserHistoryDataSet> RequestFindingHistory(Guid id)
        {
            return responseService.RequestFindingHistory(id);
        }
    }
}
