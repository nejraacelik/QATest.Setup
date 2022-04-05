using System.Threading;

namespace QATest.Setup
{
    public class Url
    {
        public static void GoTo(string url)
        {
            Driver.Instance.Navigate().GoToUrl(url);
            Thread.Sleep(1000);
        }
    }           
}