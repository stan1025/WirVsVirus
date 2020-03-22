using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vdivsvirus.Interfaces;
using vdivsvirus.Types;

namespace vdivsvirus.Services
{
    public class ResponseService : IResponseService
    {

        private readonly IRequestDataSet dataService;

        public ResponseService(IRequestDataSet service)
        {
            if (service == null) throw new ArgumentNullException("No data service");
            dataService = service;
        }

        public bool NewFindingAvailable(Guid userId, DateTime time)
        {
            return dataService.RequestDiseasePropability(userId, time).propabilities.Count != 0;
        }

        public UserResponseDataSet RequestFinding(Guid userId, DateTime time)
        {
            return CreateUserReport(userId, time);
        }

        public UserHistoryDataSet RequestFindingHistory(Guid userId)
        {
            return CreateHistoryReport(userId);
        }



        private UserResponseDataSet CreateUserReport(Guid userId, DateTime time)
        {
            PropabilityDataSet sourceData = dataService.RequestDiseasePropability(userId, time);

            UserResponseDataSet res = new UserResponseDataSet();
            res.userID = userId;
            res.time = time;
            res.propabilities = sourceData.propabilities;
            res.message = "Das ist eine Test Nachricht";
            return res;
        }

        private UserHistoryDataSet CreateHistoryReport(Guid userId)
        {
            PropabilityHistorySet sourceData = dataService.RequestDiseasePropabilityHistory(userId);

            UserHistoryDataSet res = new UserHistoryDataSet();
            res.userID = userId;
            res.history = sourceData.history;
            res.message = "Das ist eine History Nachricht";
            return res;
        }

    }
}
