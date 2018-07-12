using System;
using System.Text.RegularExpressions;

namespace ElevatorSurvey
{
    public interface IInputPatternReader
    {
        /// <summary>
        /// Read a string and return an RegexPattern
        /// </summary>
        /// <param name="value">The value to be readed</param>
        RegexPattern Define(string value);
    }
}