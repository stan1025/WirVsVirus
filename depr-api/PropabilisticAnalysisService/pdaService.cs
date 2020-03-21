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
        Dictionary<int, float> propabilityResults;


        private readonly List<SymptomeType> sympInternals;

        public pdaService(IRequestDataSet service)
        {
            if (service == null) throw new ArgumentNullException("No data service");
            dataService = service;

            sympInternals = dataService.GetSymptomeInternals();
        }

        internal override bool Check()
        {
            return dataService.DataSetAvailable();
        }

        internal override void Execute()
        {
            propabilityResults = new Dictionary<int, float>();
            inputData = dataService.RequestDataSet();

            executeAnalyzing();

            dataService.SendDataResultSet(outputData);
        }

        private void executeAnalyzing()
        {
            //do the magic what ever you want :-P
            Calculate_Covid19(inputData);




            outputData = new PropabilityDataSet()
            {
                userID = inputData.userID,
                time = inputData.time,
                propabilities = propabilityResults
            };
        }



        private void Calculate_Covid19(SymptomeDataSet input)
        {
            (float prop,float val) = sympInternals.GetSymptomeData(input.symptomes.First());


            propabilityResults.Add(1, prop * val);
        }



        //private KeyValuePair<int, float> Calculate_Influenza(SymptomeInputDataSet input)
        //{
        //    var result = sympInternals.GetSymptomeData(input.symptomes.First());
        //}



    }


    public static class PDAServiceExtension
    {
        public static Tuple<float, float> GetSymptomeData(this List<SymptomeType> sympInt, KeyValuePair<int, float> input)
        {
            SymptomeType symp = sympInt.FirstOrDefault(item => item.id.Equals(input.Key));
            if (symp == null)
            {
                return new Tuple<float, float>(0f, 0f);
            }
            else
            {
                return new Tuple<float, float>(symp.symptomePropability, symp.ScaleFunc(input.Value));
            }
        }
    }
}
