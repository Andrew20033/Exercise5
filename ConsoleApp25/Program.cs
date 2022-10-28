using System;

namespace DZ
{
    class Program
    {
        static void Main(string[] args)
        {
            var today = (Days)(1 << (int)DateTime.Now.DayOfWeek);

            var days = Days.Sunday | Days.Monday | Days.Thursday;

            if (days.HasFlag(today))
                Console.WriteLine("Today is our day!");
        }
    }

    [Flags]
    public enum Days : byte
    {
        None = 0x0,
        Sunday = 0x01,
        Monday = 0x02,
        Tuesday = 0x04,
        Wednesday = 0x08,
        Thursday = 0x10,
        Friday = 0x20,
        Saturday = 0x40,
        Everyday = 0xff
    }
}