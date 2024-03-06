using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoUNT.Locators
{
    public class ID : ALocator
    {
        public ID(IWebDriver driver, string key) 
        {
            this.key = key;
            this.driver = driver;
        }

        public override IWebElement actionElement()
        {
            try
            {
                return driver.FindElement(By.Id(this.key));
            }catch (Exception ex) { }
            return null;
        }
    }
}
