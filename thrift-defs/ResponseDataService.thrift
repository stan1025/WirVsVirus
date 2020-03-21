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
 * Response-Service
    * ... UI Service (Client)
    * ... Response Service (Server)
 */
service ResponseService {

    /**
    * NewFindingAvailable 
    * ... request the availability of new to finding
    */
    bool NewFindingAvailable();

    /**
    * RequestNextDataSet 
    * ... request the next data set
    */
    Types.UserResponseDataSet RequestFinding(1: string userId);

    /**
    * SendDataResultSet 
    * ... send propability data back after finished analysis.
    */
    Types.UserHistoryDataSet RequestFindingHistory(1: string userId);




}