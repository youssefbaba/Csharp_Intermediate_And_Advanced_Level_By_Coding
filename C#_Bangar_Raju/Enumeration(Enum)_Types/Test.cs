using System.Net;

namespace Enumeration_Enum__Types
{
    public class Test
    {
        /*
         
        Monday,     // default value is 0
        Tuesday,    // default value is 1
        Wednesday,  // default value is 2
        Thursday,   // default value is 3
        Friday,     // default value is 4
         
         */

        static void Main(string[] args)
        {
            Days day0 = 0;
            Console.WriteLine($"{day0} : {(int)day0}");
            Days day1 = (Days)1;
            Console.WriteLine($"{day1} : {(int)day1}");
            Days day6 = (Days)6;
            Console.WriteLine($"{day6} : {(int)day6}");
            Days day3 = Days.Thursday;
            Console.WriteLine($"{day3} : {(int)day3}");
            int value = (int)Days.Friday;
            Console.WriteLine($"{(Days)value} : {value}");

            Console.WriteLine("----------------------------------");

            Seasons season = Seasons.Summer;
            Console.WriteLine($"{season} : {(int)season}");

            Console.WriteLine("----------------------------------");

            foreach (string str in Enum.GetNames(typeof(Seasons)))
            {
                Console.WriteLine($"{str} : {(int)Enum.Parse(typeof(Seasons) , str)}");
            }

            Console.WriteLine("----------------------------------");

            foreach (int number in Enum.GetValues(typeof(Seasons)))
            {
                Console.WriteLine($"{(Seasons)number} : {number}");
            }

            Console.WriteLine("----------------------------------");

            foreach (byte item in  Enum.GetValues(typeof(Levels)))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------------------------------");


            Enumeration enumeration = new Enumeration();
            Console.WriteLine(enumeration.MeetingDate);
            //enumeration.MeetingDate = (Days)Enum.Parse(typeof(Days) , "Friday");
            enumeration.MeetingDate = Days.Friday;
            Console.WriteLine(enumeration.MeetingDate);

        }
    }
}