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
        private readonly IKnowledgeService knowledgeService;


        public SymptomeController(ISendSymptome service, IKnowledgeService knowService)
        {
            if (service == null) throw new ArgumentNullException("No data service available");
            dataService = service;
            if (knowService == null) throw new ArgumentNullException("No knowledge service available");
            knowledgeService = knowService;
        }

        // GET api/symptome/GetSymptomeTypes
        [HttpGet("GetSymptomeTypes")]
        public ActionResult<IEnumerable<SymptomeIdentData>> GetSymptomeTypes()
        {
            return knowledgeService.GetSymptomeIdentData();
            
        }

        // POST api/symptome/SendDiseaseDataSet
        [HttpPost("SendDiseaseDataSet")]
        public void SendDiseaseDataSet(Guid id, DiseaseAcknowledgeSet value)
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
