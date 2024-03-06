using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoUNT.Locators
{
    public class XpathA : ALocator
    {
        public XpathA(IWebDriver driver, string key) 
        {
            this.key = key;
            this.driver = driver;
        }

        public override IWebElement actionElement()
        {
            try
            {
                IWebElement ele = driver.FindElement(By.XPath("//a[text() = '" + this.key + "']"));
                if(ele != null)
                    return ele;
                return driver.FindElement(By.XPath("//a[@value='"+this.key+"']"));
            }
            catch (Exception ex) { }
            return null;
        }
    }
}
