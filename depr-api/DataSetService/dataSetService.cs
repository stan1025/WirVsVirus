using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vdivsvirus.Interfaces;
using vdivsvirus.types;

namespace vdivsvirus.Services
{
    public class DataSetService : IRequestDataSet, ISendSymptome
{

        public DataSetService()
        {

        }

        public bool DataSetAvailable()
        {
            throw new NotImplementedException();
        }

        public List<SymptomeType> GetSymptomeTypes()
        {
            throw new NotImplementedException();
        }

        public bool HistorySetAvailable()
        {
            throw new NotImplementedException();
        }

        public SymptomeDataSet RequestDataSet()
        {
            throw new NotImplementedException();
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
