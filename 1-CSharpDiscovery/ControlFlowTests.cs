using NFluent;
using NUnit.Framework;

namespace CSharpDiscovery
{
    [TestFixture]
    public class ControlFlowTests
    {
        [Test]
        public void UseForToConcatenateStringArrayValues()
        {
            var stringArray = new[] { "plip", "plop", "plup" };
            string stringConcatenated = "";
            // concatenate string array values in a single string with the simplest solution using a for, then refactor (but keep for loop) using StringBuilder (+ avoid "", use string.Empty instead) for memory usage reason
            for (int i = 0; i < stringArray.Length; i++)
            {
                stringConcatenated += stringArray[i];
            }
                Check.That(stringConcatenated).Equals("plipplopplup");
        }

        [Test]
        public void UseForeachToConcatenateStringArrayValues()
        {
            var stringArray = new[] { "plip", "plop", "plup" };
            string stringConcatenated = "";
            // concatenate string array values in a single string with the simplest solution using a foreach
            foreach (var content in stringArray)
            {
                stringConcatenated += content;

            }
            Check.That(stringConcatenated).Equals("plipplopplup");
        }

        [Test]
        public void UseWhileToConcatenateStringArrayValues()
        {

            var stringArray = new[] { "plip", "plop", "plup" };
            string stringConcatenated = "";
            int i = 0;
            while (i < 3)
            {
                stringConcatenated += stringArray[i];
                i++;
            }
            // concatenate string array values in a single string with the simplest solution using a while

            Check.That(stringConcatenated).Equals("plipplopplup");
        }

        //[Test]
        //public void UseDoWhileToConcatenateStringArrayValues()
        //{
        //    var stringArray = new[] { "plip", "plop", "plup" };
        //    // concatenate string array values in a single string with the simplest solution using a foreach

        //    Check.That(stringConcatenated).Equals("plipplopplup");
        //}

        [Test]
        public void UseIfElseElseIfDuringConcatenationOfStringArrayValues()
        {
            var stringArray = new[] { "plip", "plop", "plup", "foo" };
            string stringConcatenated = "";
            foreach( var value in stringArray) {
                if(value == "plip") {
                    stringConcatenated += "good, ";
                }else if(value == "plop") {
                    stringConcatenated += "not so good, ";
                }
                else if (value == "plup")
                {
                    stringConcatenated += "not so good, ";
                }
                else
                {
                    stringConcatenated += "bad, ";
                }
            }
            // concatenate a string, with "good, " when item is plip, "not so good, " when item starts with "pl", "bad, " in any other case
            Check.That(stringConcatenated).Equals("good, not so good, not so good, bad, ");
        }

        //[Test]
        //public void UseSwitchCaseDuringConcatenationOfStringArrayValues()
        //{
        //    var stringArray = new[] { "plip", "plop", "plup", "foo" };
        //    // concatenate a string, with "good, " when item is plip, "not so good, " when item is "plop", "plip", "bad, " in any other case
        //    Check.That(stringConcatenated).Equals("good, not so good, not so good, bad, ");
        //}
    }
}
