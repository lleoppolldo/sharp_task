using System;

namespace task4
{
    public class MobilePhone : Phone
    {
        public int NumOfSim { get; set; }
        public MobilePhone(string name, int price, int memory,int numofsim): base (name,price,memory)
        {
            NumOfSim = numofsim;
        }

        private new double MemoryPerPrice()
        {
            return Convert.ToDouble(Memory) / Convert.ToDouble(Price) * NumOfSim;
        }

        public override void ShowInfo()
        {
            Console.WriteLine("\nPhone: " + Name);
            Console.WriteLine("Price: " + Price + " rub");
            Console.WriteLine("Memory: " + Memory + " Gb");
            Console.WriteLine("Number of sims: " + NumOfSim);
            Console.WriteLine("MemoryPerPriceForSim: " + MemoryPerPrice() + " Gb/rub");
        }
    }

}
