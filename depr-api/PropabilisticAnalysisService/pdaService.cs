using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vdivsvirus.Interfaces;
using vdivsvirus.Types;

namespace vdivsvirus.Services
{
    public class pdaService : CyclicBackgroundService
    {
        private readonly IKnowledgeService knowledgeService;
        private readonly IRequestDataSet dataService;

        SymptomeDataSet inputData;
        PropabilityDataSet outputData;
        Dictionary<int, float> results;

        public pdaService(IRequestDataSet reqService, IKnowledgeService knowService)
        {
            if (reqService == null) throw new ArgumentNullException("No data service available");
            dataService = reqService;
            if (knowService == null) throw new ArgumentNullException("No knowledge service available");
            knowledgeService = knowService;
        }

        internal override bool Check()
        {
            return dataService.DataSetAvailable();
        }

        internal override void Execute()
        {
            results = new Dictionary<int, float>();
            inputData = dataService.RequestDataSet();

            executeAnalyzing();

            dataService.SendDataResultSet(outputData);
        }

        private void executeAnalyzing()
        {
            outputData = new PropabilityDataSet()
            {
                userID = inputData.userID,
                time = inputData.time,
                propabilities = knowledgeService.GetDiseaseTypes().ToDictionary(key => key.IdentData.id, val => val.propabilityAlgorithm(inputData))
            };
        }







    }

}
