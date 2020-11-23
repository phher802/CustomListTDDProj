using System;
using CustomListProj;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestCustomListProj
{
    [TestClass]
    public class CustomListTest
    {
        [TestMethod]
        public void Add_PostiveInteger_CountOfOne()
        {
            //Arrange - variables, objects, etc.
            CustomList<int> myList = new CustomList<int>();
            int value1 = 5;
            int expected = 1;
            int actual;


            //Act
            myList.Add(value1);
            actual = myList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_PostiveInteger_CountOf3()
        {
            //Arrange - variables, objects, etc.
            CustomList<int> myList = new CustomList<int>();
            int value1 = 5;
            int value2 = 8;
            int value3 = 9;
            int expected = 3;
            int actual;


            //Act
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            actual = myList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_PostiveInteger_CapacityOf8()
        {
            //Arrange - variables, objects, etc.
            CustomList<int> myList = new CustomList<int>();
            int value1 = 5;
            int value2 = 8;
            int value3 = 9;
            int value4 = 9;
            int value5 = 9;
            int expected = 8;
            int actual;


            //Act
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);
            myList.Add(value5);
            actual = myList.Capacity;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_StringToList_CapacityOf8()
        {
            //Arrange - variables, objects, etc.
            CustomList<string> myList = new CustomList<string>();
            string hello = "Hello";
            string comma = ", ";
            string how = "How";
            string are = "are";
            string you = "you";
            string questionMark = "? ";

            int expected = 8;
            int actual;


            //Act
            myList.Add(hello);
            myList.Add(comma);
            myList.Add(how);
            myList.Add(are);
            myList.Add(you);
            myList.Add(questionMark);

            actual = myList.Capacity;


            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_StringToList_CountOf2()
        {
            //Arrange - variables, objects, etc.
            CustomList<string> myList = new CustomList<string>();
            string hello = "Hello ";
            string world = "World ";


            int expected = 2;
            int actual;


            //Act
            myList.Add(hello);
            myList.Add(world);


            actual = myList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_TwoLists_CountOf4()
        {
            //Arrange - variables, objects, etc.
            CustomList<string> myList = new CustomList<string>();
            string hello = "Hello ";
            string world = "World ";

            CustomList<string> myOtherList = new CustomList<string>();
            string how = "how";
            string beautiful = "beautiful";


            int expected = 4;
            int actual;


            //Act
            myList.Add(hello);
            myList.Add(world);
            myOtherList.Add(how);
            myOtherList.Add(beautiful);


            actual = myList.Count + myOtherList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_PositiveInteger_CountOf5()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value1 = 2;
            int value2 = 4;
            int value3 = 6;
            int value4 = 8; 

            //Act


            // Assert
        }

       
    }
}
    
