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
        public string name;

        //constructor
        public CustomList()
        {
            Count = 0;
            Capacity = 8;
            _items = new T[Capacity];
            
        }

        // methods
        public void Add(T valueToAdd)
        {
            _items[Count] = valueToAdd;
            Count++;
                 

        }
        
        public void Remove(T valueToRemove)
        {
            _items[Count] = valueToRemove;
            Count--;
            

        }
    
    }

}

