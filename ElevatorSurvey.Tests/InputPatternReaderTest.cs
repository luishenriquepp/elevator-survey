using NUnit.Framework;
using ElevatorSurvey;

namespace ElevatorSurvey.Tests
{
    [TestFixture]
    public class InputPatternReaderTest
    {
        [Test]
        public void Should_ReturnOneDigit_When_PatternIsOneDigit()
        {
            var reader = new InputPatternReader();
            var pattern = reader.Define("1AB");

            Assert.AreEqual(pattern, RegexPattern.OneDigit);
        }

        [Test]
        public void Should_ReturnTwoDigit_When_PatternHasTwoDigits()
        {
            var reader = new InputPatternReader();
            var pattern = reader.Define("11AB");

            Assert.AreEqual(pattern, RegexPattern.TwoDigits);
        }

        [Test]
        public void Should_ReturnNoPattern_When_InputHasUnknownFormat()
        {
            var reader = new InputPatternReader();
            var pattern = reader.Define("1");

            Assert.AreEqual(pattern, RegexPattern.NoPattern);
        }
    }
}