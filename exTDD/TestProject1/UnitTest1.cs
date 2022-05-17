using Microsoft.VisualStudio.TestTools.UnitTesting;
using exTDD;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double num1 =  1;
            double num2 = -2;
            calcule calcule = new calcule(num1, num2);

            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => calcule.Addition());
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => calcule.Soustraction());
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => calcule.Division());
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => calcule.Multiplication());

        }

    }
}