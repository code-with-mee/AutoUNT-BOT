using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoUNT
{
    public abstract class AComponent
    {
        public string account = "";
        public string profile = "";
        public string url = "https://dashboard.unity3d.com/gaming/login?redirectTo=Lw==";
        public int index = 0;
        public int increase = 2;

        public string Name;
        public bool isComplete;
        public bool isProcessing;
        public Service Service;
        public Random random = new Random();
        public IWebDriver driver = null;
        public List<AComponent> Components;

        public abstract void Init();
        public abstract void Execut();
        public abstract void Complete();

        public AComponent GetComponent(string name)
        {
            foreach (var component in Components)
            {
                if (component.Name == name)
                    return component;
            }
            return null;
        }

        public void RemoveComponent(AComponent component)
        {
            if (Components.Contains(component))
                Components.Remove(component);
        }
    }
}
