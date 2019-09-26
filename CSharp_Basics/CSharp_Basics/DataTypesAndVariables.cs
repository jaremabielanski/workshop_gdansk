// <copyright file="DataTypesAndVariables.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CSharp_Basics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using NUnit.Framework;

    // [] - defines attributes we will take closer look at them in day 3
    [TestFixture]

    // doc
    public class DataTypesAndVariables
    {
        /*
         *1. Select each test and uncomment it (Ctrl+K, Ctrl+U)
         *2. Then follow the rules described in summary.
         *3. run test.
         *4. If test passed, you could move to next exercise.
         */

        // usefull link: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/value-types

        //        /// <summary>
        //        /// Integers are symbolized as int
        //        /// create 3 integers with following names
        //        /// singleDigit, number, lessThanZero
        //        /// make they values:  6   14  -100
        //        /// </summary>
        [Test]

        // Method documentation ...
        public void Creating_Integeres()
        {
            // int - describes type
            // example - is name of variable, english names are preferred
            // =  equal sign is used for assigning values.
            // 0 - the value
            //  ; - IMPORTANT ';' sign means and of the command usually it is on end of the line - remember about it
            int example = 0;
            int singleDigit = 6;
            int number = 14;
            int lessThanZero = -100;

            Assert.AreEqual(example, 0, "Example Has wrong value did you changed it?");
            Assert.AreEqual(singleDigit, 6, "Example Has wrong value did you changed it?");
            Assert.That(singleDigit, Is.TypeOf<int>(), "You sure it is int?");
            Assert.AreEqual(number, 14, "Example Has wrong value did you changed it?");
            Assert.That(singleDigit, Is.TypeOf<int>(), "You sure it is int?");
            Assert.AreEqual(lessThanZero, -100, "Example Has wrong value did you changed it?");
            Assert.That(singleDigit, Is.TypeOf<int>(), "You sure it is int?");
        }

        //        /// <summary>
        //        /// Basic operations at integers are
        //        /// add(+), subtract(-), multiply(*), divide(/)
        //        /// make integer variables: subtract, multiply and divide perform operations.
        //        /// discuss why divide is not working
        //        /// </summary>
        [Test]

        // Documentation for the following function ->>>>
        public void OperationOnIntegers()
        {
            int x = 4;
            int y = 5;

            int add;
            int subtract;
            double divide;
            int multiply;

            /*
             * There are few other ways you can do this
             * int add = 0;
             * add = x+y;
             */
            add = x + y;
            subtract = x - y;
            multiply = x * y;
            divide = 5.0 / 4.0;

            Assert.AreEqual(9, add, "Example Has wrong value did you changed it?");
            Assert.AreEqual(-1, subtract, "Wrong value maybe other way around?");
            Assert.That(subtract, Is.TypeOf<int>(), "You sure it is int?");
            Assert.AreEqual(20, multiply, "Example Has wrong value did you changed it?");
            Assert.That(multiply, Is.TypeOf<int>(), "You sure it is int?");
            Assert.AreEqual(1.25, divide, "Example Has wrong value did you changed it?");
            Assert.That(divide, Is.TypeOf<double>(), "You sure it is int?");
        }

        //        /// <summary>
        //        /// There are more way of changing value if you want to only increase x you can
        //        /// x = x+5;
        //        /// or
        //        /// x+=5;
        //        /// both means the same
        //        /// but if you want increment only by one you can do
        //        /// x++;
        //        /// Take moment to play with it.
        //        /// you can do same with other math operations.
        //        /// </summary>
        //        [Test]
        //        public void Int_Increments()
        //        {
        //            int example = 5;
        //            example += 10;
        //            //example is 15
        //            example++;
        //            //example is 16 know;
        //            Assert.AreEqual(example, 16);
        //        }

        // <summary>
        // bool is the most straightforward and most useful it can only accept true and false.
        // We will talk more about it later, for now, create two bools:
        // truth and notTruth.
        // Assign to them true and false.
        // Try to assign number 6 to them.
        // </summary>
        [Test]

        // Doc
        public void Bool()
        {
            bool truth = true;
            bool notTruth = false;

            Assert.True(truth);
            Assert.False(notTruth);
        }

        /// <summary>
        ///  saldfkjasldfkj ...
        /// </summary>
        [Test]

        // Documentation for function Doublee
        public void Doublee()
        {
            double a1 = 23.321;
            double a2 = 45.23;

            Assert.GreaterOrEqual(a2, a1);
            Assert.LessOrEqual(a2, 1111);
        }

        // <summary>
        // There are many ways to store real numbers
        // Float, Double and Decimal.
        // Decimal is most accurate but most expensive that why is is usual used for financial data.
        // Float, Double are faster but not always accurate. Ask your teacher for more details.
        // repeat operations add, subtract, divide, and multiply for double
        // </summary>
        [Test]

        // Documentation: Some kind of documentation in here
        public void FloatDoubleDecimal()
        {
            decimal exampleDecimal = new decimal(10.5);

            double x;
            x = 140000000000000000000000000.001;
            double y;
            y = 0.0000000000000000000000000008;

            x = x + y;
            Assert.That(true);

            StringAssert.Contains("hallo","flsdkjfl hallo");

            Console.WriteLine(string.Format("Święta {0} Narodzenia {1}", "Bożego", "już wkrótce"));

        }

        //        /// <summary>
        //        /// Extra exercise
        //        /// create a variable of each data type, and DON'T assign any value!;
        //        /// Display them - you can do it Console.WriteLine(yourVariable);
        //        /// Try to explain what happened.
        //        /// </summary>
        //        public void Default_Values()
        //        {
        //        }

        //Additonal read:
        // There are more types we didn't cover but it is worth knowing about
    }
}
