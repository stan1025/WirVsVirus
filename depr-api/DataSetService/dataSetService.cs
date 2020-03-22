using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vdivsvirus.Interfaces;
using vdivsvirus.Types;

namespace vdivsvirus.Services
{

    public class UserDataSet
    {
        public Guid Ident { get; set; }
        public DateTime Time { get; set; }
        public List<GeoData> GeoProfile { get; set; }
        public List<SymptomeInputData> Symptomes { get; set; }
        public List<DiseaseData> RawPropabilities { get; set; }
        public List<DiseaseData> ExtPropabilities { get; set; }
        public List<DiseaseAcknowledgement> Acknowledments { get; set; }
    }


    public class DataSetService : IRequestDataSet, ISendSymptome
{
        private readonly IKnowledgeService knowledgeService;

        private object tableLock = new object();

        private List<UserDataSet> table = new List<UserDataSet>();

        public DataSetService(IKnowledgeService service)
        {
            if (service == null) throw new ArgumentNullException("No Knowledge Service available");
            knowledgeService = service;
        }

        /// <summary>
        /// returns true if a new DataSet for PDA analysis is available
        /// </summary>
        /// <returns></returns>
        public bool DataSetAvailable()
        {
            lock (tableLock)
            {
                //Es gibt ein Datensatz der noch keine RawPropability - Eintragung hat
                return table.Any(item => item.RawPropabilities == null);
            }
        }

        /// <summary>
        /// returns the next to analyse dataset for the PDA analysis.
        /// </summary>
        /// <returns></returns>
        public SymptomeDataSet RequestDataSet()
        {
            lock(tableLock)
            {
                var unprocessed = table.FirstOrDefault(item => item.RawPropabilities == null);
                return new SymptomeDataSet() {userID = unprocessed.Ident, time = unprocessed.Time, symptomes = unprocessed.Symptomes};

            }
        }

        /// <summary>
        /// returns the propabilit data, extended propability if available, otherwise the raw propability.
        /// </summary>
        /// <param name="userID">User ID</param>
        /// <param name="time">Dataset Timestamp</param>
        /// <returns>propabilit data</returns>
        public PropabilityDataSet RequestDiseasePropability(Guid userID, DateTime time)
        {
            lock(tableLock)
            {
                var prob = table.FirstOrDefault(item => item.Ident.Equals(userID) && item.Time.Equals(time));
                return new PropabilityDataSet()
                    {userID = userID, time = time, propabilities = prob.ExtPropabilities ?? prob.RawPropabilities};
            }
        }

        /// <summary>
        /// Propability Result of the PDA Analysis
        /// </summary>
        /// <param name="data"></param>
        public void SendDataResultSet(PropabilityDataSet data)
        {
            lock(tableLock)
            {
                UserDataSet dataSet = table.FirstOrDefault(item => item.Ident.Equals(data.userID) && item.Time.Equals(data.time));
                dataSet.RawPropabilities = data.propabilities;
            }
        }

        /// <summary>
        /// Insert the acknowledged test result 
        /// from a medical doctor. 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public bool SendDiseaseDataSet(DiseaseAcknowledgeSet data)
        {
            try
            {
                if (data.authenticator.userName.Equals("Dr. Stutz")) return false;
                lock (tableLock)
                {
                    UserDataSet dataSet = table.FirstOrDefault(item => item.Ident.Equals(data.userID) && item.Time.Equals(data.time));
                    dataSet.Acknowledments.Add(new DiseaseAcknowledgement() { id = data.diseaseID, acknowledged = data.testResult });
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }



        public bool SendSymptomeDataSet(SymptomeInputDataSet data)
        {
            try
            {
                lock (tableLock)
                {
                    table.Add(new UserDataSet() { Ident = data.userID, Time = data.time, Symptomes = data.symptomes, GeoProfile = data.geodata, Acknowledments = new List<DiseaseAcknowledgement>(), ExtPropabilities = null, RawPropabilities = null });
                }

                return true;
            }
            catch
            {
                return false;
            }
        }




        #region History Feature (not implemented)


        public bool HistorySetAvailable()
        {
            throw new NotImplementedException();
        }


        public void SendHistoryResultSet(PropabilityDataSet data)
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


        #endregion



    }







}
