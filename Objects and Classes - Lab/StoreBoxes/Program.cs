using System;
using System.Collections.Generic;
using System.Linq;

namespace StoreBoxes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();

            string input;

            while((input = Console.ReadLine()) != "end")
            {
                string[] boxData = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string serialNumber = boxData[0];
                string itemName = boxData[1];
                int itemQuantity = int.Parse(boxData[2]);
                double itemPrice = double.Parse(boxData[3]);

                Item item = new Item(itemName, itemPrice);
                Box box = new Box(serialNumber, item, itemQuantity);

                boxes.Add(box);
            }

            foreach (Box box in boxes.OrderByDescending(b => b.Price))
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:F2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.Price:F2}");
            }
        }
    }

    public class Item
    {
        public Item(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name { get; set; }
        public double Price { get; set; }
    }

    public class Box
    {
        public Box(string serialNumber, Item item, int itemQuantity)
        {
            this.SerialNumber = serialNumber;
            this.Item = item;
            this.ItemQuantity = itemQuantity;
            this.Price = this.Item.Price * this.ItemQuantity;
        }
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public double Price { get; set; }
    }
}
