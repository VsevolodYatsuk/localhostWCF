using System;
using System.ServiceModel;

namespace MyWcfService
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri baseAddress = new Uri("http://localhost:8000/MyService");

            using (ServiceHost host = new ServiceHost(typeof(Service), baseAddress))
            {
                // Добавляем конечную точку (endpoint)
                host.AddServiceEndpoint(typeof(IService), new BasicHttpBinding(), "");

                // Открываем хост
                host.Open();

                Console.WriteLine("Сервис запущен. Нажмите любую клавишу для завершения.");
                Console.ReadKey();

                // Закрываем хост
                host.Close();
            }
        }
    }
}
