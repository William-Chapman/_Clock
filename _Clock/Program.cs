using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Clock
{
    class Program
    {
        static void Main()
        {
            string time = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt");
            Console.WriteLine("Would you like to do elapsed mode or countdown mode?");
            string response = Console.ReadLine();
            Console.Clear();


            if (response.ToLower() == "elapsed")
            {
                time = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt");
                System.Diagnostics.Stopwatch elapsed = new System.Diagnostics.Stopwatch();
                Console.CursorVisible = false;
                Console.WriteLine(time);
                elapsed.Start();
                while (time != elapsed.ToString())
                {
                    Console.SetCursorPosition(0, Console.CursorTop);
                    Console.Write(elapsed.Elapsed);
                }
            }
            else if (response.ToLower() == "countdown")
            {
                Console.WriteLine("What time would you like to stop the clock at? (MM-dd-yyyy hh:mm:ss tt)");
                string stopTime = Console.ReadLine();
                Console.Clear();
                Console.WriteLine(stopTime);
                Console.CursorVisible = false;
                int stopMonth = Int32.Parse(stopTime.Substring(0, 2));
                int stopDay = Int32.Parse(stopTime.Substring(stopTime.IndexOf("-") + 1, 2));
                stopTime = stopTime.Remove(0, stopTime.IndexOf("-") + 1);
                int stopYear = Int32.Parse(stopTime.Substring(stopTime.IndexOf("-") + 1, 4));
                stopTime = stopTime.Remove(0, stopTime.IndexOf("-") + 1);
                int stopHour = Int32.Parse(stopTime.Substring(stopTime.IndexOf(" ") + 1, 2));
                stopTime = stopTime.Remove(0, stopTime.IndexOf(" ") + 1);
                int stopMinute = Int32.Parse(stopTime.Substring(stopTime.IndexOf(":") + 1, 2));
                stopTime = stopTime.Remove(0, stopTime.IndexOf(":") + 1);
                int stopSecond = Int32.Parse(stopTime.Substring(stopTime.IndexOf(":") + 1, 2));
                stopTime = stopTime.Remove(0, stopTime.IndexOf(":") + 1);
                while (time != stopTime)
                {
                    time = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt");

                    int curMonth = Int32.Parse(time.Substring(0, 2));
                    time = time.Remove(0, 2);
                    int curDay = Int32.Parse(time.Substring(time.IndexOf("-") + 1, 2));
                    time = time.Remove(time.IndexOf("-"), 2);
                    int curYear = Int32.Parse(time.Substring(time.IndexOf("-") + 1, 4));
                    time = time.Remove(time.IndexOf("-"), 4);
                    int curHour = Int32.Parse(time.Substring(time.IndexOf(" ") + 1, 2));
                    time = time.Remove(time.IndexOf(" "), 2);
                    int curMinute = Int32.Parse(time.Substring(time.IndexOf(":") + 1, 2));
                    time = time.Remove(time.IndexOf(":"), 2);
                    int curSecond = Int32.Parse(time.Substring(time.IndexOf(":") + 1, 2));
                    time = time.Remove(time.IndexOf(":"), 2);

                    Console.SetCursorPosition(0, Console.CursorTop);
                    Console.Write($"{(stopMonth - curMonth)}-{(stopDay - curDay)}-{(stopYear - curYear)} {(stopHour - curHour)}:{(stopMinute - curMinute)}:{(stopSecond - curSecond)}     ");
                    Console.WriteLine(" ");
                    Console.SetCursorPosition(0, Console.CursorTop);
                    Console.Write(DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt"));
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                }
            }

            Console.WriteLine(" ");
        }
    }
}