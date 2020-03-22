using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using vdivsvirus.Interfaces;
using vdivsvirus.Types;

namespace vdivsvirus.Services
{
    [Route("api/[controller]")]
    [ApiController]
    public class SymptomeController : ControllerBase
    {
        private readonly ISendSymptome dataService;


        public SymptomeController(ISendSymptome service)
        {
            if (service == null) throw new ArgumentNullException("No data service");
            dataService = service;
        }

        // GET api/symptome/GetSymptomeTypes
        [HttpGet("GetSymptomeTypes")]
        public ActionResult<IEnumerable<SymptomeType>> GetSymptomeTypes()
        {
            return dataService.GetSymptomeTypes();
            
        }

        // POST api/symptome/SendDiseaseDataSet
        [HttpPost("SendDiseaseDataSet")]
        public void SendDiseaseDataSet(Guid id, DiseaseDataSet value)
        {
            dataService.SendDiseaseDataSet(value);
        }

        // POST api/symptome/SendSymptomeDataSet
        [HttpPost("SendSymptomeDataSet")]
        public void SendSymptomeDataSet([FromBody] SymptomeInputDataSet value)
        {
            dataService.SendSymptomeDataSet(value);
        }
    }

}
