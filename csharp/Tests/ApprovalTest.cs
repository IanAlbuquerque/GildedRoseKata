using System;
using System.IO;
using System.Text;
using NUnit.Framework;

namespace csharp.Tests
{
    [TestFixture]
    public class ApprovalTest
    {
        [Test]
        public void ThirtyDays()
        {
            StringBuilder actualOutput = new StringBuilder();
            Console.SetOut(new StringWriter(actualOutput));
            string expectedOutput = File.ReadAllText("C:/Users/IanAlbuquerque/Desktop/GildedRose/texttests/goldenOutput.txt"); 

            Program.Main(new string[] { });
            string output = actualOutput.ToString();

            Assert.AreEqual(expectedOutput, output);
        }
    }
}
