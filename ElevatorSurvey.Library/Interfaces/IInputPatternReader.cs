using System;
using System.Text.RegularExpressions;

namespace ElevatorSurvey
{
    public interface IInputPatternReader
    {
        RegexPattern Define(string value);
    }
}