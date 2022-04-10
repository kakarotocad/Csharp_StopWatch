using System;
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

            //Collect the entry data 
            string data = Console.ReadLine().ToLower();

            //If the user entry 0 terminate the program
            if (data.Equals("0")) System.Environment.Exit(0);

            //Collect the type of data in the end of the String
            char type = char.Parse(data.Substring(data.Length - 1, 1));

            //Collect the amount of time that will be set for the StopWatch
            int time = int.Parse(data.Substring(0, data.Length - 1));

            //Call the function Start() setting the correctly amount of time
            if (type == 's') Start(time);
            else Start(time * 60);


        }

        //Execute the stopwatch based on the amount of time the user need, after the execution call the Menu() again
        static void Start(int time)
        {
            int timer = 1;

            while(timer <= time)
            {
                Console.Clear();
                Console.WriteLine($"{timer} of {time}");
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

