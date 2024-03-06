using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AutoUNT.Locators;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace AutoUNT
{
    public class CreateProject : AComponent
    {
        private int numOfProject = 10;
        private List<ALocator> locators = new List<ALocator>();

        public CreateProject(Service service, string profile,string account)
        {
            Console.WriteLine("=============> start...");
            this.Service = service;
            this.account = account;
            this.driver = service.driver;

            //if(driver!= null)
            //{
            //    driver.Manage().Window.Maximize();
            //    driver.Navigate().GoToUrl(url);
            //}

            //locators.Add(new XpathSpan(driver, "Sign in"));
            //locators.Add(new XpathDiv(driver, "Google"));
            //locators.Add(new XpathDiv(driver, account));

            locators.Add(new XpathSpan(driver, account));
            locators.Add(new XpathDiv(driver, "Organization"));
            locators.Add(new XpathP(driver, account + increase));
            locators.Add(new XpathSpan(driver, "Create project"));
            locators.Add(new ID(driver, "name"));
            locators.Add(new XpathDiv(driver, "Monetization"));
            locators.Add(new XpathSpan(driver, "Get started"));
            locators.Add(new XpathP(driver, "Unity LevelPlay"));
            locators.Add(new XpathSpan(driver, "Finish"));
            locators.Add(new XpathSpan(driver, "Dismiss"));
        }

        public override void Complete()
        {
  
        }

        public override void Execut()
        {
            if (isProcessing || driver == null)
                return;

            isProcessing = true;

            Console.WriteLine("index =================> " + index);

            try
            {
                if (index == 2) //if (index == 5)
                    locators[2] = new XpathP(driver, account + increase);
                IWebElement ele = locators[index].actionElement();
                if (ele != null)
                {
                    if (index == 4) //if (index == 7)
                    {
                        ele.SendKeys("demo");
                        ele.Submit();
                    }
                    else if (index == 7)//else if(index == 10)
                    {
                        ele.Click();
                        ele.Submit();
                    }
                    else
                    {
                        ele.Click();
                    }
       

                    index++;
                    if (index >= locators.Count && increase < numOfProject)
                    {
                        index = 0;
                        increase++;
                    }
                }
            }
            catch (Exception ex) {}


            isProcessing= false;    
        }

        public override void Init()
        {
            
        }
    }
}
