using NUnit.Framework;
using System;

    public class Tests
    {
        [Test]
        public void HasToBeGivenAstringOfLetters()
        {
            String args1 = "1";
            Assert.Throws<ArgumentException>(() => new FirstNonRepeatingLetter(args1));
            String args2 = "!";
            Assert.Throws<ArgumentException>(() => new FirstNonRepeatingLetter(args2));
            String args3 = "a";
            Assert.DoesNotThrow(() => new FirstNonRepeatingLetter(args3), "Input must be a string of letters");
        }

        [Test]
        public void ReturnsAString()
        {
            String args1 = "a";
            FirstNonRepeatingLetter firstNPR1 = new FirstNonRepeatingLetter(args1);
            Assert.IsInstanceOf<string>(firstNPR1.Result());
        }

        [Test]
        public void ReturnsAnEmptyString()
        {
            String args1 = "aaa";
            FirstNonRepeatingLetter firstNPR1 = new FirstNonRepeatingLetter(args1);
            Assert.AreEqual("", firstNPR1.Result());
        }

        [Test]
        public void ReturnsTheFirstNonRepeatingCharacter()
        {
            String args1 = "aAc";
            FirstNonRepeatingLetter firstNPR1 = new FirstNonRepeatingLetter(args1);
            Assert.AreEqual("c", firstNPR1.Result());

            String args2 = "aAccccde";
            FirstNonRepeatingLetter firstNPR2 = new FirstNonRepeatingLetter(args2);
            Assert.AreEqual("d", firstNPR2.Result());

            String args3 = "aAccccDe";
            FirstNonRepeatingLetter firstNPR3 = new FirstNonRepeatingLetter(args3);
            Assert.AreEqual("D", firstNPR3.Result());
        }
    }
