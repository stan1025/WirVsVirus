//################################
// #VDIvsVirus - 

/**
 * Requires Namespaces for supported Runtime Systems
 */
namespace java vdivsvirus.interfaces
namespace netstd   vdivsvirus.interfaces

// ##############################
// Base Data Type Definitions
// ##############################

/**
 * Structs of Service Response
 */
struct ServiceResponse {
  1: i32 responseId = 0,
  2: string message
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
enum SymptomeClassifier {
  none = 0,
  yesno = 1,
  scalar = 2
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
enum SymptomeStrength {
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
struct SymptomeType {
  1: string id,                     //SymptomeID
  2: SymptomeClassifier classifier,      //SymptomeClassifier
  3: string name,                   //SymptomeName
  4: string desc                   //SymptomeDescription
}

/**
 * Structs of Symptome Input Data
 */
struct SymptomeInputData {
  1: SymptomeType type,             //SymptomeType
  2: SymptomeStrength strength      //SymptomeStrength

}

/**
 * GeoData
 * https://developer.android.com/reference/android/location/Location.html
 */
struct GeoData {
    1: double latitude,
    2: double longitude,
    3: i64 time, //milliseconds since 1.1.1970 (UTC)
    4: double accuracy
}

/**
 * Structs of SymptomeInputDataSet
 */
struct SymptomeInputDataSet {
  1: string userID,                 
  2: list<SymptomeInputData> symptomes,
  3: list<GeoData> geodata,
  4: i64 time //milliseconds since 1.1.1970 (UTC)
}


// ##############################
// Disease Data Set Data Types
// ##############################

/**
 * Structs of AuthenticationData
 */
struct AuthenticationData {
  1: string userName,       //User Name of the to authenticate Person                 
  2: string hashedPwd       //User Password in a hashed format of the to authenticate Person
}

/**
 * Structs of DiseaseDataSet
 */
struct DiseaseDataSet {
  1: string userID, 
  2: string diseaseID,      
  3: bool testResult,          
  4: AuthenticationData authenticator,
  5: i64 time //milliseconds since 1.1.1970 (UTC)
}


// #######################################
// Propabilistic Data Analysis (PDA)
// (Disease Pattern Early Recoginition)
// #######################################

/**
 * Structs of SymptomeDataSet [INPUT]
 */
struct SymptomeDataSet {
    1: string userID,
    2: i64 time,
    3: map<string, SymptomeStrength> symptomes,
}

/**
 * Structs of PropabilityDataSet [OUTPUT]
 */
struct PropabilityDataSet {
    1: string userID,
    2: i64 time,
    3: map<string, i8> propabilities
}




// #######################################
// Propabilistic Gradient Analysis (PGA)
// (Disease Pattern Early Recoginition)
// #######################################


/**
 * Structs of PropabilityHistorySet [INPUT]
 */
struct PropabilityHistorySet {
    1: string userID,
    2: list<PropabilityDataSet> history,
}


// #######################################
// Response Data Set Data Types
// #######################################


/**
 * Structs of DiseaseType
 */
struct DiseaseType {
  1: string id,                     //DiseaseID
  2: string name,                   //DiseaseName
  3: string desc,                   //DiseaseDescription
}

/**
 * Structs of ResponseDataSet 
 */
struct UserResponseDataSet {
    1: string userID,
    2: i64 time,
    3: PropabilityDataSet propabilities,
    4: map<string, DiseaseType> diseaseTypes,
    5: string message
}

/**
 * Structs of UserHistoryDataSet 
 */
struct UserHistoryDataSet {
    1: string userID,
    2: map<i64, PropabilityDataSet> history,
    3: map<string, DiseaseType> diseaseTypes,
    4: string message
}