using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using System.Net;

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
            RestClient client = new RestClient("http://localhost:5000");
            RestRequest request = new RestRequest("api/values", Method.GET);

            // act
            IRestResponse response = client.Execute(request);



            // assert
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
