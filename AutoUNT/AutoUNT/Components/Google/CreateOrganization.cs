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
    public class CreateOrganization : AComponent
    {
        private int numOfOrganize = 10;
        private List<ALocator> locators = new List<ALocator>();

        public CreateOrganization(Service service, string profile,string account)
        {
            Console.WriteLine("=============> start...");

            this.Service = service;
            this.account = account;
            this.profile = profile;
            this.increase = 1;
            this.driver = service.driver;
            
            if(driver!= null)
            {
                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl(url);
            }

            locators.Add(new XpathSpan(driver, "Sign in"));
            locators.Add(new XpathDiv(driver, "Google"));
            locators.Add(new XpathDiv(driver, account));

            locators.Add(new XpathA(driver, "Add new"));
            locators.Add(new ID(driver, "create_organization_form_name"));
            locators.Add(new XpathSpan(driver, "Select Industry"));
            locators.Add(new XpathSpan(driver, "Architecture"));
            locators.Add(new Name(driver, "commit"));
            locators.Add(new XpathA(driver, "Unity Dashboard"));
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
                IWebElement ele = locators[index].actionElement();
                if (ele != null)
                {
                    if(index == 2)
                    {
                        ele.Click();
                        Thread.Sleep(2000);
                        driver.Navigate().GoToUrl("https://id.unity.com/organizations");
                    }
                    else if(index == 4)
                    {

                        increase++;
                        ele.SendKeys(account + increase);
                    }
                    else
                    {
                        ele.Click();

                        if (index == 7 && increase < numOfOrganize)
                            index = 2;
                    }

                    index++;
                    if (index >= locators.Count)
                    {
                        index = 0;
                        Service.components.Remove(this);
                        Service.components.Add(new CreateProject(Service, this.profile, this.account));
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
