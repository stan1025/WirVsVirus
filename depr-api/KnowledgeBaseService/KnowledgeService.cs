using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vdivsvirus.Interfaces;
using vdivsvirus.Types;

namespace vdivsvirus.Services
{
    public class KnowledgeService : IKnowledgeService
{
        private List<SymptomeType> symptomeList = new List<SymptomeType>();
        private List<DiseaseType> diseaseList = new List<DiseaseType>();


        public KnowledgeService()
        {
            loadSymptomeData();
            LoadDiseasesTypes();
        }

        private void loadSymptomeData()
        {
            #region Fieber Symptome

            SymptomeType fieber = new SymptomeType { 
                IdentData = new SymptomeIdentData() 
                { 
                    id = "1", 
                    inputType = SymptomeInputType.slider, 
                    desc = "", 
                    name = "Fieber", 
                    settings = "min=36.5;max=42.5;step=0.1" 
                },
                symptomePropability = (float)87.9, 
                ScaleFunc = input => input * 1000 };

            symptomeList.Add(fieber);
            #endregion

            #region Husten Symptome

            SymptomeType husten = new SymptomeType
            {
                IdentData = new SymptomeIdentData()
                {
                    id = "2",
                    inputType = SymptomeInputType.slider,
                    desc = "",
                    name = "Husten",
                    settings = "min=0;max=100;step=1"
                },
                symptomePropability = (float)67.7
            };

            symptomeList.Add(husten);
            #endregion

            #region Abgeschlagenheit Symptome

            SymptomeType abgeschlagenheit = new SymptomeType
            {
                IdentData = new SymptomeIdentData()
                {
                    id = "3",
                    inputType = SymptomeInputType.slider,
                    desc = "",
                    name = "Abgeschlagenheit",
                    settings = "min=0;max=100;step=1"
                },
                symptomePropability = (float)38.1
            };

            symptomeList.Add(abgeschlagenheit);

            #endregion

            #region Kurzatmigkeit Symptome

            SymptomeType kurzatmigkeit = new SymptomeType
            {
                IdentData = new SymptomeIdentData()
                {
                    id = "4",
                    inputType = SymptomeInputType.slider,
                    desc = "",
                    name = "Kurzatmigkeit",
                    settings = "min=0;max=100;step=1"
                },
                symptomePropability = (float)18.6
            };

            symptomeList.Add(kurzatmigkeit);

            #endregion

            #region Muskel-/Gelenkschmerz Symptome

            SymptomeType muskelgelenkschmerz = new SymptomeType
            {
                IdentData = new SymptomeIdentData()
                {
                    id = "5",
                    inputType = SymptomeInputType.slider,
                    desc = "",
                    name = "Muskel-/Gelenkschmerz",
                    settings = "min=0;max=100;step=1"
                },
                symptomePropability = (float)14.8
            };

            symptomeList.Add(muskelgelenkschmerz);
            #endregion

            #region Halsschmerz Symptome

            SymptomeType halsschmerz = new SymptomeType
            {
                IdentData = new SymptomeIdentData()
                {
                    id = "6",
                    inputType = SymptomeInputType.slider,
                    desc = "",
                    name = "Halsschmerz",
                    settings = "min=0;max=100;step=1"
                },
                symptomePropability = (float)13.9
            };

            symptomeList.Add(halsschmerz);

            #endregion

            #region Kopfschmerz Symptome

            SymptomeType kopfschmerz = new SymptomeType
            {
                IdentData = new SymptomeIdentData()
                {
                    id = "7",
                    inputType = SymptomeInputType.slider,
                    desc = "",
                    name = "Kopfschmerz",
                    settings = "min=0;max=100;step=1"
                },
                symptomePropability = (float)13.6
            };

            symptomeList.Add(kopfschmerz);

            #endregion

            #region Schüttelfrost Symptome

            SymptomeType schuettelfrost = new SymptomeType
            {
                IdentData = new SymptomeIdentData()
                {
                    id = "8",
                    inputType = SymptomeInputType.slider,
                    desc = "",
                    name = "Schüttelfrost",
                    settings = "min=0;max=100;step=1"
                },
                symptomePropability = (float)11.4
            };

            symptomeList.Add(schuettelfrost);

            #endregion

            #region Übelkeit Symptome

            SymptomeType uebelkeit = new SymptomeType
            {
                IdentData = new SymptomeIdentData()
                {
                    id = "9",
                    inputType = SymptomeInputType.slider,
                    desc = "",
                    name = "Übelkeit",
                    settings = "min=0;max=100;step=1"
                },
                symptomePropability = (float)5.0
            };

            symptomeList.Add(uebelkeit);

            #endregion

            #region verstopfteNase Symptome

            SymptomeType verstopfteNase = new SymptomeType
            {
                IdentData = new SymptomeIdentData()
                {
                    id = "10",
                    inputType = SymptomeInputType.slider,
                    desc = "",
                    name = "Verstopfte Nase",
                    settings = "min=0;max=100;step=1"
                },
                symptomePropability = (float)4.8
            };

            symptomeList.Add(verstopfteNase);

            #endregion

            #region Durchfall Symptome

            SymptomeType durchfall = new SymptomeType
            {
                IdentData = new SymptomeIdentData()
                {
                    id = "11",
                    inputType = SymptomeInputType.slider,
                    desc = "",
                    name = "Durchfall",
                    settings = "min=0;max=100;step=1"
                },
                symptomePropability = (float)3.7
            };

            symptomeList.Add(durchfall);

            #endregion
        }



