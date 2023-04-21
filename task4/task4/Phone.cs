using System;


namespace task4
{
    public class Phone
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Memory { get; set; }

        public Phone(string name,int price,int memory)
        {
            Name = name;
            Price = price;
            Memory = memory;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine("Phone: " + Name);
            Console.WriteLine("Price: " + Price + " rub");
            Console.WriteLine("Memory: " + Memory + " Gb");
            Console.WriteLine("MemoryPerPrice: " + MemoryPerPrice() + " Gb/rub");
        }

        private double MemoryPerPrice()
        {
            return Convert.ToDouble(Memory) / Convert.ToDouble(Price);
        }

    }

}
