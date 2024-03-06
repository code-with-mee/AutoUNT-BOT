using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoUNT.Locators
{
    public class XpathH4 : ALocator
    {
        public XpathH4(IWebDriver driver, string key) 
        {
            this.key = key;
            this.driver = driver;
        }

        public override IWebElement actionElement()
        {
            try
            {
                IWebElement ele = driver.FindElement(By.XPath("//h4[text() = '" + this.key + "']"));
                if (ele != null)
                    return ele;
                return driver.FindElement(By.XPath("//h4[@value='"+this.key+"']"));
            }
            catch (Exception ex) { }
            return null;
        }
    }
}
