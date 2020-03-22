using System;
using System.Collections.Generic;

namespace vdivsvirus.Types
{

    #region Database Types

    internal class UserDataHistory
    {
        public Guid userID { get; set; }
        public List<UserDataSet> history { get; set; }
        public bool hasNew { get; set; } // has unprocessed UserDataSet
    }

    internal class UserDataSet
    {
        public Dictionary<int, int> symptomes { get; set; }
        public Dictionary<int, sbyte> propabilities { get; set; }
        public List<GeoData> geodata { get; set; }
        public DateTime time { get; set; }
    }

    #endregion


    #region Symptome Data Set Data Types

    /// <summary>
    /// Symptome Input Type Enumeration
    /// </summary>
    public enum SymptomeInputType
    {
        /// <summary>
        /// Not displayed - hidden filed
        /// </summary>
        none = 0,

        /// <summary>
        /// YesNoQuestion
        /// </summary>
        yesno = 1,

        /// <summary>
        /// Slider Value
        /// settingString = min=x;max=y;stepz
        /// </summary>
        slider = 2,

        /// <summary>
        /// Enumeration List
        /// settingString = key1=value1;key2=value2;...
        /// </summary>
        list = 3
    }

    /// <summary>
    /// Symptome Type Information
    /// (all data)
    /// </summary>
    public class SymptomeType
    {
        public SymptomeType()
        {
            //Default Scale Func is Input == Output -> 1:1 Mapping
            ScaleFunc = input => input;
        }

        /// <summary>
        /// Symptome Ident Data
        /// (will be sent to app)
        /// </summary>
        public SymptomeIdentData IdentData { get; set; }




        /// <summary>
        /// Symptome Propability Factor 
        /// Setting for Proability Data Analysis 
        /// </summary>
        public float symptomePropability { get; set; }

        /// <summary>
        /// Scaling Function for mapping of input value
        /// to propability scale
        /// </summary>
        public Func<float, float> ScaleFunc { get; set; }
    }

    /// <summary>
    /// Symptome Display Data
    /// (display only information)
    /// </summary>
    public class SymptomeIdentData
    {

        /// <summary>
        /// Symptome Identifier
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// Symptome Input Classifier
        /// </summary>
        public SymptomeInputType inputType { get; set; }

        /// <summary>
        /// Symptome Display Type
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Symptome Display Description
        /// </summary>
        public string desc { get; set; }

        /// <summary>
        /// Symptome Input Settings 
        /// </summary>
        public string settings { get; set; }
    }


    /// <summary>
    /// Symptome Input Data
    /// (feedback from app)
    /// </summary>
    public class SymptomeInputData
    {
        /// <summary>
        /// Symptome ID
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// Symptome Strength
        /// </summary>
        public float strength { get; set; }
    }

    /**
     * GeoData
     * https://developer.android.com/reference/android/location/Location.html
     */
    public class GeoData
    {
        public double latitude { get; set; }
        public double longitude { get; set; }
        public Int64 time { get; set; } //milliseconds since 1.1.1970 (UTC)
        public double accuracy { get; set; }
    }

    /// <summary>
    /// Symptome Input Data Set
    /// </summary>
    public class SymptomeInputDataSet
    {
        /// <summary>
        /// Anonymized User ID
        /// </summary>
        public Guid userID { get; set; }

        /// <summary>
        /// Symptome Inputs
        /// </summary>
        public List<SymptomeInputData> symptomes { get; set; }

        /// <summary>
        /// Moving Profile Data
        /// </summary>
        public List<GeoData> geodata { get; set; }

        /// <summary>
        /// Timestamp
        /// </summary>
        public DateTime time { get; set; }
    }

    #endregion


    #region Disease Data Set Data Types

    /**
     * Structs of AuthenticationData
     */
    public class AuthenticationData
    {
        public string userName { get; set; } //User Name of the to authenticate Person                 
        public string hashedPwd { get; set; } //User Password in a hashed format of the to authenticate Person
    }

    /**
     * Structs of DiseaseDataSet
     */
    public class DiseaseDataSet
    {
        public Guid userID { get; set; }
        public int diseaseID { get; set; }
        public bool testResult { get; set; }
        public AuthenticationData authenticator { get; set; }
        public DateTime time { get; set; } //milliseconds since 1.1.1970 (UTC)
    }

    #endregion

    #region PDA

    /**
     * Structs of SymptomeDataSet [INPUT]
     */
    public class SymptomeDataSet
    {
        public Guid userID { get; set; }
        public DateTime time { get; set; }
        public Dictionary<int, float> symptomes { get; set; }
    }

    /**
     * Structs of PropabilityDataSet [OUTPUT]
     */
    public class PropabilityDataSet
    {
        public Guid userID { get; set; }
        public DateTime time { get; set; }
        public Dictionary<int, float> propabilities { get; set; }
    }

    #endregion


    #region PGA

    // Propabilistic Gradient Analysis (PGA)
    // (Disease Pattern Early Recoginition)

    /**
     * Structs of PropabilityHistorySet [INPUT]
     */
    public class PropabilityHistorySet
    {
        public Guid userID { get; set; }
        public List<PropabilityDataSet> history { get; set; }
    }

    #endregion

    #region Response Data Set Data Types

    /**
     * Structs of DiseaseType
     */
    public class DiseaseType
    {
        public int id { get; set; } //DiseaseID
        public string name { get; set; } //DiseaseName
        public string desc { get; set; } //DiseaseDescription
    }

    /**
     * Structs of ResponseDataSet 
     */
    public class UserResponseDataSet
    {
        public Guid userID { get; set; }
        public DateTime time { get; set; }
        public Dictionary<int, float> propabilities { get; set; }
        public Dictionary<int, DiseaseType> diseaseTypes { get; set; }
        public string message { get; set; }
    }

    /**
     * Structs of UserHistoryDataSet 
     */
    public class UserHistoryDataSet
    {
        public Guid userID { get; set; }
        public List<PropabilityDataSet> history { get; set; }
        public Dictionary<int, DiseaseType> diseaseTypes { get; set; }
        public string message { get; set; }
    }

    #endregion
}