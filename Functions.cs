using OpenQA.Selenium;
using System;
using System.IO;

namespace QATest.Setup
{
    public class Functions
    {
        public static void WriteInto(string filePath, string readText)
        {

            File.AppendAllText(filePath, readText + Environment.NewLine);

        }

        public static void TakeScreenShot()
        {
            Random r = new Random();
            ((ITakesScreenshot)Driver.Instance).GetScreenshot().SaveAsFile("C:/ScreenShot/" + "/ScreenShot" + r.Next(0, 100000) + DateTime.Now.ToString("(dd_MMM_hh_mm_ss_tt)") + ".jpeg", ScreenshotImageFormat.Jpeg);
        }
       
    }
}
