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

        public bool NewFindingAvailable(Guid id)
        {
            throw new NotImplementedException();
        }

        public UserResponseDataSet RequestFinding(Guid userId)
        {
            throw new NotImplementedException();
        }

        public UserHistoryDataSet RequestFindingHistory(Guid userId)
        {
            throw new NotImplementedException();
        }
    }
}
