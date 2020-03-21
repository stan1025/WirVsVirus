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
    public class SymptomeApiController : ControllerBase
    {
        private readonly ISendSymptome dataService;


        public SymptomeApiController(ISendSymptome service)
        {
            if (service == null) throw new ArgumentNullException("No data service");
            dataService = service;
        }

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

}
