using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vdivsvirus.Interfaces;

namespace vdivsvirus.Services
{
    public class pdaService
{
        private readonly IRequestDataSet dataService;

        public pdaService(IRequestDataSet service)
        {
            if (service == null) throw new ArgumentNullException("No data service");
            dataService = service;
        }



        private void executeAnalyzing()
        {
            //do the magic what ever you want :-P
        }


}
}
