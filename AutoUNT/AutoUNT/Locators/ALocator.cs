using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoUNT
{
    public abstract class ALocator
    {
        public string key = "";
        public IWebDriver driver;
        public abstract IWebElement actionElement();
    }
}
