using System;

namespace ElevatorSurvey
{
    public class InputPatternParser : IInputPatternParser
    {
        public SurveyDto Parse(string value, RegexPattern pattern)
        {
            var dto = new SurveyDto();

            switch(pattern)
            {
                case RegexPattern.OneDigit:
                    dto.Floor = value.Substring(0,1);
                    dto.Elevator = value.Substring(1,1);
                    dto.Shift = value.Substring(2,1);
                break;

                case RegexPattern.TwoDigits:
                    dto.Floor = value.Substring(0,2);
                    dto.Elevator = value.Substring(2,1);
                    dto.Shift = value.Substring(3,1);
                break;
            }

            return dto;
        }
    }
}