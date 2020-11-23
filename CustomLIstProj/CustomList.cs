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
            Capacity = 4;
            _items = new T[Capacity];
        }

        // methods
        public void Add(T valueToAdd)
        {
            _items[Count] = valueToAdd;
            Count++;
        }
        
    }

}

