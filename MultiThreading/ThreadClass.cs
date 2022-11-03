using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading
{
    //Creating ThreadClass 
    internal class ThreadClass
    {
        //Create static string array
        static string[] cars = { "Honda", "Ford", "Toyota", "Nissan", "Chevrolet", "BMW", "Kia" };
        //Create static char array
        static char[] codes = { 'F', 'R', 'W','Y','M','J','A'};

        //static Print method
        public static void Print()
        {

            for(int i = 0; i < 10; i++)
            {
                //Print Numbers
                Console.WriteLine("Print Method is printing : " + i);
                //add delay of 2 sec when i = 2
                if(i == 2)
                {
                    Thread.Sleep(2000);
                }
            }
        }

        public static void Display()
        {
            //print all value in cars array
            foreach(string car in cars)
            {
                //when car = kia add delay of 3 sec
                if (car == "Kia")
                {
                    Thread.Sleep(3000);
                }
                Console.WriteLine("Display method is displaying : " + car);
            }
        }

        public static void Show()
        {
            //print all value of in codes array
            foreach (char code in codes)
            {
                Console.WriteLine("Show method is shows : " + code);
            }
        }

    }
}
