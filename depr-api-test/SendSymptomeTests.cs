using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text.Json.Serialization;
using vdivsvirus.Types;

namespace depr_api_test
{
    [TestClass]
    public class SendSymptomeTest
    {
        [TestMethod]
        [Timeout(200)]
        public void GetSymptomeTypes()
        {
            // arrange
            RestClient client = new RestClient("http://localhost:5000");
            RestRequest request = new RestRequest("api/symptome/getsymptometypes", Method.GET);

            // act
            IRestResponse response = client.Execute(request);



            // assert
            Assert.IsNotNull(response.Content);
        }

        [TestMethod]
        [Timeout(200)]
        public void SendSymptomeDataSet()
        {
            // arrange
            RestClient client = new RestClient("http://localhost:5000");
            RestRequest request = new RestRequest("api/symptome/sendsymptomedataset", Method.POST);

            SymptomeInputDataSet resData = new SymptomeInputDataSet()
            {
                userID = Guid.NewGuid(),
                time = DateTime.Now,
                geodata = new List<GeoData>(),
                symptomes = new List<SymptomeInputData>()
                {
                    new SymptomeInputData(){ id = 1, strength = 70f },
                    new SymptomeInputData(){ id = 1, strength = 80f },
                    new SymptomeInputData(){ id = 1, strength = 60f },
                    new SymptomeInputData(){ id = 1, strength = 30f },
                    new SymptomeInputData(){ id = 1, strength = 40f },
                    new SymptomeInputData(){ id = 1, strength = 30f },
                    new SymptomeInputData(){ id = 1, strength = 20f },
                    new SymptomeInputData(){ id = 1, strength = 70f },
                    new SymptomeInputData(){ id = 1, strength = 0f },
                    new SymptomeInputData(){ id = 1, strength = 40f },
                    new SymptomeInputData(){ id = 1, strength = 0f }
                }
            };

            request.AddParameter("UserID", resData.userID);
            request.Body = new RequestBody("application/json", string.Empty, SimpleJson.SerializeObject(resData));


            // act
            IRestResponse response = client.Execute(request);

           
            

            // assert
            Assert.IsNotNull(response.Content);
        }


        [TestMethod]
        [Timeout(200)]
        public void SendDiseaseDataSet()
        {
            // arrange
            RestClient client = new RestClient("http://localhost:5000");
            RestRequest request = new RestRequest("api/symptome/senddiseasedataset", Method.POST);

            DiseaseDataSet resData = new DiseaseDataSet()
            {
                userID = Guid.NewGuid(),
                time = DateTime.Now,
                diseaseID = 1,
                testResult = true,
                authenticator = new AuthenticationData() {  userName = "Dr. Stutz", hashedPwd="abc123def"}
            };  

            request.Body = new RequestBody("application/json", string.Empty, SimpleJson.SerializeObject(resData));


            // act
            IRestResponse response = client.Execute(request);




            // assert
            Assert.IsNotNull(response.Content);
        }


    }
}
