using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome
{
    public interface IHealthChecker
    {
        int GetUseTimes();
        string GetName();
        string GetTypes();

        void HealthCheck(string name, int time, string type);
        
    }


}
