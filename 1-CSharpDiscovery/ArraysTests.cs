using System;
using NFluent;
using NUnit.Framework;

namespace CSharpDiscovery
{
    [TestFixture]
    public class ArraysTests
    {
        [Test]
        public void DeclareAOneDimensionArrayNotInitialized()
        {
            int[] integerArray = null;
            // use int[] as type to declare an integer array initialized to null
            Check.That(integerArray).IsNull();
        }

        [Test]
        public void DeclareAOneDimensionArrayInitializedWithTwoElements()
        {
            // use new int[] {}, 1 and 2 as values, and var as type

            int[] integerArray = { 1, 2 };
            Check.That(integerArray).HasSize(2);
            Check.That(integerArray).ContainsExactly(1, 2);
        }

        [Test]
        public void AccessAOneDimensionArrayValueAtAGivenExistingIndex()
        {
            // declare an integer array with 2 integers, the second must be 2 (with type inference, i.e no need to specify the type, since provided values type give the type of the array)
            // get the second value of the array in secondValue var
            int[] array = {1,2 };
            var secondValue = array[1];
            Check.That(secondValue).Equals(2);
        }

        [Test]
        public void AccessAOneDimensionArrayValueOutOfRange()
        {
            // Create a method that takes no args, returns void and access the third value of an array with only two values
            Check.That(GetValueOutOfRangeOfAnArray).Throws<IndexOutOfRangeException>();
        }

        public void GetValueOutOfRangeOfAnArray()
        {
            int[] array = { 1, 2 };
            var secondValue = array[3];
            
        }

        [Test]
        public void SetAOneDimensionArrayValue()
        {
            String[] stringArray = { "plip", "plop" };
            stringArray[1] = "plup"
                       // declare a string array, with 2 initial values ("plip", "plop" for example)
            // then set the second value (to "plup")
            Check.That(stringArray).ContainsExactly("plip", "plup");
        }

        [Test]
        public void TwoDimensionsArray()
        {
            double d1 = 4.5;
            //double[][] doubleArray = new double[2][2];

            
            // declare a two dimensions array with double[,], with 4.1 as the first value of the second dimension
            // access the first value of the second dimension
            //Check.That(firstValueOfSecondDimension).Equals(4.1);
        }

        //[Test]
        //public void JaggedArray()
        //{
        //    // declare a jagged array with double[x][], where x is the nb of jagged arrays
        //    // add a jagged array in second position, with 4.1 as first value
        //    // access the first value of the second jagged array
        //    Check.That(firstValueOfTheSecondArray).Equals(4.1);
        //}
    }
}
