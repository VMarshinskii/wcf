using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Server
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service1" в коде и файле конфигурации.
    public class Service1 : IService1
    {
        public void DoWork()
        {
            Console.WriteLine("Вызван DoWork");
        }

        public int Step(int a, int b)
        {
            return (int)Math.Pow(a, b);
        }
    }
}
