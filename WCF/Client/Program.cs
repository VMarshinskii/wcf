using Client.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Service1Client client = new Service1Client();

            client.DoWork();

            Console.WriteLine(client.Step(2, 4));

            client.Close();
        }
    }
}
