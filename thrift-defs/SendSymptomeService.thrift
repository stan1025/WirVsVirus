//################################
// #VDIvsVirus - 

include "Types.thrift"

/**
 * Requires Namespaces for supported Runtime Systems
 */
namespace java vdivsvirus.interfaces
namespace netstd   vdivsvirus.interfaces


/**
 * SendSymptome-Service
    * ... UI Service (Client)
    * ... DataSet Service (Server)
 */
service SendSymptomeService {


    /**
    * SendSymptomes 
    * ... to the DataSet-Service
    */
    Types.ServiceResponse SendSymptomeDataSet(1: Types.SymptomeInputData data);


    /**
    * SendDiseaseDataSet
    * ... to the DataSet-Service
    */
    Types.ServiceResponse SendDiseaseDataSet(1: Types.DiseaseDataSet data);


    /**
    * SendSymptomes 
    * ... get the Symptome-List for the UI Service
    */
    list<Types.SymptomeType> GetSymptomeTypes();


}
