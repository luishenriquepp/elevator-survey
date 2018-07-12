using System;

namespace ElevatorSurvey
{
    public interface IInputPatternParser
    {
        /// <summary>
        /// Parse a string into a SurveyDto using the RegexPattern
        /// </summary>
        /// <param name="value">The value to be parsed</param>
        /// <param name="pattern">The Pattern to be considered</param>
        SurveyDto Parse(string value, RegexPattern pattern);
    }
}