using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace QATest.Setup
{
    public class Driver
    {
        public static IWebDriver Instance { get; set; }

        //default constructor

        public static void Inilialize()
        {
            Instance = new ChromeDriver();
            Instance.Manage().Timeouts().ImplicitWait.Add(TimeSpan.FromSeconds(5));
            Instance.Manage().Window.Maximize();

        }
        public static void Initiliaze(string driverDirectory, string downloadDirectory, string browser)
        {
            if (browser.ToLower() == "chrome")
            {
                ChromeOptions options = new ChromeOptions();

                options.AddUserProfilePreference("download.default_directory", downloadDirectory);
                options.AddUserProfilePreference("download.prompt_for_directory", false);
                options.AddUserProfilePreference("disable-popup-blocking", "true");
                options.AddUserProfilePreference("plugins.plugins_disable", new[] {
                    "Adobe Flash Player",
                    "Chrome PDF Viewer"
                });

                Instance = new ChromeDriver(driverDirectory, options);
                Instance.Manage().Window.Maximize();

            }
        }
        public static void Close()
        {
            Instance.Close();
        }


    }
}
