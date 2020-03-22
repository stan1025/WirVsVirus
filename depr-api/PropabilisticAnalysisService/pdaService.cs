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
            
            //Propability of the symptoms
            float prop_symp= propabilityResults.prop;
            float mean_prop = prop_symp.Average;
            float prop_symp_mean = prop_symp / mean_prop; //Gerne auch als Schleife ;)



            //Severity of the users symptoms
            float sev_user = propabilityResults.val;
            float sev_user_per = propabilityResults.val*10; //points -> percent


            //Probability to have COVID-19
            float prop_disease_all = sev_user_per * prop_symp_mean;   //Gerne auch als Schleife ;)
            float prop_disease = prop.disease_all.sum; 

            float threshold = 0.5;
            bool covid = false;
            if (prop_disease > threshold)
                {
                covid = true;
            }


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
