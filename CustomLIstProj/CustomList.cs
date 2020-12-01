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

        public CustomList(int num)
        {
            Count = 0;
            Capacity = num;
            _items = new T[Capacity];

        }
        //this method was not necessary although would be uselful
        //public void TrimExcess(T[] list)
        //{
        //    int threshold = (int)(((double)Capacity) * 0.9);
        //    if (Count < threshold)
        //    {
        //        Capacity = Count;
        //    }
        //}


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

        public void Remove(T valueToRemove) //6
        {

            bool isFound = false;

            for (int i = 0; i < Count + 1; i++)
            {

                if (isFound == false && _items[i].Equals(valueToRemove))
                {
                    //_items[Count] = valueToRemove;
                    //valueToRemove = _items[i];
                    Count--;
                    _items[i] = _items[i + 1];
                    isFound = true;
                    //2, 4, 8, 10
                }
                else if (isFound == true)
                {
                    _items[i] = _items[i + 1];
                }

            }

        }

        public T this[int i]
        {
            get
            {
                if (i >= 0 && i < Count)
                { return _items[i]; }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }

            }
            set
            {
                if (i >= 0 && i < Count)
                { _items[i] = value; }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
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

        public static CustomList<T> operator +(CustomList<T> listOne, CustomList<T> listTwo)
        {
            CustomList<T> newList = new CustomList<T>();

            for (int i = 0; i < listOne.Count; i++)
            {
                newList.Add(listOne[i]);
            }

            for (int i = 0; i < listTwo.Count; i++)
            {
                newList.Add(listTwo[i]);
            }


            return newList;
        }

        public static CustomList<T> operator -(CustomList<T> listOne, CustomList<T> listTwo)
        {
            CustomList<T> newList = new CustomList<T>();


            for (int i = 0; i < listOne.Count; i++)
            {

                if (listOne.Count == (-listOne.Count))
                {
                    newList.Add(listOne[i]);

                }
          
                //newList.Add(listOne[i]);


                //if (listOne[i].ToString() != listTwo[i].ToString())
                //{
                //    newList.Add(listTwo[i]);
                //}

            }


            for (int i = 0; i < listTwo.Count; i++)
            {
                if (listTwo.Count != (-listTwo.Count))
                {
                    newList.Add(listTwo[i]);
                }
                //removeList.Add(listOne[i]);
                //newList.Add(listOne[i]);


                //if (listOne[i].ToString() != listTwo[i].ToString())
                //{
                //    newList.Add(listTwo[i]);
                //}

            }



            //else if (listOne.Count < listTwo.Count)
            //{
            //    for (int i = 0; i < listTwo.Count; i++)
            //    {
            //        if (listTwo.Count != -listTwo.Count)
            //        {
            //            //removeList.Add(listOne[i]);
            //            newList.Add(listTwo[i]);
            //        }

            //        if (newList[i].ToString() != listOne[i].ToString())
            //        {
            //            newList.Add(listOne[i]);
            //        }

            //    }

            //(listOne[i].ToString() != listTwo[i].ToString()




            //}
            return newList;


        }








    }

}



