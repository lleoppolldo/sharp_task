using System;
using System.Collections.Generic;
using System.Text;

namespace task5
{
    //Создание интерфейса
    interface ISpaceObject
    {
        //поле имени
        string Name { get; set; }
        //обозначаем методы движения и взрыва
        void Move();
        void Explode();
    }
}
