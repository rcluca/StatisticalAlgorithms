using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StatisticalAlgorithms;

namespace StatisticalAlgorithmsTests
{
    [TestClass]
    public class PermutationsTests
    {
        Permutations p = new Permutations();

        #region String Permutations

        [TestMethod]
        public void GetPermutationsStringNull()
        {
            // Arrange
            string str = null;

            // Act
            try
            {
                List<string> list = p.GetPermutations(str);
                Assert.Fail("NullReferenceException was not thrown.");
            }

            // Assert
            catch (NullReferenceException ex)
            {

            }
            catch (Exception ex)
            {
                Assert.Fail(String.Format("Unexpected exception of type {0} caught with message: {1}", ex.GetType(), ex.Message));
            }
        }

        [TestMethod]
        public void GetUniquePermutationsStringNull()
        {
            // Arrange
            string str = null;

            // Act
            try
            {
                List<string> list = p.GetUniquePermutations(str);
                Assert.Fail("NullReferenceException was not thrown.");
            }

            // Assert
            catch (NullReferenceException ex)
            {

            }
            catch (Exception ex)
            {
                Assert.Fail(String.Format("Unexpected exception of type {0} caught with message: {1}", ex.GetType(), ex.Message));
            }
        }

        [TestMethod]
        public void GetPermutationsStringEmpty()
        {
            // Arrange
            string str = "";

            // Act
            List<string> list = p.GetPermutations(str);

            // Assert
            Assert.AreEqual(0, list.Count);
        }

        [TestMethod]
        public void GetUniquePermutationsStringEmpty()
        {
            // Arrange
            string str = "";

            // Act
            List<string> list = p.GetUniquePermutations(str);

            // Assert
            Assert.AreEqual(0, list.Count);
        }

        [TestMethod]
        public void GetPermutationsStringLength1()
        {
            // Arrange
            string str = "a";

            // Act
            List<string> list = p.GetPermutations(str);

            // Assert
            Assert.AreEqual(1, list.Count);
            Assert.AreEqual("a", list[0]);
        }

        [TestMethod]
        public void GetUniquePermutationsStringLength1()
        {
            // Arrange
            string str = "a";

            // Act
            List<string> list = p.GetUniquePermutations(str);

            // Assert
            Assert.AreEqual(1, list.Count);
            Assert.AreEqual("a", list[0]);
        }

        [TestMethod]
        public void GetPermutationsStringUniqueLength2()
        {
            // Arrange
            string str = "ab";

            // Act
            List<string> list = p.GetPermutations(str);
            list.Sort();

            // Assert
            Assert.AreEqual(2, list.Count);
            Assert.AreEqual("ab", list[0]);
            Assert.AreEqual("ba", list[1]);
        }

        [TestMethod]
        public void GetUniquePermutationsStringUniqueLength2()
        {
            // Arrange
            string str = "ab";

            // Act
            List<string> list = p.GetUniquePermutations(str);
            list.Sort();

            // Assert
            Assert.AreEqual(2, list.Count);
            Assert.AreEqual("ab", list[0]);
            Assert.AreEqual("ba", list[1]);
        }

        [TestMethod]
        public void GetPermutationsStringUniqueLength3()
        {
            // Arrange
            string str = "abc";

            // Act
            List<string> list = p.GetPermutations(str);
            list.Sort();

            // Assert
            Assert.AreEqual(6, list.Count);
            Assert.AreEqual("abc", list[0]);
            Assert.AreEqual("acb", list[1]);
            Assert.AreEqual("bac", list[2]);
            Assert.AreEqual("bca", list[3]);
            Assert.AreEqual("cab", list[4]);
            Assert.AreEqual("cba", list[5]);
        }

        [TestMethod]
        public void GetUniquePermutationsStringUniqueLength3()
        {
            // Arrange
            string str = "abc";

            // Act
            List<string> list = p.GetUniquePermutations(str);
            list.Sort();

            // Assert
            Assert.AreEqual(6, list.Count);
            Assert.AreEqual("abc", list[0]);
            Assert.AreEqual("acb", list[1]);
            Assert.AreEqual("bac", list[2]);
            Assert.AreEqual("bca", list[3]);
            Assert.AreEqual("cab", list[4]);
            Assert.AreEqual("cba", list[5]);
        }

        [TestMethod]
        public void GetPermutationsStringLength3()
        {
            // Arrange
            string str = "abb";

            // Act
            List<string> list = p.GetPermutations(str);
            list.Sort();

            // Assert
            Assert.AreEqual(6, list.Count);
            Assert.AreEqual("abb", list[0]);
            Assert.AreEqual("abb", list[1]);
            Assert.AreEqual("bab", list[2]);
            Assert.AreEqual("bab", list[3]);
            Assert.AreEqual("bba", list[4]);
            Assert.AreEqual("bba", list[5]);
        }

        [TestMethod]
        public void GetUniquePermutationsStringLength3()
        {
            // Arrange
            string str = "abb";

            // Act
            List<string> list = p.GetUniquePermutations(str);
            list.Sort();

            // Assert
            Assert.AreEqual(3, list.Count);
            Assert.AreEqual("abb", list[0]);
            Assert.AreEqual("bab", list[1]);
            Assert.AreEqual("bba", list[2]);
        }

