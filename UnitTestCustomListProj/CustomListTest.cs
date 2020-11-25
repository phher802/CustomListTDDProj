﻿using System;
using CustomListProj;
using System.Linq;
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
            int expected = 5;
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

            int expected = 6;
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
        public void Remove_PositiveInteger_CountOf1()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value1 = 2;
            int value2 = 4;
            int value3 = 6;


            int expected = 1;
            int actual;

            //Act
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            myList.Remove(value1);
            myList.Remove(value2);

            actual = myList.Count;

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_PositiveInteger_CapacityOf4()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value1 = 2;
            int value2 = 4;
            int value3 = 6;
            int value4 = 8;
            int value5 = 10;


            int expected = 3;
            int actual;

            //Act
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);
            myList.Add(value5);
            myList.Remove(value1);
            myList.Remove(value2);

            actual = myList.Capacity;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_StringsFromList_CountOfOne()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();
            string value1 = "Happy";
            string value2 = "Turkey";
            string value3 = "Day";
            string value4 = "Everyone";

            int expected = 1;
            int actual;

            //Act
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);
            myList.Remove(value2);
            myList.Remove(value3);
            myList.Remove(value4);

            actual = myList.Count;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_IntegerFromList_CapacityOf8()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value1 = 2;
            int value2 = 4;
            int value3 = 6;
            int value4 = 8;
            int value5 = 10;
            int value6 = 12;


            int expected = 4;
            int actual;

            //Act
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);
            myList.Add(value5);
            myList.Add(value6);
            myList.Remove(value1);
            myList.Remove(value2);

            actual = myList.Capacity;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_PositiveInteger_CountOf8()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value1 = 2;
            int value2 = 4;
            int value3 = 6;
            int value4 = 8;
            int value5 = 10;


            int expected = 3;
            int actual;

            //Act
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);
            myList.Add(value5);
            myList.Remove(value1);
            myList.Remove(value5);


            actual = myList.Count;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Indexer_AccessStringViaIndex_StringAtIndex2IsLion()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();

            string value1 = "leopard";
            string value2 = "tiger";
            string value3 = "lion";

            string expected = "lion";
            string actual;

            // Act
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);

            actual = myList[2];

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Indexer_SetStringIndex_IndexFourIsParrot()
        {
            CustomList<string> birdList = new CustomList<string>();

            string value1 = "Flamingo";
            string value2 = "PUffin";
            string value3 = "Peacock";

            string expected = "Parrot";
            string actual;

            // Act
            birdList.Add(value1);
            birdList.Add(value2);
            birdList.Add(value3);

            birdList[4] = "Parrot";

            actual = birdList[4];

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Indexer_GetIntegerAtIndex_IndexZeroIs3()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value1 = 3;
            int value2 = 6;
            int value3 = 9;
            int value4 = 12;



            int expected = 3;
            int actual;

            //Act
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);

            actual = myList[0];

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Indexer_SetAccessorWithInteger_Index3Is4()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;


            int expected = 4;
            int actual;

            //Act
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);

            myList[3] = 4;

            actual = myList[3];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Indexer_EnsureUserCannotAccessOutOfBound_OutOfBound()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            int value1 = 2;
            int value2 = 4;
            int value3 = 6;

            int expected = 0;
            int actual;

            //Act
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);


            actual = myList[5];

            //Assert
            Assert.AreEqual(expected, actual);
            //unusre if this test is correctly testing out of bournd
        }

        [TestMethod]
        public void ToString_ConvertContentsToString_ReturnStringSentence()
        {
            CustomList<double> myList = new CustomList<double>();

            double value1 = 2.5;
            double value2 = 3.6;


            string expected = "2.5 3.6";
            string actual;

            //Act
            myList.Add(value1);
            myList.Add(value2);


            actual = myList.ToString();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToString_ConvertContentsToString_ReturnIntToString()
        {
            // Arrange
            CustomList<int> myList = new CustomList<int>();

            int id = 44559;

            string expected = "44559";
            string actual;

            //Act
            myList.Add(id);

            actual = myList.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToString_ConvertIntegerToString_()
        {
            CustomList<int> myList = new CustomList<int>();

            int value1 = 1234;
            int value2 = 5678;

            string expected = "12345678";
            string actual;
            //Act
            myList.Add(value1);
            myList.Add(value2);

            actual = myList.ToString();

            Assert.AreEqual(expected, actual);
        }

    }

}





