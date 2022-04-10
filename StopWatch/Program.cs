﻿using System;
using System.Threading;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Call the menu() to show the options
            Menu();
        }

        //Build a menu for the user select the options
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = Seconds => 10s = 10 seconds");
            Console.WriteLine("M = Minutes => 1m = 1 minute");
            Console.WriteLine("0 = Exit");
            Console.WriteLine("How much time do you need? ");

            string data = Console.ReadLine().ToLower();
            Console.WriteLine(data);
        }

        //Execute the stopwatch based on the amount of time the user need, after the execution call the Menu() again
        static void Start(int time)
        {
            int timer = 1;

            while(timer <= time)
            {
                Console.Clear();
                Console.WriteLine(timer);
                Thread.Sleep(1000);
                timer++;
            }

            Console.Clear();
            Console.WriteLine("Timer Finished!");
            Thread.Sleep(2500);
            Menu();
        }

    }
}

