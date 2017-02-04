using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace OutOfSight.Game
{
    class Clock
    {
        public static void Main()
        {
            Console.WriteLine("Starting");
            Clock.start(5, (sender, args) =>
            {
                Console.WriteLine("Triggered");
                Console.WriteLine(sender.ToString());
                Console.WriteLine(args.ToString());
            });
            Console.WriteLine("Clock Set");
        }

        private static Timer t = new Timer();
        public static int secondsPerRound = 30;

        public static void addFunction(ElapsedEventHandler timedEvent)
        {
            t.Elapsed += timedEvent;
        }

        public static void start()
        {
            t.AutoReset = false;
            t.Interval = secondsPerRound * 1000;
            t.Enabled = true;
        }

        public static void start(int seconds, ElapsedEventHandler timedEvent)
        {
            t = new Timer(1000 * seconds);
            //t.Interval = seconds * 1000;
            t.Elapsed += timedEvent;
            t.AutoReset = false;
            //t.Enabled = true;
            t.Enabled = true;
        }

    }
}
