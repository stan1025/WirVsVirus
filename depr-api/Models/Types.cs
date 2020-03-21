using System;
using System.Collections.Generic;

namespace vdivsvirus.Types
{
    // ##############################
    // Base Data Type Definitions
    // ##############################

    /**
     * Structs of Service Response
     */
    public class ServiceResponse
    {
        public int responseId { get; set; }
        public string message { get; set; }
    }



    // ##############################
    // Symptome Data Set Data Types
    // ##############################


    /**
     * Symptome Classifier
     * none : Keine Symptome Classifizierung (hidden field)
     * bool : YesNo Frage
     * scalar : 0 - 5
     */
    public enum SymptomeClassifier
    {
        none = 0,   //Hidden Field
        yesno = 1,  //Yes No Question
        scalar = 2, //Integer Value
        fever = 3
    }

    /**
     * Symptome Strength
     *
     * wenn Class: bool
     * none - Kein Symptom
     * yes - Habe Symptom
     *
     * wenn Class: scalar
     * 0 - kein Symptom
     * 1 - sehr schwach
     * 2 - schwach
     * 3 - mittel
     * 4 - stark
     * 5 - sehr stark
     */
    public enum SymptomeStrength
    {
        none = 0,
        yes = 1, //veryweak
        weak = 2,
        middle = 3,
        strong = 4,
        verystrong = 5
    }

    /**
     * Structs of SymptomeType
     */
    public class SymptomeType
    {
        public int id { get; set; }                     //SymptomeID
        public SymptomeClassifier classifier { get; set; }      //SymptomeClassifier
        public string name { get; set; }                   //SymptomeName
        public string desc { get; set; }                   //SymptomeDescription
    }

    /**
     * Structs of Symptome Input Data
     */
    public class SymptomeInputData
    {
        public SymptomeType type { get; set; }             //SymptomeType
        public SymptomeStrength strength { get; set; }      //SymptomeStrength

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

    /**
     * Structs of SymptomeInputDataSet
     */
    public class SymptomeInputDataSet
    {
        public Guid userID { get; set; }
        public List<SymptomeInputData> symptomes { get; set; }
        public List<GeoData> geodata { get; set; }
        public DateTime time { get; set; } //milliseconds since 1.1.1970 (UTC)
    }


    // ##############################
    // Disease Data Set Data Types
    // ##############################

    /**
     * Structs of AuthenticationData
     */
    public class AuthenticationData
    {
        public string userName { get; set; }       //User Name of the to authenticate Person                 
        public string hashedPwd { get; set; }       //User Password in a hashed format of the to authenticate Person
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


    // #######################################
    // Propabilistic Data Analysis (PDA)
    // (Disease Pattern Early Recoginition)
    // #######################################

    /**
     * Structs of SymptomeDataSet [INPUT]
     */
    public class SymptomeDataSet
    {
        public Guid userID { get; set; }
        public DateTime time { get; set; }
        public Dictionary<int, SymptomeStrength> symptomes { get; set; }
    }

    /**
     * Structs of PropabilityDataSet [OUTPUT]
     */
    public class PropabilityDataSet
    {
        public Guid userID { get; set; }
        public DateTime time { get; set; }
        public Dictionary<int, sbyte> propabilities { get; set; }
    }




    // #######################################
    // Propabilistic Gradient Analysis (PGA)
    // (Disease Pattern Early Recoginition)
    // #######################################


    /**
     * Structs of PropabilityHistorySet [INPUT]
     */
    public class PropabilityHistorySet
    {
        public Guid userID { get; set; }
        public List<PropabilityDataSet> history { get; set; }
    }


    // #######################################
    // Response Data Set Data Types
    // #######################################


    /**
     * Structs of DiseaseType
     */
    public class DiseaseType
    {
        public int id { get; set; }                     //DiseaseID
        public string name { get; set; }                   //DiseaseName
        public string desc { get; set; }                   //DiseaseDescription
    }

    /**
     * Structs of ResponseDataSet 
     */
    public class UserResponseDataSet
    {
        public Guid userID { get; set; }
        public DateTime time { get; set; }
        public PropabilityDataSet propabilities { get; set; }
        public Dictionary<int, DiseaseType> diseaseTypes { get; set; }
        public string message { get; set; }
    }

    /**
     * Structs of UserHistoryDataSet 
     */
    public class UserHistoryDataSet
    {
        public Guid userID { get; set; }
        public Dictionary<DateTime, PropabilityDataSet> history { get; set; }
        public Dictionary<int, DiseaseType> diseaseTypes { get; set; }
        public string message { get; set; }
    }

}