using System;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            //создаем экземляры интерфейса
            ISpaceObject[] spaceObjects = new ISpaceObject[2];
            //создаем экземпляр класса красный гигант и выдаем ему значения полей
            RedGiant redGiant = new RedGiant("Betelgeuse", 9, 20);
            //вызов метода сияния
            redGiant.Shine();
            //подвзываем первый экземпляр интерфейса к экземпляру класса красный гигант
            spaceObjects[0] = redGiant;
            //создаем экземпляр класса звезда и выдаем ей значения полей
            Star star = new RedGiant("Antares", 14, 15.5);
            //вызов метод движения
            star.Move();
            //подвзываем второй экземпляр интерфейса к экземпляру класса звезда
            spaceObjects[1] = star;
            //вывод созданных экземпляров в консоль (их имён)
            foreach (ISpaceObject obj in spaceObjects)
            {
                Console.WriteLine(obj.Name);
            }
            //вызов методов изменения размера и взрыва
            redGiant.ChangeSize();
            star.Explode();
        }
    }
}

