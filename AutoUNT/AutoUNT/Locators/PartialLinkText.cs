using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoUNT.Locators
{
    public class PartialLinkText : ALocator
    {
        public PartialLinkText(IWebDriver driver, string key) 
        {
            this.key = key;
            this.driver = driver;
        }

        public override IWebElement actionElement()
        {
            try
            {
                return driver.FindElement(By.PartialLinkText(this.key));
            }catch (Exception ex) { }
            return null;
        }
    }
}
