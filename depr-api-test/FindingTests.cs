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
    public class FindingTests
    {


        [TestMethod]
        [Timeout(200)]
        public void FindingAvailableTest()
        {
            // arrange
            RestClient client = new RestClient("http://localhost:5000");
            RestRequest request = new RestRequest("api/finding/newfindingavailable", Method.GET);

            // act
            IRestResponse response = client.Execute(request);



            // assert
            Assert.IsTrue(bool.Parse(response.Content));
        }

        [TestMethod]
        [Timeout(200)]
        public void RequestFinding()
        {
            Guid userId = Guid.NewGuid();
            // arrange
            RestClient client = new RestClient("http://localhost:5000");
            RestRequest request = new RestRequest($"api/finding/requestfinding/{userId}", Method.POST);

            // act
            IRestResponse response = client.Execute(request);

            PropabilityDataSet data = SimpleJson.DeserializeObject<PropabilityDataSet>(response.Content);

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
