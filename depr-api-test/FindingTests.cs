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
        public void FindingAvailableTest()
        {
            // arrange
            var _client = new HttpClient();
            var uri = new Uri(Constants.url + "/api/finding/newfindingavailable");
            Guid userId = Guid.NewGuid();
            DateTime time = DateTime.Now;

            // act
            JObject o = new JObject();
            o.Add("id", userId);
            o.Add("time", time);

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
            Assert.IsTrue(JsonConvert.DeserializeObject<bool>(response.Content.ReadAsStringAsync().Result));
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

            // act
            JObject o = new JObject();
            o.Add("id", userId);
            o.Add("time", time);

            string json = o.ToString();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = uri,
                Content = new StringContent(json, Encoding.UTF8, "application/json"),
            };

            var response = _client.SendAsync(request).Result;


            Assert.IsTrue(response.IsSuccessStatusCode, "Statuscode " + response.StatusCode + " returned");

            UserResponseDataSet data = JsonConvert.DeserializeObject<UserResponseDataSet>(response.Content.ReadAsStringAsync().Result);

            // assert
            Assert.IsNotNull(response.Content);
        }


        [TestMethod]
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


    }
}
