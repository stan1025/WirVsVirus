using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System;

namespace depr_api_test
{
    [TestClass]
    public class ValueApiTests
    {
        [TestMethod]
        [Timeout(200)]
        public void Get_Values()
        {
            // arrange
            var _client = new HttpClient();
            HttpResponseMessage response = _client.GetAsync(new Uri(Constants.url + "/api/values")).Result;

            // act




            // assert
            Assert.IsTrue(response.IsSuccessStatusCode, "Statuscode " + response.StatusCode + " returned");
        }
    }
}
