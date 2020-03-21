using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vdivsvirus.Interfaces;

namespace vdivsvirus.Services
{
    public class pgaService : CyclicBackgroundService
    {
        private readonly IRequestDataSet dataService;

        public pgaService(IRequestDataSet service)
        {
            if (service == null) throw new ArgumentNullException("No data service");
            dataService = service;
        }

        internal override bool Check()
        {
            throw new NotImplementedException();
        }

        internal override void Execute()
        {
            throw new NotImplementedException();
        }

        private void executeAnalyzing()
        {
            //do the magic what ever you want :-P
        }


    }
}