        public List<SymptomeType> GetSymptomeTypes()
        {
            return symptomeList;
        }


        public List<SymptomeIdentData> GetSymptomeIdentData()
        {
            return symptomeList.Select(item => item.IdentData).ToList();
        }

        public List<DiseaseType> GetDiseaseTypes()
        {
            return diseaseList;
        }

        public List<DiseaseIdentData> GetDiseaseIdentData()
        {
            return diseaseList.Select(item => item.IdentData).ToList();
        }




        private void LoadDiseasesTypes()
        {

            #region Covid19 Disease

            DiseaseType covid19 = new DiseaseType()
            {
                IdentData = new DiseaseIdentData()
                {
                    id = "1",
                    name = "Covid-19",
                    desc = "Scheiß Lungenkrankheit",
                    infoLink = "www.covid19.com"
                },
                propabilityAlgorithm = covid19Algorithm,
                GetRecommendation = null
            };

            #endregion



        }





        #region Propability Algorithms

        private float covid19Algorithm(SymptomeDataSet data)
        {
            return data.symptomes.Select(
                input =>
                {
                    float propSum = GetSymptomeTypes().Select(item => item.symptomePropability).Sum();
                    SymptomeType symp = GetSymptomeTypes().FirstOrDefault(item => item.IdentData.id.Equals(input.id));
                    return symp == null ? 0f : (symp.symptomePropability * propSum / 100) * symp.ScaleFunc(input.strength);
                })
                .Sum();
        }


        #endregion

        #region Recommendation Algorithms





        #endregion


    }




    public static class SymptomeScalingExtension
    {

        public static Func<float, float> OneToOne = input => input;

        public static Func<float, float> FeverScaling = input =>
        {
            if (input < 37.5f)
                return 0;
            else if (37.5f <= input && input <= 38f)
                return 1 + (0.5f / 24f) * (input - 37.5f);
            else if (38.1f <= input && input <= 38.5f)
                return 26 + (0.4f / 24f) * (input - 38.1f);
            else if (38.6f <= input && input <= 39f)
                return 51 + (0.4f / 24f) * (input - 38.6f);
            else if (39.1f <= input && input <= 39.9f)
                return 76 + (0.8f / 24f) * (input - 39.1f);
            else
                return 100f;
        };



    }














}
