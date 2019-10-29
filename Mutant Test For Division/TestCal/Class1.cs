using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AwesomeCalculator;
using NUnit.Framework;

namespace TestCal
{
    [TestFixture]
    class TestCal
    {
        //Test 1: Addition
        [Test]
        public void DoAddition_Input2and2_Returns4()
        {
            //Arrange 
            double num1 = 2;
            double num2 = 2;
            double ResultExpected = num1 + num2;
            Calc testCalulation = new Calc(num1, num2);
            //Act
            double aResult = testCalulation.GetAddition();
            //Assert
            Assert.AreEqual(ResultExpected, aResult);
        }

        //Test 2: Addition
        [Test]
        public void DoAddition_Input3and2_Returns5()
        {
            //Arrange 
            double num1 = 3;
            double num2 = 2;
            double ResultExpected = num1 + num2;
            Calc testCalulation = new Calc(num1, num2);
            //Act
            double aResult = testCalulation.GetAddition();
            //Assert
            Assert.AreEqual(ResultExpected, aResult);
        }

        //Test 3: Addition
        [Test]
        public void DoAddition_Input4and3_Returns7()
        {
            //Arrange 
            double num1 = 4;
            double num2 = 3;
            double ResultExpected = num1 + num2;
            Calc testCalulation = new Calc(num1, num2);
            //Act
            double aResult = testCalulation.GetAddition();
            //Assert
            Assert.AreEqual(ResultExpected, aResult);
        }

        //Test 1: Subtraction
        [Test]
        public void DoSubtraction_Input3and2_Returns1()
        {
            //Arrange 
            double num1 = 3;
            double num2 = 2;
            double ResultExpected = num1 - num2;
            Calc testCalulation = new Calc(num1, num2);
            //Act
            double aResult = testCalulation.GetSubtraction();
            //Assert
            Assert.AreEqual(ResultExpected, aResult);
        }

        //Test 2: Subtraction
        [Test]
        public void DoSubtraction_Input6and1_Returns5()
        {
            //Arrange 
            double num1 = 6;
            double num2 = 1;
            double ResultExpected = num1 - num2;
            Calc testCalulation = new Calc(num1, num2);
            //Act
            double aResult = testCalulation.GetSubtraction();
            //Assert
            Assert.AreEqual(ResultExpected, aResult);
        }

        //Test 3: Subtraction
        [Test]
        public void DoSubtraction_Input8and5_Returns3()
        {
            //Arrange 
            double num1 = 8;
            double num2 = 5;
            double ResultExpected = num1 - num2;
            Calc testCalulation = new Calc(num1, num2);
            //Act
            double aResult = testCalulation.GetSubtraction();
            //Assert
            Assert.AreEqual(ResultExpected, aResult);
        }
        //Test 1: Multiplication
        [Test]
        public void DoMultiplication_Input3and5_Returns15()
        {
            //Arrange 
            double num1 = 3;
            double num2 = 5;
            double ResultExpected = num1 * num2;
            Calc testCalulation = new Calc(num1, num2);
            //Act
            double aResult = testCalulation.GetMultiplication();
            //Assert
            Assert.AreEqual(ResultExpected, aResult);
        }
        //Test 2: Multiplication
        [Test]
        public void DoMultiplication_Input2and4_Returns8()
        {
            //Arrange 
            double num1 = 2;
            double num2 = 4;
            double ResultExpected = num1 * num2;
            Calc testCalulation = new Calc(num1, num2);
            //Act
            double aResult = testCalulation.GetMultiplication();
            //Assert
            Assert.AreEqual(ResultExpected, aResult);
        }
        //Test 3: Multiplication
        [Test]
        public void DoMultiplication_Input1and6_Returns6()
        {
            //Arrange 
            double num1 = 1;
            double num2 = 6;
            double ResultExpected = num1 * num2;
            Calc testCalulation = new Calc(num1, num2);
            //Act
            double aResult = testCalulation.GetMultiplication();
            //Assert
            Assert.AreEqual(ResultExpected, aResult);
        }
        //Test 1: Division
        [Test]
        public void DoDivision_Input5and1_Returns5()
        {
            //Arrange 
            double num1 = 5;
            double num2 = 1;
            double ResultExpected = num1 / num2;
            Calc testCalulation = new Calc(num1, num2);
            //Act
            double aResult = testCalulation.GetDivision();
            //Assert
            Assert.AreEqual(ResultExpected, aResult);
        }
        //Test 2: Division
        [Test]
        public void DoDivision_Input15and3_Returns5()
        {
            //Arrange 
            double num1 = 15;
            double num2 = 3;
            double ResultExpected = num1 / num2;
            Calc testCalulation = new Calc(num1, num2);
            //Act
            double aResult = testCalulation.GetDivision();
            //Assert
            Assert.AreEqual(ResultExpected, aResult);
        }
        //Test 3: Division
        [Test]
        public void DoDivision_Input8and4_Returns2()
        {
            //Arrange 
            double num1 = 8;
            double num2 = 4;
            double ResultExpected = num1 / num2;
            Calc testCalulation = new Calc(num1, num2);
            //Act
            double aResult = testCalulation.GetDivision();
            //Assert
            Assert.AreEqual(ResultExpected, aResult);
        }
        
