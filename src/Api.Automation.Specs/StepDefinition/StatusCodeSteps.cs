using Api.Automation.Common.Helpers;
using Api.Automation.Common.Utils;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Api.Automation.Specs.StepDefinition
{
    [Binding]
    public sealed class StatusCodeSteps
    {
        [Then(@"I should get a ""(.*)"" response code")]
        public void ThenIShouldGetAResponseCode(int expectedStatusCode)
        {
            Assert.IsTrue(HttpHelper.GetInstance.GetResponseCode(Constants.BaseUrl, HttpHelper.HttpType.Get) == expectedStatusCode);
        }
    }
}
