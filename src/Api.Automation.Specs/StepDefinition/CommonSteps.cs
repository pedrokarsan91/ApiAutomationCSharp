using Api.Automation.Common.Helpers;
using TechTalk.SpecFlow;

namespace Api.Automation.Specs.StepDefinition
{
    [Binding]
    public  class CommonSteps
    {
        [Given(@"Google is running")]
        public void GivenGoogleIsRunning()
        {
            HttpHelper.GetInstance.GetResponseCode("http://www.google.com", HttpHelper.HttpType.Get);
        }
    }
}
