using System;

namespace ElevatorSurvey
{
    public interface IInputPatternParser
    {
        SurveyDto Parse(string value, RegexPattern pattern);
    }
}