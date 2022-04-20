using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();
            double totalPrice = 0;
            double pricePerson = 0;

            if (type == "Students")
            {
                if (day == "Friday")
                {
                    pricePerson = 8.45;
                }
                else if (day == "Saturday")
                {
                    pricePerson = 9.80;
                }
                else if (day == "Sunday")
                {
                    pricePerson = 10.46;
                }

                totalPrice = pricePerson * people;

                if (people >= 30)
                {
                    totalPrice *= 0.85;
                }
            }
            else if (type == "Business")
            {
                if (day == "Friday")
                {
                    pricePerson = 10.90;
                }
                else if (day == "Saturday")
                {
                    pricePerson = 15.60;
                }
                else if (day == "Sunday")
                {
                    pricePerson = 16;
                }

                if (people >= 100)
                {
                    people -= 10;
                }

                totalPrice = pricePerson * people;
            }
            else if (type == "Regular")
            {
                if (day == "Friday")
                {
                    pricePerson = 15;
                }
                else if (day == "Saturday")
                {
                    pricePerson = 20;
                }
                else if (day == "Sunday")
                {
                    pricePerson = 22.50;
                }

                totalPrice = pricePerson * people;

                if (people >= 10 && people <= 20)
                {
                    totalPrice *= 0.95;
                }
            }

            Console.WriteLine($"Total price: {totalPrice:F2}");
        }
    }
}
