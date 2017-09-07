using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    { //1.	Перехватить исключение запроса к несуществующему веб ресурсу и вывести сообщение о том, что произошла ошибка. Программа должна завершиться без ошибок.
        static void Main(string[] args)
        {

            try
            {
                Uri uri = new Uri("8.8.8.8");

                Console.WriteLine("Этот сайт доступен");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Данный сайт не доступен");
            }
            Console.ReadLine();
        }
    }
}
