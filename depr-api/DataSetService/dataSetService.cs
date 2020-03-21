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

        public List<SymptomeType> GetSymptomeTypes()
        {
            return new List<SymptomeType>()
            {
                new SymptomeType{ id = 1, classifier = SymptomeClassifier.none, desc = "", name = "Fieber" },
                new SymptomeType{ id = 2, classifier = SymptomeClassifier.none, desc = "", name = "Husten" },
                new SymptomeType{ id = 3, classifier = SymptomeClassifier.none, desc = "", name = "Abgeschlagenheit" },
                new SymptomeType{ id = 4, classifier = SymptomeClassifier.none, desc = "", name = "Kurzatmigkeit" },
                new SymptomeType{ id = 5, classifier = SymptomeClassifier.none, desc = "", name = "Muskel-/Gelenkschmerz" },
                new SymptomeType{ id = 6, classifier = SymptomeClassifier.none, desc = "", name = "Halsschmerz" },
                new SymptomeType{ id = 7, classifier = SymptomeClassifier.none, desc = "", name = "Kopfschmerz" },
                new SymptomeType{ id = 8, classifier = SymptomeClassifier.none, desc = "", name = "Schüttelfrost" },
                new SymptomeType{ id = 9, classifier = SymptomeClassifier.none, desc = "", name = "Übelkeit" },
                new SymptomeType{ id = 10, classifier = SymptomeClassifier.none, desc = "", name = "Verstopfte Nase" },
                new SymptomeType{ id = 11, classifier = SymptomeClassifier.none, desc = "", name = "Durchfall" },
            };

        }

        public bool HistorySetAvailable()
        {
            throw new NotImplementedException();
        }

        public SymptomeDataSet RequestDataSet()
        {
            return new SymptomeDataSet() { userID = Guid.NewGuid(), time = DateTime.Now, symptomes = new Dictionary<int, SymptomeStrength>() { [1] = SymptomeStrength.strong } };
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

        public ServiceResponse SendSymptomeDataSet(SymptomeInputData data)
        {
            throw new NotImplementedException();
        }
    }
}
