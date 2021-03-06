﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vdivsvirus.Types;

namespace vdivsvirus.Interfaces
{
    /**
     * RequestDataSet-Service
     * ... Analysing Service (Client)
     * ... DataSet Service (Server)
     */
    public interface IRequestDataSet
    {

        /**
        * NextDataSetAvailable 
        * ... request the availability of new to analyse data
        */
        bool DataSetAvailable();

        /**
        * RequestNextDataSet 
        * ... request the next data set
        */
        SymptomeDataSet RequestDataSet();

        /**
        * SendDataResultSet 
        * ... send propability data back after finished analysis.
        */
        void SendDataResultSet(PropabilityDataSet data);

        /**
        * HistorySetAvailable 
        * ... request the availability of new to analyse data
        */
        bool HistorySetAvailable();

        /**
        * RequestHistorySet
        * ... to the DataSet-Service
        */
        PropabilityHistorySet RequestHistorySet();

        /**
        * SendHistoryResultSet 
        * ... send propability data back after finished analysis.
        */
        void SendHistoryResultSet(PropabilityDataSet data);






        /**
        * RequestDiseasePropability 
        * ... request the analysed data of a defined user and time
        */
        PropabilityDataSet RequestDiseasePropability(Guid userID, DateTime time);

        /**
        * RequestDiseasePropabilityHistory 
        * ... request the analysed data of a defined timeframe
        */
        PropabilityHistorySet RequestDiseasePropabilityHistory(Guid userID);
    }
}
