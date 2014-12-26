using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost serviceHos = new ServiceHost(typeof(Service1));
            serviceHos.Open();
            Console.WriteLine("Service is running...");
            Console.WriteLine("Press any key to stop");
            Console.ReadKey();
            serviceHos.Close();
            Console.WriteLine("Service was stopped");
        }
    }
}
