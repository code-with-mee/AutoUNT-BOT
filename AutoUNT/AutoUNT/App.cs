using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoUNT
{
    internal class App
    {
        public void Start()
        {
            for(int i = 0; i < 1; i++)
            {
                Task.Factory.StartNew(() =>
                {
                    Service service = new Service();
                    service.Run();
                });
            }
        }
    }
}