        //Addition Test Cases

        //Test 1: Additional For Addition
        [Test]
        public void DoAdditon_Input3and4_Returns7()
        {
            //Arrange 
            double num1 = 3;
            double num2 = 4;
            double ResultExpected = num1 + num2;
            Calc testCalulation = new Calc(num1, num2);
            //Act
            double aResult = testCalulation.GetAddition();
            //Assert
            Assert.AreEqual(ResultExpected, aResult);
        }
        //Test 2: Additional For Addition
        [Test]
        public void DoAdditon_Input16and4_Returns20()
        {
            //Arrange 
            double num1 = 16;
            double num2 = 4;
            double ResultExpected = num1 + num2;
            Calc testCalulation = new Calc(num1, num2);
            //Act
            double aResult = testCalulation.GetAddition();
            //Assert
            Assert.AreEqual(ResultExpected, aResult);
        }
        //Test 3: Additional For Addition
        [Test]
        public void DoAdditon_Input6and24_Returns30()
        {
            //Arrange 
            double num1 = 6;
            double num2 = 24;
            double ResultExpected = num1 + num2;
            Calc testCalulation = new Calc(num1, num2);
            //Act
            double aResult = testCalulation.GetAddition();
            //Assert
            Assert.AreEqual(ResultExpected, aResult);
        }
        //Test 4: Additional For Addition
        [Test]
        public void DoAdditon_Input3and3_Returns6()
        {
            //Arrange 
            double num1 = 16;
            double num2 = 4;
            double ResultExpected = num1 + num2;
            Calc testCalulation = new Calc(num1, num2);
            //Act
            double aResult = testCalulation.GetAddition();
            //Assert
            Assert.AreEqual(ResultExpected, aResult);
        }
        //Test 1: Additional For Subtraction
        [Test]
        public void DoSubtraction_Input6and4_Returns2()
        {
            //Arrange 
            double num1 = 6;
            double num2 = 4;
            double ResultExpected = num1 - num2;
            Calc testCalulation = new Calc(num1, num2);
            //Act
            double aResult = testCalulation.GetSubtraction();
            //Assert
            Assert.AreEqual(ResultExpected, aResult);
        }
        //Test 2: Additional For Subtraction
        [Test]
        public void DoSubtraction_Input5and5_Returns0()
        {
            //Arrange 
            double num1 = 5;
            double num2 = 5;
            double ResultExpected = num1 - num2;
            Calc testCalulation = new Calc(num1, num2);
            //Act
            double aResult = testCalulation.GetSubtraction();
            //Assert
            Assert.AreEqual(ResultExpected, aResult);
        }
        //Test 3: Additional For Subtraction
        [Test]
        public void DoSubtraction_Input5and3_Returns2()
        {
            //Arrange 
            double num1 = 5;
            double num2 = 3;
            double ResultExpected = num1 - num2;
            Calc testCalulation = new Calc(num1, num2);
            //Act
            double aResult = testCalulation.GetSubtraction();
            //Assert
            Assert.AreEqual(ResultExpected, aResult);
        }
        //Test 4: Additional For Subtraction
        [Test]
        public void DoSubtraction_Input15and5_Returns10()
        {
            //Arrange 
            double num1 = 15;
            double num2 = 5;
            double ResultExpected = num1 - num2;
            Calc testCalulation = new Calc(num1, num2);
            //Act
            double aResult = testCalulation.GetSubtraction();
            //Assert
            Assert.AreEqual(ResultExpected, aResult);
        }
        //Test 1: Additional For Multiplication
        [Test]
        public void DoMultiplication_Input5and5_Returns25()
        {
            //Arrange 
            double num1 = 5;
            double num2 = 5;
            double ResultExpected = num1 * num2;
            Calc testCalulation = new Calc(num1, num2);
            //Act
            double aResult = testCalulation.GetMultiplication();
            //Assert
            Assert.AreEqual(ResultExpected, aResult);
        }
        //Test 2: Additional For Multiplication
        [Test]
        public void DoMultiplication_Input3and3_Returns9()
        {
            //Arrange 
            double num1 = 3;
            double num2 = 3;
            double ResultExpected = num1 * num2;
            Calc testCalulation = new Calc(num1, num2);
            //Act
            double aResult = testCalulation.GetMultiplication();
            //Assert
            Assert.AreEqual(ResultExpected, aResult);
        }

