using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace Calculator.Library.test
{
    [TestClass]
    public class CalculatorTests
    {
        public TestContext TextContext { get; set; }
        
        [TestMethod]
        [TestCategory("Calculator")]
        [Priority(1)]
        public void Test_Divide()
        {
            //Arrange 
            int expected = 5;
            int numerator = 20;
            int denominator = 4;

            //Act
            int actual=Calculator.Divide(numerator, denominator);

            //Assert
            Assert.AreEqual(expected, actual);
            TextContext.WriteLine(TextContext.FullyQualifiedTestClassName);
            
            TextContext.WriteLine(TextContext.TestName);
            
        }
        [TestCleanup]
        public void CleanUp()
        {
            TextContext.WriteLine(TextContext.CurrentTestOutcome.ToString());

        }
        [TestMethod]
        [TestCategory("Calculator")]
        [Priority(1)]
        public void Test_Divide_PositiveNumeratorAndNegativeDemonirator_ReturnNegativeQuotient()
        {
            int expected = -5;
            int numerator = 20;
            int denominator = -4;

            //Act
            int actual =Calculator.Divide(numerator, denominator);

            //Assert
            Assert.AreEqual(expected, actual);
          

        }
        [TestMethod]
        [TestCategory("Calculator")]
        [Priority(1)]
        public void Test_Divide_NegativeNumeratorAndNegativeDemonirator_ReturnPositiveQuotient()
        {
            int expected = 5;
            int numerator = -20;
            int denominator = -4;

            //Act
            int actual = Calculator.Divide(numerator, denominator);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        [Priority(1)]
        public void Test_Divide_DemoniratorIsZero_ReturnDivideByZeroException()

        {

            int numerator = -20;
            int denominator = 0;

            //Act
            try
            {
                Calculator.Divide(numerator, denominator);
            }
            catch (DivideByZeroException ex)
            {
                //Assert
                Assert.AreEqual("Demonirator cannot be zero", ex.Message);
                throw;
            }
        }

            [TestMethod]
            public void IsPositive_PositiveNumber_returnsTrue()
            {

                PrivateObject p = new PrivateObject(typeof(Calculator));
               bool actual=(bool) p.Invoke("IsPositive", 10);
                Assert.IsTrue(actual);
            }


        

    }
}
