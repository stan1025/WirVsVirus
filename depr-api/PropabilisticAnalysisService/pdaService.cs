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
            // Calculate the disease probability
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
            propabilityResults.Add(1, input.symptomes.Select(item => GetSymptomeBias(item)).Sum());
        }



        //private KeyValuePair<int, float> Calculate_Influenza(SymptomeInputDataSet input)
        //{
        //    var result = sympInternals.GetSymptomeData(input.symptomes.First());
        //}


        /// <summary>
        /// Combined Method to establish the right internal symptome data
        /// and apply its scaling function.
        /// After scaling the input value it will be multiplied with the propability factor
        /// which is also constant in the symptome type data. 
        /// </summary>
        /// <param name="sympInt">Internal Symptome Data Table</param>
        /// <param name="input">Input Item</param>
        /// <returns>Related Propability Factor</returns>
        public float GetSymptomeBias(KeyValuePair<int, float> input)
        {
            SymptomeType symp = sympInternals.FirstOrDefault(item => item.IdentData.id.Equals(input.Key));
            if (symp == null)
            {
                return 0f;
            }
            else
            {
                return (symp.symptomePropability * GetPropSum()/100) * symp.ScaleFunc(input.Value);
            }
        }

        public float GetPropSum()
        {
            return sympInternals.Select(item => item.symptomePropability).Sum();
        }
    }

}
