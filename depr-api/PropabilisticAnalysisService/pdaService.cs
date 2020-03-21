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
        private readonly IRequestDataSet dataService;
        SymptomeDataSet inputData;
        PropabilityDataSet outputData;


        public pdaService(IRequestDataSet service)
        {
            if (service == null) throw new ArgumentNullException("No data service");
            dataService = service;
        }

        internal override bool Check()
        {
            return dataService.DataSetAvailable();
        }

        internal override void Execute()
        {
            var data = dataService.RequestDataSet();

            executeAnalyzing();

            dataService.SendDataResultSet(outputData);
        }

        private void executeAnalyzing()
        {
            //do the magic what ever you want :-P
        }


}
}
