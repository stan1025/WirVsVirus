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

    /// <summary>
    /// Data Service
    /// For storing and persisting data from all users
    /// 
    /// Attention:
    /// For the Hackathon the data is managed in memory
    /// and is not persisted.
    /// 
    /// In a proper application environment the data
    /// should be stored in a DataBase
    /// </summary>
    public class DataSetService : IRequestDataSet, ISendSymptome
    {
        private readonly IKnowledgeService knowledgeService;

        /// <summary>
        /// Data Lock for access to <see cref="table"/> safe multi-threading
        /// </summary>
        private object tableLock = new object();

        /// <summary>
        /// Data Store with data input from user and calculated values from PDA Service
        /// </summary>
        private List<UserDataSet> table = new List<UserDataSet>();

        /// <summary>
        /// Constructor with relevant service references
        /// </summary>
        /// <param name="service">Required KnowledgeService</param>
        public DataSetService(IKnowledgeService service)
        {
            knowledgeService = service ?? throw new ArgumentNullException("No Knowledge Service available");
        }

        /// <summary>
        /// returns true if a new DataSet for PDA analysis is available
        /// </summary>
        /// <returns></returns>
        public bool DataSetAvailable()
        {
            lock (tableLock)
            {
                // Check for data entry without calculated RawProbability
                return table.Any(item => item.RawPropabilities == null);
            }
        }

        /// <summary>
        /// returns the next to analyze dataset for the PDA analysis.
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
        /// returns the probability data, extended probability if available, otherwise the raw probability.
        /// </summary>
        /// <param name="userID">User ID</param>
        /// <param name="time">Dataset Timestamp</param>
        /// <returns>probability data</returns>
        public PropabilityDataSet RequestDiseasePropability(Guid userID, DateTime time)
        {
            lock(tableLock)
            {
                var prob = table.FirstOrDefault(item => item.Ident.Equals(userID) && item.Time.Equals(time));
                var propabilities = prob?.ExtPropabilities ?? prob?.RawPropabilities;
                if (propabilities == null) return null;
                return new PropabilityDataSet()
                    {userID = userID, time = time, propabilities = propabilities };
            }
        }

        /// <summary>
        /// Probability Result of the PDA Analysis
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

        /// <summary>
        /// Save Symptom Data of user
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
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
