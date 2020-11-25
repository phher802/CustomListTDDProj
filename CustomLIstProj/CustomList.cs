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
            Capacity = 3;
            _items = new T[Capacity];

        }

        public void TrimExcess(T[] list)
        {
            int threshold = (int)(((double)Capacity) * 0.9);
            if (Count < threshold)
            {
                Capacity = Count;
            }
        }


        // methods
        public void Add(T valueToAdd)
        {


            if (Count == Capacity)
            {
                //Capacity *= 2;

               ExpandArray(Capacity * 2);
            }

            _items[Count] = valueToAdd;
            Count++;
            //same as capacity = capacity * 2;

            //TrimExcess(_items);

        }
        public void ExpandArray(int newSize)
        {
            T[] newArray = new T[newSize];

            for (int i = 0; i < Count; i++)
            {
                newArray[i] = _items[i];
            }

            Capacity = newSize;
            _items = newArray;
            
        }

        public void Remove(T valueToRemove)
        {
            _items[Count] = valueToRemove;
            Count--;
            //TrimExcess(_items);

        }


        public T this[int i]
        {
            get
            {
                if (i >= 0 && i < Count)
                { return _items[i]; }
                throw new ArgumentOutOfRangeException();
            }
            set
            {
                if (i >= 0 && i < Count)
                { _items[i] = value; }
                throw new ArgumentOutOfRangeException();
            }
        }

        public override string ToString()
        {
            string value = "";


            for (int i = 0; i < Count; i++)
            {

                value += _items[i].ToString();

            }



            return value;

        }

    }

}

