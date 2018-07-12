using NUnit.Framework;
using ElevatorSurvey;

namespace ElevatorSurvey.Tests
{
    [TestFixture]
    public class SurveyBuilderTest
    {
        [Test]
        public void Should_ReturnSurvey_When_BuildFromADto()
        {
            var dto = new SurveyDto
            {
                Elevator = "A",
                Shift = "V",
                Floor = "11"
            };

            var builder = new SurveyBuilder();
            var survey = builder.Build(dto);

            Assert.IsTrue(survey.Floor == 11);
            Assert.IsTrue(survey.Shift == Shift.V);
            Assert.IsTrue(survey.Elevator == Elevator.A);
        }
    }
}