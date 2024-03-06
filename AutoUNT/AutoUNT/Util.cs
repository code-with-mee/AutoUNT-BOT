using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoUNT
{
    public class Util
    {
        public static IWebDriver CreateBrowserDriver(string profile)
        {
            try
            {
                string chromeDriverPath = "./chromedriver_win32/chromedriver.exe";
                var m_Options = new ChromeOptions();
                m_Options.AddArgument("--user-data-dir=C:\\Users\\ratan\\AppData\\Local\\Google\\Chrome\\User Data");
                m_Options.AddArgument("--profile-directory=" + profile);
                //m_Options.AddArgument("--disable-extensions");
                return new ChromeDriver(chromeDriverPath, m_Options);
            }
            catch (Exception ex)
            {
                Console.WriteLine("error : " + ex.Message);
                return null;
            }
        }
    }
}
