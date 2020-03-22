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
        bool SendSymptomeDataSet(SymptomeInputDataSet data);


        /**
        * SendDiseaseDataSet
        * ... to the DataSet-Service
        */
        bool SendDiseaseDataSet(DiseaseAcknowledgeSet data);

    }
}
