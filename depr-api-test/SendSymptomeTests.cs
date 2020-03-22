using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text.Json.Serialization;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
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
            var _client = new HttpClient();
            HttpResponseMessage response = _client.GetAsync(new Uri(Constants.url + "/api/symptome/GetSymptomeTypes")).Result;

            // act



            // assert
            Assert.IsTrue(response.IsSuccessStatusCode, "Statuscode " + response.StatusCode + " returned");
            Assert.IsNotNull(response.Content);
        }

        [TestMethod]
        [Timeout(200)]
        public void SendSymptomeDataSet()
        {
            // arrange
            var _client = new HttpClient();

            SymptomeInputDataSet resData = new SymptomeInputDataSet()
            {
                userID = Guid.Parse(Constants.userID),
                time = DateTime.Parse(Constants.lastTime),
                geodata = new List<GeoData>(),
                symptomes = new List<SymptomeInputData>()
                {

                    new SymptomeInputData(){ id = "R50.9", strength = 38.8f },
                    new SymptomeInputData(){ id = "R05", strength = 80f },
                    new SymptomeInputData(){ id = "R53", strength = 60f },
                    new SymptomeInputData(){ id = "R06.0", strength = 30f },
                    new SymptomeInputData(){ id = "M79.6", strength = 40f },
                    new SymptomeInputData(){ id = "R07.0", strength = 30f },
                    new SymptomeInputData(){ id = "R51", strength = 20f },
                    new SymptomeInputData(){ id = "R68.8", strength = 70f },
                    new SymptomeInputData(){ id = "R11", strength = 0f },
                    new SymptomeInputData(){ id = "R06.8", strength = 40f },
                    new SymptomeInputData(){ id = "A09.0", strength = 0f }

                }
            };
            var json = JsonConvert.SerializeObject(resData);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            //act
            HttpResponseMessage response = _client.PostAsync(new Uri(Constants.url + "/api/symptome/sendsymptomedataset"), content).Result;





            Assert.IsTrue(response.IsSuccessStatusCode, "Statuscode " + response.StatusCode + " returned");

            // assert
            Assert.IsNotNull(response.Content);
        }


        [TestMethod]
        [Timeout(200)]
        public void SendDiseaseDataSet()
        {
            // arrange
            var _client = new HttpClient();

            DiseaseAcknowledgeSet resData = new DiseaseAcknowledgeSet()
            {
                userID = Guid.NewGuid(),
                time = DateTime.Now,
                diseaseID = "1",
                testResult = true,
                authenticator = new AuthenticationData() {  userName = "Dr. Stutz", hashedPwd="abc123def"}
            };

            var json = JsonConvert.SerializeObject(resData);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            // act
            HttpResponseMessage response = _client.PostAsync(new Uri(Constants.url + "/api/symptome/senddiseasedataset"), content).Result;



            // assert
            Assert.IsTrue(response.IsSuccessStatusCode, "Statuscode " + response.StatusCode + " returned");
            Assert.IsNotNull(response.Content);
        }


    }
}
