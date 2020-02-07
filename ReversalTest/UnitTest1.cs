using System;
using Xunit;

namespace ReversalTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("Hello, Michael!", "olleH, leahciM!")]
        public void Reversing(string input, string expected)
        {
            //Arrange
            ReverseSentence mySent = new ReverseSentence();
            //Act
            string result = mySent.ReverseSent(input);
            //Assert
            Assert.Equal(expected, result);
        }
    }
}
