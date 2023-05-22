using System;
using System.Collections.Generic;
using System.Text;

namespace task5
{
    //создаем класс красного гиганта (наследник класса звезда)
    class RedGiant : Star
    {
        //конструктор класса крансого гиганта заполняет поля
        public RedGiant(string name, int age, double mass)
        {
            Name = name;
            Age = age;
            Mass = mass;
            IsDying = true;
        }
        //переопределяем метод сияния (даём ему функционал)
        public override void Shine()
        {
            Console.WriteLine("Красный гигант сияет ярко!");
        }
        //добавляем методы изменения размера и массы
        public void ChangeSize()
        {
            Console.WriteLine("Размер красного гиганта меняется!");
        }

        public void LoseMass()
        {
            Console.WriteLine("Красный гигант теряет массу!");
        }
    }
}