        //Test 3: Additional For Multiplication
        [Test]
        public void DoMultiplication_Input4and3_Returns12()
        {
            //Arrange 
            double num1 = 4;
            double num2 = 3;
            double ResultExpected = num1 * num2;
            Calc testCalulation = new Calc(num1, num2);
            //Act
            double aResult = testCalulation.GetMultiplication();
            //Assert
            Assert.AreEqual(ResultExpected, aResult);
        }
        //Test 4: Additional For Multiplication
        [Test]
        public void DoMultiplication_Input2and3_Returns6()
        {
            //Arrange 
            double num1 = 2;
            double num2 = 3;
            double ResultExpected = num1 * num2;
            Calc testCalulation = new Calc(num1, num2);
            //Act
            double aResult = testCalulation.GetMultiplication();
            //Assert
            Assert.AreEqual(ResultExpected, aResult);
        }
        //Test 1: Additional For Division
        [Test]
        public void DoDivision_Input2and2_Returns1()
        {
            //Arrange 
            double num1 = 2;
            double num2 = 2;
            double ResultExpected = num1 / num2;
            Calc testCalulation = new Calc(num1, num2);
            //Act
            double aResult = testCalulation.GetDivision();
            //Assert
            Assert.AreEqual(ResultExpected, aResult);
        }
        //Test 2: Additional For Division
        [Test]
        public void DoDivision_Input6and2_Returns3()
        {
            //Arrange 
            double num1 = 6;
            double num2 = 2;
            double ResultExpected = num1 / num2;
            Calc testCalulation = new Calc(num1, num2);
            //Act
            double aResult = testCalulation.GetDivision();
            //Assert
            Assert.AreEqual(ResultExpected, aResult);
        }
        //Test 3: Additional For Division
        [Test]
        public void DoDivision_Input16and2_Returns8()
        {
            //Arrange 
            double num1 = 16;
            double num2 = 2;
            double ResultExpected = num1 / num2;
            Calc testCalulation = new Calc(num1, num2);
            //Act
            double aResult = testCalulation.GetDivision();
            //Assert
            Assert.AreEqual(ResultExpected, aResult);
        }
        //Test 3: Additional For Division
        [Test]
        public void DoDivision_Input56and7_Returns8()
        {
            //Arrange 
            double num1 = 56;
            double num2 = 7;
            double ResultExpected = num1 / num2;
            Calc testCalulation = new Calc(num1, num2);
            //Act
            double aResult = testCalulation.GetDivision();
            //Assert
            Assert.AreEqual(ResultExpected, aResult);
        }
        //Test 4: Additional For Division
        [Test]
        public void DoDivision_Input36and6_Returns6()
        {
            //Arrange 
            double num1 = 36;
            double num2 = 6;
            double ResultExpected = num1 / num2;
            Calc testCalulation = new Calc(num1, num2);
            //Act
            double aResult = testCalulation.GetDivision();
            //Assert
            Assert.AreEqual(ResultExpected, aResult);
        }
    }
}

 