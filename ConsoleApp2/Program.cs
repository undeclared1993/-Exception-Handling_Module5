using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    /*
     1.	Перехватить исключение запроса к несуществующему веб ресурсу и вывести сообщение о том,
     что произошла ошибка. Программа должна завершиться без ошибок.

     2.Написать программу, которая обращается к элементам массива по индексу и выходит за его пределы.
     После обработки исключения вывести в финальном блоке сообщение о завершении обработки массива.

     3.	Реализовать несколько методов или классов с методами и вызвать один метод из другого. 
     В вызываемом методе сгенерировать исключение и «поднять» его в вызывающий метод.

     4.	Реализовать несколько методов или классов с методами и вызвать один метод из другого.
     В вызываемом методе сгенерировать исключение и «поднять» его в вызывающий метод.
    */
    class Program
    {
        static public String[] WebResources()
        {
            String[] WebResource = new String[6];
            WebResource[0] = "Mail.ru".ToLower();
            WebResource[1] = "Google.com".ToLower(); ;
            WebResource[2] = "Yandex.com".ToLower(); ;
            WebResource[3] = "L2on.net".ToLower(); ;
            WebResource[4] = "Youtube.com".ToLower(); ;
            WebResource[5] = "Gmail.com".ToLower(); ;
            return WebResource;

        }
        static public void Task1()
        {
            String[] WebResource = WebResources();
            Console.WriteLine("Available Web Resources");
            foreach (var item in WebResource)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Enter the desired");
            String Web = Console.ReadLine().ToLower();

            try
            {
                foreach (var item in WebResource)
                {
                    if (item == Web)
                    {
                        Console.WriteLine("has connect");
                        return;
                    }      
                }

                throw new Exception("Can not connect");

            }
            catch (Exception e )
            {

                Console.WriteLine(e.Message);
            }
            
        }
        static public void Task2 ()
        {
            Int32[] Integer = { 0, 1, 2, 3, 4, 5 };

            try
            {
                Console.WriteLine(Integer[6]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static public void Task3Helper (String temp)
        {
            if (temp.Length != 12)
                throw new Exception("N_Corr'");
            else
                Console.WriteLine("It's Okay");
 
            Console.WriteLine(temp);
        }
        static public void Task3()
        {
            String temp;
            Console.WriteLine("Enter your IIN");
            temp = Console.ReadLine();

            Task3Helper(temp);
        }
        
        static void Main(string[] args)
        {
            Task1();
            //Task2();
            //Task3();
        }
    }
}
