using System;

namespace ElevatorSurvey
{
    public class SurveyBuilder : ISurveyBuilder
    {
        public Survey Build(SurveyDto dto)
        {
            Elevator.TryParse(dto.Elevator, out Elevator elevator);
            Shift.TryParse(dto.Shift, out Shift shift);
            
            var survey = new Survey();
            survey.Elevator = elevator;
            survey.Shift = shift;
            survey.Floor = Int32.Parse(dto.Floor);

            return survey;
        }
    }
}