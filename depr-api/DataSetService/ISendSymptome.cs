using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vdivsvirus.Types;

namespace vdivsvirus.Interfaces
{
    /**
     * SendSymptome-Service
     * ... UI Service (Client)
     * ... DataSet Service (Server)
     */
    public interface ISendSymptome
    {
        /**
        * SendSymptomes 
        * ... to the DataSet-Service
        */
        void SendSymptomeDataSet(SymptomeInputDataSet data);


        /**
        * SendDiseaseDataSet
        * ... to the DataSet-Service
        */
        void SendDiseaseDataSet(DiseaseDataSet data);


        /**
        * SendSymptomes 
        * ... get the Symptome-List for the UI Service
        */
        List<SymptomeType> GetSymptomeTypes();
    }
}