        #endregion

        #region Int Permutations

        [TestMethod]
        public void GetPermutationsInt0()
        {
            // Arrange
            int num = 0;

            // Act
            List<int> list = p.GetPermutations(num);

            // Assert
            Assert.AreEqual(1, list.Count);
            Assert.AreEqual(0, list[0]);
        }

        [TestMethod]
        public void GetUniquePermutationsInt0()
        {
            // Arrange
            int num = 0;

            // Act
            List<int> list = p.GetUniquePermutations(num);

            // Assert
            Assert.AreEqual(1, list.Count);
            Assert.AreEqual(0, list[0]);
        }

        [TestMethod]
        public void GetPermutationsIntLength1()
        {
            // Arrange
            int num = 1;

            // Act
            List<int> list = p.GetPermutations(num);

            // Assert
            Assert.AreEqual(1, list.Count);
            Assert.AreEqual(1, list[0]);
        }

        [TestMethod]
        public void GetUniquePermutationsIntLength1()
        {
            // Arrange
            int num = 1;

            // Act
            List<int> list = p.GetUniquePermutations(num);

            // Assert
            Assert.AreEqual(1, list.Count);
            Assert.AreEqual(1, list[0]);
        }

        [TestMethod]
        public void GetPermutationsIntNegativeLength1()
        {
            // Arrange
            int num = -1;

            // Act
            List<int> list = p.GetPermutations(num);

            // Assert
            Assert.AreEqual(1, list.Count);
            Assert.AreEqual(-1, list[0]);
        }

        [TestMethod]
        public void GetUniquePermutationsIntNegativeLength1()
        {
            // Arrange
            int num = -1;

            // Act
            List<int> list = p.GetUniquePermutations(num);

            // Assert
            Assert.AreEqual(1, list.Count);
            Assert.AreEqual(-1, list[0]);
        }

        [TestMethod]
        public void GetPermutationsIntUniqueLength2()
        {
            // Arrange
            int num = 12;

            // Act
            List<int> list = p.GetPermutations(num);
            list.Sort();

            // Assert
            Assert.AreEqual(2, list.Count);
            Assert.AreEqual(12, list[0]);
            Assert.AreEqual(21, list[1]);
        }

        [TestMethod]
        public void GetUniquePermutationsIntUniqueLength2()
        {
            // Arrange
            int num = 12;

            // Act
            List<int> list = p.GetUniquePermutations(num);
            list.Sort();

            // Assert
            Assert.AreEqual(2, list.Count);
            Assert.AreEqual(12, list[0]);
            Assert.AreEqual(21, list[1]);
        }

        [TestMethod]
        public void GetPermutationsIntLength2()
        {
            // Arrange
            int num = 11;

            // Act
            List<int> list = p.GetPermutations(num);
            list.Sort();

            // Assert
            Assert.AreEqual(2, list.Count);
            Assert.AreEqual(11, list[0]);
            Assert.AreEqual(11, list[1]);
        }

        [TestMethod]
        public void GetUniquePermutationsIntLength2()
        {
            // Arrange
            int num = 11;

            // Act
            List<int> list = p.GetUniquePermutations(num);
            list.Sort();

            // Assert
            Assert.AreEqual(1, list.Count);
            Assert.AreEqual(11, list[0]);
        }

        [TestMethod]
        public void GetPermutationsIntNegativeUniqueLength2()
        {
            // Arrange
            int num = -12;

            // Act
            List<int> list = p.GetPermutations(num);
            list.Sort();

            // Assert
            Assert.AreEqual(2, list.Count);
            Assert.AreEqual(-21, list[0]);
            Assert.AreEqual(-12, list[1]);
        }

        [TestMethod]
        public void GetUniquePermutationsIntNegativeUniqueLength2()
        {
            // Arrange
            int num = -12;

            // Act
            List<int> list = p.GetUniquePermutations(num);
            list.Sort();

            // Assert
            Assert.AreEqual(2, list.Count);
            Assert.AreEqual(-21, list[0]);
            Assert.AreEqual(-12, list[1]);
        }

        [TestMethod]
        public void GetPermutationsIntNegativeLength2()
        {
            // Arrange
            int num = -11;

            // Act
            List<int> list = p.GetPermutations(num);
            list.Sort();

            // Assert
            Assert.AreEqual(2, list.Count);
            Assert.AreEqual(-11, list[0]);
            Assert.AreEqual(-11, list[1]);
        }

        [TestMethod]
        public void GetUniquePermutationsNegativeLength2()
        {
            // Arrange
            int num = -11;

            // Act
            List<int> list = p.GetUniquePermutations(num);
            list.Sort();

            // Assert
            Assert.AreEqual(1, list.Count);
            Assert.AreEqual(-11, list[0]);
        }

