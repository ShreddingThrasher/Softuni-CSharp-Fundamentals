using System;

namespace BackInThirtyMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes += 30;

            if(minutes > 60)
            {
                hours += 1;
                minutes -= 60;
            }

            if(hours == 24)
            {
                hours = 0;
            }

            string minutesOutput = minutes < 10 ? $"0{minutes}" : minutes.ToString();

            Console.WriteLine($"{hours}:{minutesOutput}");
        }
    }
}
