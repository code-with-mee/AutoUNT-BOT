using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace AutoUNT
{
    public class Service
    {
        private string profile = "Profile 36";
        private string account = "hofam80547";
        private System.Timers.Timer timer;

        public IWebDriver driver;
        public List<AComponent> components = new List<AComponent>();
        public void Run()
        {
            this.driver = Util.CreateBrowserDriver(profile);
            components.Add(new CreateOrganizationTempMail(this, profile, account));

            timer = new System.Timers.Timer();
            timer.Interval = new TimeSpan(0, 0, 1).TotalMilliseconds;
            timer.AutoReset = true;
            timer.Elapsed += timer_Elapsed;
            timer.Enabled = true;
        }

        private void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            for(int i = 0; i < components.Count; i++)
            {
                AComponent component = components[i];
                if(component != null)
                    component.Execut();
            }
        }


    }
}
