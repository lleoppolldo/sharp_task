using System;
using System.Collections.Generic;
using System.Text;

namespace task5
{
    //создаем абстрактный класс звезды и подвязываем интерфейс
    abstract class Star : ISpaceObject
    {
        //поля класса звезды 
        public string Name { get; set; }
        public int Age { get; protected set; }
        public double Mass { get; protected set; }
        public bool IsDying { get; protected set; }
        //обозначаем абстрактный метод сияния звезды
        public abstract void Shine();
        //определяем методы движения и взрыва
        public void Move()
        {
            Console.WriteLine("Звезда движется");
        }

        public void Explode()
        {
            Console.WriteLine("Звезда взорвалась!");
        }
    }
}
