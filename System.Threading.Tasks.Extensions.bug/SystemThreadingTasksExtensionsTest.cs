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
            var _result = new HttpOperationResponse<object>();
            _result.Request = new HttpRequestMessage();
        }
    }
}