        [TestMethod]
        public void GetPermutationsIntUniqueWith0Length2()
        {
            // Arrange
            int num = 10;

            // Act
            List<int> list = p.GetPermutations(num);
            list.Sort();

            // Assert
            Assert.AreEqual(1, list.Count);
            Assert.AreEqual(10, list[0]);
        }

        [TestMethod]
        public void GetUniquePermutationsIntUniqueWith0Length2()
        {
            // Arrange
            int num = 10;

            // Act
            List<int> list = p.GetUniquePermutations(num);
            list.Sort();

            // Assert
            Assert.AreEqual(1, list.Count);
            Assert.AreEqual(10, list[0]);
        }

        [TestMethod]
        public void GetPermutationsIntWith0Length3()
        {
            // Arrange
            int num = 101;

            // Act
            List<int> list = p.GetPermutations(num);
            list.Sort();

            // Assert
            Assert.AreEqual(4, list.Count);
            Assert.AreEqual(101, list[0]);
            Assert.AreEqual(101, list[1]);
            Assert.AreEqual(110, list[2]);
            Assert.AreEqual(110, list[3]);
        }

        [TestMethod]
        public void GetUniquePermutationsIntWith0Length3()
        {
            // Arrange
            int num = 101;

            // Act
            List<int> list = p.GetUniquePermutations(num);
            list.Sort();

            // Assert
            Assert.AreEqual(2, list.Count);
            Assert.AreEqual(101, list[0]);
            Assert.AreEqual(110, list[1]);
        }

        [TestMethod]
        public void GetPermutationsIntUniqueWith0Length3()
        {
            // Arrange
            int num = 102;

            // Act
            List<int> list = p.GetPermutations(num);
            list.Sort();

            // Assert
            Assert.AreEqual(4, list.Count);
            Assert.AreEqual(102, list[0]);
            Assert.AreEqual(120, list[1]);
            Assert.AreEqual(201, list[2]);
            Assert.AreEqual(210, list[3]);
        }

        [TestMethod]
        public void GetUniquePermutationsIntUniqueWith0Length3()
        {
            // Arrange
            int num = 102;

            // Act
            List<int> list = p.GetUniquePermutations(num);
            list.Sort();

            // Assert
            Assert.AreEqual(4, list.Count);
            Assert.AreEqual(102, list[0]);
            Assert.AreEqual(120, list[1]);
            Assert.AreEqual(201, list[2]);
            Assert.AreEqual(210, list[3]);
        }

        [TestMethod]
        public void GetPermutationsIntNegativeUniqueWith0Length2()
        {
            // Arrange
            int num = -10;

            // Act
            List<int> list = p.GetPermutations(num);
            list.Sort();

            // Assert
            Assert.AreEqual(1, list.Count);
            Assert.AreEqual(-10, list[0]);
        }

        [TestMethod]
        public void GetUniquePermutationsIntNegativeUniqueWith0Length2()
        {
            // Arrange
            int num = -10;

            // Act
            List<int> list = p.GetUniquePermutations(num);
            list.Sort();

            // Assert
            Assert.AreEqual(1, list.Count);
            Assert.AreEqual(-10, list[0]);
        }

        [TestMethod]
        public void GetPermutationsIntNegativeWith0Length3()
        {
            // Arrange
            int num = -101;

            // Act
            List<int> list = p.GetPermutations(num);
            list.Sort();

            // Assert
            Assert.AreEqual(4, list.Count);
            Assert.AreEqual(-110, list[0]);
            Assert.AreEqual(-110, list[1]);
            Assert.AreEqual(-101, list[2]);
            Assert.AreEqual(-101, list[3]);
        }

        [TestMethod]
        public void GetUniquePermutationsIntNegativeWith0Length3()
        {
            // Arrange
            int num = -101;

            // Act
            List<int> list = p.GetUniquePermutations(num);
            list.Sort();

            // Assert
            Assert.AreEqual(2, list.Count);
            Assert.AreEqual(-110, list[0]);
            Assert.AreEqual(-101, list[1]);
        }

        [TestMethod]
        public void GetPermutationsIntNegativeUniqueWith0Length3()
        {
            // Arrange
            int num = -102;

            // Act
            List<int> list = p.GetPermutations(num);
            list.Sort();

            // Assert
            Assert.AreEqual(4, list.Count);
            Assert.AreEqual(-210, list[0]);
            Assert.AreEqual(-201, list[1]);
            Assert.AreEqual(-102, list[3]);
            Assert.AreEqual(-120, list[2]);
        }

        [TestMethod]
        public void GetUniquePermutationsIntNegativeUniqueWith0Length3()
        {
            // Arrange
            int num = -102;

            // Act
            List<int> list = p.GetUniquePermutations(num);
            list.Sort();

            // Assert
            Assert.AreEqual(4, list.Count);
            Assert.AreEqual(-210, list[0]);
            Assert.AreEqual(-201, list[1]);
            Assert.AreEqual(-102, list[3]);
            Assert.AreEqual(-120, list[2]);
        }

        #endregion

        #region String Permutations with Restrictions

        #endregion

        #region Int Permutations with Restrictions

        #endregion
    }
}
