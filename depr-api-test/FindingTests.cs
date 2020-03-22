using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Text.Json.Serialization;
using vdivsvirus.Types;
using Newtonsoft.Json.Linq;

namespace depr_api_test
{
    [TestClass]
    public class FindingTests
    {
        [TestMethod]
        [Timeout(200)]
        public void InitialEnvironment()
        {
            Constants.userID = Guid.NewGuid();
            Constants.lastTime = DateTime.Now;
        }


        [TestMethod]
        [Timeout(200)]
        public void FindingAvailableTest()
        {
            InitialEnvironment();

            // arrange
            var _client = new HttpClient();
            var uri = new Uri(Constants.url + "/api/finding/newfindingavailable");

            //// act
            JObject o = new JObject();
            o.Add("id", Constants.userID);
            o.Add("time", Constants.lastTime);

            string json = o.ToString();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = uri,
                Content = new StringContent(json, Encoding.UTF8, "application/json"),
            };

            var response = _client.SendAsync(request).Result;

            // assert
            Assert.IsTrue(response.IsSuccessStatusCode, "Statuscode " + response.StatusCode + " returned");
            Assert.IsFalse(JsonConvert.DeserializeObject<bool>(response.Content.ReadAsStringAsync().Result));
        }

        [TestMethod]
        [Timeout(200)]
        public void RequestFindingTest()
        {
            // arrange
            var _client = new HttpClient();
            var uri = new Uri(Constants.url + "/api/finding/requestfinding");
            Guid userId = Guid.NewGuid();
            DateTime time = DateTime.Now;

            //// act
            //JObject o = new JObject();
            //o.Add("id", Constants.userID);
            //o.Add("time", Constants.lastTime);

            //string json = o.ToString();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = uri,
                //Content = new StringContent(json, Encoding.UTF8, "application/json")
            };

            request.Properties.Add("id", Constants.userID);
            request.Properties.Add("time", Constants.lastTime);


            var response = _client.SendAsync(request).Result;


            Assert.IsTrue(response.IsSuccessStatusCode, "Statuscode " + response.StatusCode + " returned");

            UserResponseDataSet data = JsonConvert.DeserializeObject<UserResponseDataSet>(response.Content.ReadAsStringAsync().Result);

            System.Diagnostics.Trace.WriteLine(response.Content.ReadAsStringAsync().Result);

            // assert
            Assert.IsNotNull(response.Content);
        }


       /* [TestMethod]
        [Timeout(200)]
        public void RequestFindingHistoryTest()
        {
            // arrange
            var _client = new HttpClient();
            var uri = new Uri(Constants.url + "/api/finding/RequestFindingHistory");
            Guid userId = Guid.NewGuid();

            // act
            JObject o = new JObject();
            o.Add("id", userId);

            string json = o.ToString();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = uri,
                Content = new StringContent(json, Encoding.UTF8, "application/json"),
            };

            var response = _client.SendAsync(request).Result;

            Assert.IsTrue(response.IsSuccessStatusCode, "Statuscode " + response.StatusCode + " returned");

            UserHistoryDataSet data = JsonConvert.DeserializeObject<UserHistoryDataSet>(response.Content.ReadAsStringAsync().Result);

            // assert
            Assert.IsNotNull(response.Content);
        }
        */

    }
}
