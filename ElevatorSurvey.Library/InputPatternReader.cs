using System;
using System.Text.RegularExpressions;

namespace ElevatorSurvey
{
    public class InputPatternReader : IInputPatternReader
    {
        private const string patternOne = @"\b\d{1}[A-Z]{2}\b";
        private const string patternTwo = @"\b\d{2}[A-Z]{2}\b";

        public RegexPattern Define(string value)
        {
            Regex rgx = new Regex(patternOne, RegexOptions.IgnoreCase);
            var matches = rgx.Matches(value);
            
            if (matches.Count > 0)
            {
                return RegexPattern.OneDigit;
            }

            rgx = new Regex(patternTwo, RegexOptions.IgnoreCase);
            matches = rgx.Matches(value);
            if (matches.Count > 0)
            {
                return RegexPattern.TwoDigits;
            }

            return RegexPattern.NoPattern;
        }
    }
}