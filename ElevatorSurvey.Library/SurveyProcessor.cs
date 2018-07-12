using System;

namespace ElevatorSurvey
{
    public class SurveyProcessor : ISurveyProcessor
    {
        private readonly IInputPatternReader _inputPatternReader;
        private readonly IInputPatternParser _inputPatternParser;
        private readonly ISurveyBuilder _surveyBuilder;

        public SurveyProcessor(
            IInputPatternReader inputPatternReader,
            IInputPatternParser inputPatternParser,
            ISurveyBuilder surveyBuilder)
        {
            _inputPatternReader = inputPatternReader;
            _inputPatternParser = inputPatternParser;
            _surveyBuilder = surveyBuilder;
        }

        public void Process(string input)
        {
            var pattern = _inputPatternReader.Define(input);
            
            if (pattern == RegexPattern.NoPattern)
                throw new Exception();
            
            var dto = _inputPatternParser.Parse(input, pattern);

            var survey = _surveyBuilder.Build(dto);

            SurveyRepository.Surveys.Add(survey);
        }
    }
}