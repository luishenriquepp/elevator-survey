using System;

namespace ElevatorSurvey
{
    public class SurveyProcessor
    {
        public void Process(string input)
        {
            var reader = new InputPatternReader();
            var pattern = reader.Define(input);
            
            if (pattern == RegexPattern.NoPattern)
                throw new Exception();
            
            var parser = new InputPatternParser();
            var dto = parser.Parse(input, pattern);

            var builder = new SurveyBuilder();
            var survey = builder.Build(dto);
        }

    }
}