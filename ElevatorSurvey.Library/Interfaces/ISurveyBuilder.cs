using System;

namespace ElevatorSurvey
{
    public interface ISurveyBuilder
    {
        /// <summary>
        /// Build a Survey using a SurveyDto
        /// </summary>
        /// <param name="dto">The dto to be used</param>
        Survey Build(SurveyDto dto);
    }
}