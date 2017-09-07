using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayException
{
    class Program
    {
        //2.	Написать программу, которая обращается к элементам массива по индексу и выходит за его пределы. 
        //После обработки исключения вывести в финальном блоке сообщение о завершении обработки массива.
        static void Main(string[] args)
        {
            const int size = 5;
            int[] array = new int[size];
            try
            {
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine("{0} ", array[i + 1]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Вы вышли заграницы массива");
                
            }
            Console.ReadLine();
        }
    }
}
