using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProj
{
    public class CustomList<T>
    {
        // member variables
        T[] _items;
        public int Count;
        public int Capacity;
        

        //constructor
        public CustomList()
        {
            Count = 0;
            Capacity = 100;
            _items = new T[Capacity];

        }

        public void TrimExcess(T[] list)
        {
            int threshold = (int)(((double)_items.Length) * 0.9);
            if (Count < threshold)
            {
                Capacity = Count;
            }
        }

        
        // methods
        public void Add(T valueToAdd)
        {
            _items[Count] = valueToAdd;
            Count++;
            TrimExcess(_items);



        }

        public void Remove(T valueToRemove)
        {
            _items[Count] = valueToRemove;
            Count--;
            TrimExcess(_items);

        }


        public T this[int i]
        {
            get
            {
                if (i >= 0 && i < _items.Length)
                { return _items[i]; }
                return default(T);
            }
            set
            {
                if (i >= 0 && i < _items.Length)
                { _items[i] = value; }
            }
        }

        public override string ToString()
        {
            string value = " ";

            foreach (T item in _items)
            {

                value += item.ToString();
                Console.WriteLine(value);

            }





            return value;

        }

    }

}

