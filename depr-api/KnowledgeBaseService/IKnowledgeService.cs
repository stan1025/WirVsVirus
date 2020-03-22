using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vdivsvirus.Types;

namespace vdivsvirus.Interfaces
{

    /// <summary>
    /// Interface of the Knowlede Services
    /// who provide supported Symptomes and 
    /// to analysable disease patterns. 
    /// </summary>
    public interface IKnowledgeService
    {

        /// <summary>
        /// Returns the list of all available 
        /// to ask symptome questions
        /// </summary>
        /// <returns></returns>
        List<SymptomeIdentData> GetSymptomeIdentData();

        /// <summary>
        /// Returns the internal type data for symptomes
        /// </summary>
        /// <returns>List of all supported Symptomes</returns>
        List<SymptomeType> GetSymptomeTypes();

        /// <summary>
        /// Returns the internal type data for diseases
        /// </summary>
        /// <returns>List of all recognized disease patterns</returns>
        List<DiseaseType> GetDiseaseTypes();

        /// <summary>
        /// Returns the list of all available
        /// to show disease patterns.
        /// </summary>
        /// <returns>List of all recognized disease patterns</returns>
        List<DiseaseIdentData> GetDiseaseIdentData();

    }
}
