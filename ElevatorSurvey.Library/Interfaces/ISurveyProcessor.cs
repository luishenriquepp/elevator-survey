using System;

namespace ElevatorSurvey
{
    public interface ISurveyProcessor
    {
        /// <summary>
        /// Process an input and creates a Survey value inside the system
        /// </summary>
        /// <param name="input">The input given by the user to be processed by the system</param>
        void Process(string input);
    }
}