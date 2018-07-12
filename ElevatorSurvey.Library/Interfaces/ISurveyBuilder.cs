using System;

namespace ElevatorSurvey
{
    public interface ISurveyBuilder
    {
        Survey Build(SurveyDto dto);
    }
}