using Microsoft.Rest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Http;

namespace System.Threading.Tasks.Extensions.bug
{
    [TestClass]
    public class SystemThreadingTasksExtensionsTest
    {
        [TestMethod]
        public void MethodNotFound()
        {
            var httpOperationResponse = new HttpOperationResponse<object>();
            httpOperationResponse.Request = new HttpRequestMessage();

            Assert.IsTrue(true);
        }
    }
}
