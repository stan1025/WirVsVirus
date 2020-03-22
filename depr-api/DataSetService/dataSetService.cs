using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vdivsvirus.Interfaces;
using vdivsvirus.Types;

namespace vdivsvirus.Services
{
    public class DataSetService : IRequestDataSet, ISendSymptome
{

        public DataSetService()
        {

        }

        public bool DataSetAvailable()
        {
            return true;
        }

        public List<SymptomeType> GetSymptomeInternals()
        {
            return new List<SymptomeType>()
            {
                new SymptomeType{ id = 1, DisplayData = new SymptomeDisplayData() { inputType = SymptomeInputType.slider, desc = "", name = "Fieber", settings="min=36.5;max=42.5;step=0.1" }, symptomePropability = (float)87.9, ScaleFunc = input => input * 1000 } ,
                new SymptomeType{ id = 2, DisplayData = new SymptomeDisplayData() { inputType = SymptomeInputType.slider, desc = "", name = "Husten", settings="min=0;max=100;step=1" }, symptomePropability = (float)67.7 },
                new SymptomeType{ id = 3, DisplayData = new SymptomeDisplayData() { inputType = SymptomeInputType.slider, desc = "", name = "Abgeschlagenheit", settings="min=0;max=100;step=1" }, symptomePropability = (float)38.1 },
                new SymptomeType{ id = 4, DisplayData = new SymptomeDisplayData() { inputType = SymptomeInputType.slider, desc = "", name = "Kurzatmigkeit", settings="min=0;max=100;step=1" }, symptomePropability = (float)18.6 },
                new SymptomeType{ id = 5, DisplayData = new SymptomeDisplayData() { inputType = SymptomeInputType.slider, desc = "", name = "Muskel-/Gelenkschmerz", settings="min=0;max=100;step=1" }, symptomePropability = (float)14.8},
                new SymptomeType{ id = 6, DisplayData = new SymptomeDisplayData() { inputType = SymptomeInputType.slider, desc = "", name = "Halsschmerz", settings="min=0;max=100;step=1" } , symptomePropability = (float)13.9},
                new SymptomeType{ id = 7, DisplayData = new SymptomeDisplayData() { inputType = SymptomeInputType.slider, desc = "", name = "Kopfschmerz", settings="min=0;max=100;step=1" }, symptomePropability = (float)13.6 },
                new SymptomeType{ id = 8, DisplayData = new SymptomeDisplayData() { inputType = SymptomeInputType.slider, desc = "", name = "Schüttelfrost", settings="min=0;max=100;step=1" }, symptomePropability = (float)11.4 },
                new SymptomeType{ id = 9, DisplayData = new SymptomeDisplayData() { inputType = SymptomeInputType.slider, desc = "", name = "Übelkeit", settings="min=0;max=100;step=1" } , symptomePropability = (float)5.0},
                new SymptomeType{ id = 10, DisplayData = new SymptomeDisplayData() { inputType = SymptomeInputType.slider, desc = "", name = "Verstopfte Nase", settings="min=0;max=100;step=1" } , symptomePropability = (float)4.8},
                new SymptomeType{ id = 11, DisplayData = new SymptomeDisplayData() { inputType = SymptomeInputType.slider, desc = "", name = "Durchfall", settings="min=0;max=100;step=1" } , symptomePropability = (float)3.7},
            };

        }

        public List<SymptomeDisplayData> GetSymptomeTypes()
        {
            return GetSymptomeInternals().Select(item => item.DisplayData).ToList();
        }

        public bool HistorySetAvailable()
        {
            throw new NotImplementedException();
        }

        public SymptomeDataSet RequestDataSet()
        {
            return new SymptomeDataSet() 
            { userID = Guid.NewGuid(), 
              time = DateTime.Now, 
              symptomes = new Dictionary<int, float>() 
              { 
                  [1] = 70f,
                  [2] = 80f,
                  [3] = 60f,
                  [4] = 30f,
                  [5] = 40f,
                  [6] = 30f,
                  [7] = 20f,
                  [8] = 70f,
                  [9] = 0f,
                  [10] = 40f,
                  [11] = 0f,
              },

            };
        }

        public PropabilityDataSet RequestDiseasePropability(Guid userID, DateTime time)
        {
            throw new NotImplementedException();
        }

        public PropabilityHistorySet RequestDiseasePropabilityHistory(Guid userID)
        {
            throw new NotImplementedException();
        }

        public PropabilityHistorySet RequestHistorySet()
        {
            throw new NotImplementedException();
        }

        public ServiceResponse SendDataResultSet(PropabilityDataSet data)
        {
            throw new NotImplementedException();
        }

        public ServiceResponse SendDiseaseDataSet(DiseaseDataSet data)
        {
            throw new NotImplementedException();
        }

        public ServiceResponse SendHistoryResultSet(PropabilityDataSet data)
        {
            throw new NotImplementedException();
        }

        public ServiceResponse SendSymptomeDataSet(SymptomeInputDataSet data)
        {
            System.Diagnostics.Trace.Write(data);
            return ServiceResponse.OK();
        }
    }
}
