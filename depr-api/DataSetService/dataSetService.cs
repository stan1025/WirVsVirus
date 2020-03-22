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
        private readonly IKnowledgeService knowledgeService;

        public DataSetService(IKnowledgeService service)
        {
            if (service == null) throw new ArgumentNullException("No Knowledge Service available");
            knowledgeService = service;
        }

        public bool DataSetAvailable()
        {
            return true;
        }

        [Obsolete]
        public List<SymptomeType> GetSymptomeInternals()
        {
            return knowledgeService.GetSymptomeTypes();
        }

        [Obsolete]
        public List<SymptomeIdentData> GetSymptomeTypes()
        {
            return knowledgeService.GetSymptomeIdentData();
        }

        public bool HistorySetAvailable()
        {
            throw new NotImplementedException();
        }

        public SymptomeDataSet RequestDataSet()
        {
            return new SymptomeDataSet()
            {
                userID = Guid.NewGuid(),
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
            return new PropabilityDataSet()
            {
                userID = userID,
                time = time,
                propabilities = new Dictionary<int, float>()
                {
                    [1] = 20
                }
            };
        }

        public PropabilityHistorySet RequestDiseasePropabilityHistory(Guid userID)
        {
            throw new NotImplementedException();
        }

        public PropabilityHistorySet RequestHistorySet()
        {
            throw new NotImplementedException();
        }

        public void SendDataResultSet(PropabilityDataSet data)
        {
            throw new NotImplementedException();
        }

        public void SendDiseaseDataSet(DiseaseDataSet data)
        {
            System.Diagnostics.Trace.Write(data);
        }

        public void SendHistoryResultSet(PropabilityDataSet data)
        {
            throw new NotImplementedException();
        }

        public void SendSymptomeDataSet(SymptomeInputDataSet data)
        {
            System.Diagnostics.Trace.Write(data);
        }
    }







}
