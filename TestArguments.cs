using System;
using System.IO;
using System.Xml;

namespace QATest.Setup
{
    public class TestArguments
    {
        public string Browser { get; set; }
        public string Url { get; set; }

        public TestArguments(string configFilePath)
        {

            if (!File.Exists(configFilePath))
                throw new FileNotFoundException("Specified test configuration file does not exist.");

            //Load configuration xml file

            XmlDocument doc = new XmlDocument();
            doc.Load(configFilePath);

            string driverValue = doc.DocumentElement.SelectSingleNode("//testconfiguration//browser").InnerText;
            string urlValue = doc.DocumentElement.SelectSingleNode("//testconfiguration//url").InnerText;

            if (string.IsNullOrWhiteSpace(driverValue) || string.IsNullOrWhiteSpace(urlValue))
            {
                throw new ArgumentNullException("test parameters from configuration XML file are not valid.please check configuration xml file");
            }
            else
            {
                this.Browser = driverValue;
                this.Url = urlValue;
            }
        }
    }
}

