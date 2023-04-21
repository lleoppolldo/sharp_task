using System;
using System.Collections.Generic;

namespace task3
{
    public class OnedimensionalArray
    {
        private List<Element> elements;
        public int Size { get; set; }
        public string Type { get; set; }

        public OnedimensionalArray()
        {
            elements = new List<Element>();
        }

        public void Create(int[] array)
        {
            elements.Clear();
            foreach (int value in array)
            {
                Element element = new Element();
                element.Value = value;
                elements.Add(element);
            }
        }
        public int GetSize()
        {
            return elements.Count;
        }

        public new Type GetType()
        {
            return elements[0].Value.GetType();
        }

        public void Print()
        {
            foreach (Element element in elements)
            {
                Console.Write(element.Value + " ");
            }
            Console.WriteLine();
        }

        public void Add(OnedimensionalArray array)
        {
            int minLength = Math.Min(elements.Count, array.elements.Count);
            for (int i = 0; i < minLength; i++)
            {
                elements[i].Value += array.elements[i].Value;
            }
        }

        public void Subtract(OnedimensionalArray array)
        {
            int minLength = Math.Min(elements.Count, array.elements.Count);
            for (int i = 0; i < minLength; i++)
            {
                elements[i].Value -= array.elements[i].Value;
            }
        }

        public void Multiply(int number)
        {
            foreach (Element element in elements)
            {
                element.Value *= number;
            }
        }
    }
}

 

