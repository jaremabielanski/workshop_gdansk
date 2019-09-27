using NUnit.Framework;
using Calc;

namespace NUnitTests
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Dodawanie()
        {

            float res;

            Calc.MathData md = new MathData(3,3,'d');
            res = Calc.Calculations.Oper(md);
            Assert.AreEqual(6,res);

            md.firstNumber = 5;
            md.secondNumber = 6;
            md.operation = 'd';
            
            res = Calc.Calculations.Oper(md);
            Assert.AreEqual(11, res);

        }

        [Test]
        public void Dzielenie()
        {

            float res;

            Calc.MathData md = new MathData(3, 7, 'e');
            res = Calc.Calculations.Oper(md);
            Assert.AreEqual(0, res);

            md.firstNumber = 66;
            md.secondNumber = 6;
            md.operation = '/';

            res = Calc.Calculations.Oper(md);
            Assert.AreEqual(11, res);

        }
        
    }
}