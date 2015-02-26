using System;
using NFluent;
using NUnit.Framework;

namespace CSharpDiscovery
{
    [TestFixture]
    public class TypesTests
    {
        [Test]
        public void NFluentAndNUnitAreWorking()
        {
            Check.That(true).IsTrue();
        }

        [Test]
        public void AnIntIsNotEqualToSameIntStringRepresentation()
        {
            String integerAsAString = "1";
            int integer = 1;
            Check.That(integerAsAString).Not.Equals(integer);
        }

        [Test]
        public void AnIntIsNotEqualToSameIntAsFloat()
        {
            float  integerAsAFloat = 1.5F;
            int integer = 1;
            
            Check.That(integerAsAFloat).Not.Equals(integer);
        }

        [Test]
        public void AnIntIsNotEqualToSameIntAsDouble()
        {
            double integerAsADouble = 1.5;
            int integer = 1;
            Check.That(integerAsADouble).Not.Equals(integer);
        }

        [Test]
        public void anintisnotequaltosameintasdecimal()
        {
            decimal integerasadecimal = 1.5m;
            int integer = 1;
            Check.That(integerasadecimal).Not.Equals(integer);
        }

        [Test]
        public void AnIntIsNotEqualToSameIntAsLong()
        {
            long integerAsInt32 = 1;
            int integer = 1;
            Check.That(integerAsInt32).Not.Equals(integer);
        }

        [Test]
        public void AnIntIsEqualToSameIntAsInt32()
        {
            Int32 integerAsInt32 = 1;
            int integer = 1;
        
            Check.That(integerAsInt32).Equals(integer);
        }

        [Test]
        public void AFloatCanBeCastedToInteger()
        {
            float single = 1.0F;
            int expectedInteger = 1;
            int singleCastedToInteger = (int)single;
            Check.That(singleCastedToInteger).Equals(expectedInteger);
        }

        [Test]
        public void AFloatCanBeCastedToInteger2()
        {
            int integer = 1;
            float expectedSingle = 1.0F;
            float singleImplicitlyCastToInteger = integer;
            Check.That(singleImplicitlyCastToInteger).Equals(expectedSingle);
        }

        [Test]
        public void AStringCanBeParsedToInteger()
        {
            string integerString = "30";
            int expectedInteger = 30;
            int integerParsed = int.Parse(integerString);
          
            Check.That(integerParsed).Equals(expectedInteger);
        }

       [Test]
        public void AFloatStringRepresentationCannotBeParsedToInteger()
        {     
            // Create a method named ParseFloatStringAsInteger that takes no argument, return void and parse a float string representation "30.0"
            Check.That(ParseFloatStringAsInteger).Throws<FormatException>();
        }
        public void ParseFloatStringAsInteger()
        {
            String stringFloat = "30.0";
            int.Parse(stringFloat);
        }

        [Test]
        public void TryToParseAStringToInteger()
        {
            string floatString = "30.0";
            int expectedInteger = 0;

            int integerParsed;
            bool tryParseFailed = int.TryParse(floatString,out integerParsed);
            
            // Use int.TryParse, /!\ it uses an "out" argument

            Check.That(integerParsed).Equals(default(int));
            Check.That(tryParseFailed).IsFalse();
        }

        [Test]
        public void UseVarForLessVerbosityButKeepStrongTyping()
        {
            var integerAsAString = "1";
            var integer = 1;
            Check.That(integerAsAString).Not.Equals(integer);
        }

        [Test]
        public void NullableIntWithNullValueDoesNotHaveValue()
        {
            int? nullableInteger = null;
            // use "int?" to declare a nullable int initialized with null, then try also with Nullable<int>

            Check.That(nullableInteger.HasValue).IsFalse();
        }

        [Test]
        public void GettingValueOfANullableIntwithNullValueThrowsAnInvalidOperationException()
        {
            // Create a method named GetNullableIntValue that takes no argument, return void and access a nullable int value (nullableInteger.Value)
            Check.That(GetNullableIntValue).Throws<InvalidOperationException>();
        }
        public void GetNullableIntValue()
        {
            int? nullableInteger = null;
            var e = nullableInteger.Value;
        }

        //[Test]
        //public void NullableIntWithNullValueDoesNotHaveValue()
        //{
        //    // use "int?" to declare a nullable int initialized with 30
            
        //    Check.That(nullableInteger.Value).Equals(30);
        //}
    }
}
