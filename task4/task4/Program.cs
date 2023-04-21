using System;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone CasualPhone = new Phone("Motorola",2000,3);
            MobilePhone Phone = new MobilePhone("Iphone", 58368, 128, 2);
            CasualPhone.ShowInfo();
            Phone.ShowInfo();
        }
    }
}
