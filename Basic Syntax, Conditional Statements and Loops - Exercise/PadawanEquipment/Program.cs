using System;

namespace PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double priceSaber = double.Parse(Console.ReadLine());
            double priceRobe = double.Parse(Console.ReadLine());
            double priceBelt = double.Parse(Console.ReadLine());

            int neededSabers = students + (int)Math.Ceiling(students * 0.1);
            int neededBelts = students - (int)Math.Floor((double)students / 6);

            double totalCost = (neededSabers * priceSaber) + (neededBelts * priceBelt) + (students * priceRobe);

            if (money >= totalCost)
            {
                Console.WriteLine($"The money is enough - it would cost {totalCost:F2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {Math.Abs(money - totalCost):F2}lv more.");
            }
        }
    }
}
