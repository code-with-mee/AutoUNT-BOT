using IWshRuntimeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateChromeProfile
{
    public class App
    {
        private string path = "./profile/";
        private string chromePath = @"C:\Program Files\Google\Chrome\Application\chrome.exe";
        private string argument = "--profile - directory=";
        private string profileName = "Profile ";
        private int startFrom = 33;

        public void Start()
        {
            for(int i = 0; i< 10; i++)
            {
                Console.WriteLine("profile ==============> " + profileName + startFrom);
                WshShell shell = new WshShell();
                IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(path + "profile"+startFrom+".lnk");
                shortcut.TargetPath = chromePath;
                shortcut.Arguments = argument + profileName + startFrom;
                shortcut.WorkingDirectory = @"C:\Program Files\Google\Chrome\Application";
                shortcut.Description = "chrome profile";
                shortcut.Save();

                startFrom++;
            }

        }
    }
}
