using NUnit.Framework;
using ElevatorSurvey;

namespace ElevatorSurvey.Tests
{
    [TestFixture]
    public class InputPatternParserTest
    {
        [Test]
        public void Should_ReturnDtoValues_When_ParsingWithOneDigit()
        {
            var parser = new InputPatternParser();
            var dto = parser.Parse("1AB", RegexPattern.OneDigit);

            Assert.AreEqual(dto.Floor, "1");
            Assert.AreEqual(dto.Elevator, "A");
            Assert.AreEqual(dto.Shift, "B");
        }        
        
        [Test]
        public void Should_ReturnDtoValues_When_ParsingWithTwoDigits()
        {
            var parser = new InputPatternParser();
            var dto = parser.Parse("11AB", RegexPattern.TwoDigits);

            Assert.AreEqual(dto.Floor, "11");
            Assert.AreEqual(dto.Elevator, "A");
            Assert.AreEqual(dto.Shift, "B");
        }
    }
}