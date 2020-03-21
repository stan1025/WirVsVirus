using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using vdivsvirus.types;

namespace vdivsvirus.Services
{
    [Route("api/[controller]")]
    [ApiController]
    public class SymptomeController : ControllerBase
    {
        // GET api/symptome/GetSymptomeTypes
        [HttpGet("GetSymptomeTypes")]
        public ActionResult<IEnumerable<SymptomeType>> GetSymptomeTypes()
        {
            return new List<SymptomeType>();
        }

        // POST api/symptome/SendDiseaseDataSet
        [HttpPost("SendDiseaseDataSet/{id}")]
        public void SendDiseaseDataSet([FromBody] DiseaseDataSet value)
        {
        }

        // POST api/symptome/SendSymptomeDataSet
        [HttpPost("SendSymptomeDataSet")]
        public void SendSymptomeDataSet([FromBody] SymptomeInputData value)
        {
        }
    }

    [Route("api/[controller]")]
    [ApiController]
    public class FindingController : ControllerBase
    {
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
