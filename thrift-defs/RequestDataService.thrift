//################################
// #VDIvsVirus - 

/**
 * Include Required Thrift Files
 */
include "Types.thrift"

/**
 * Requires Namespaces for supported Runtime Systems
 */
namespace java vdivsvirus.interfaces
namespace netstd   vdivsvirus.interfaces







/**
 * RequestDataSet-Service
    * ... Analysing Service (Client)
    * ... DataSet Service (Server)
 */
service RequestDataSetService {

    /**
    * NextDataSetAvailable 
    * ... request the availability of new to analyse data
    */
    bool DataSetAvailable();

    /**
    * RequestNextDataSet 
    * ... request the next data set
    */
    Types.SymptomeDataSet RequestDataSet();

    /**
    * SendDataResultSet 
    * ... send propability data back after finished analysis.
    */
    Types.ServiceResponse SendDataResultSet(1: Types.PropabilityDataSet data);




    /**
    * HistorySetAvailable 
    * ... request the availability of new to analyse data
    */
    bool HistorySetAvailable();

    /**
    * RequestHistorySet
    * ... to the DataSet-Service
    */
    Types.PropabilityHistorySet RequestHistorySet();

    /**
    * SendHistoryResultSet 
    * ... send propability data back after finished analysis.
    */
    Types.ServiceResponse SendHistoryResultSet(1: Types.PropabilityDataSet data);




    /**
    * RequestDiseasePropability 
    * ... request the analysed data of a defined user and time
    */
    Types.PropabilityDataSet RequestDiseasePropability(1: string userID, 2: i64 time);

    /**
    * RequestDiseasePropabilityHistory 
    * ... request the analysed data of a defined timeframe
    */
    Types.PropabilityHistorySet RequestDiseasePropabilityHistory(1: string userID);




}