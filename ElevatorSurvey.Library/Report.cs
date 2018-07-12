using System;
using System.Linq;
using System.Collections.Generic;

namespace ElevatorSurvey
{
    public class Report
    {
        public Result LeastFavoriteFloor(List<Survey> surveys)
        {
            return surveys
                .GroupBy(s => s.Floor)
                .Select(group => new Result
                {
                    Key = group.Key.ToString(),
                    Sum = group.Count()
                })
                .OrderBy(o => o.Sum)
                .First();
        }

        public Result ShiftMostUsed(List<Survey> surveys)
        {
            return surveys
                .GroupBy(s => s.Shift)
                .Select(group => new Result
                {
                    Key = group.Key.ToString(),
                    Sum = group.Count()
                })
                .OrderByDescending(o => o.Sum)
                .First();
        }

        public Result2 MostUsedElevatorAndMostUsedShift(List<Survey> surveys)
        {
            return surveys
                .GroupBy(s => new { s.Elevator, s.Shift})
                .Select(group => new Result2
                {
                    Key1 = group.Key.Elevator.ToString(),
                    Key2 = group.Key.Shift.ToString(),
                    Sum = group.Count()
                })
                .OrderByDescending(o => o.Sum)
                .First();
        }

        public Result2 LeastUsedElevatorAndLeastUsedShift(List<Survey> surveys)
        {
            return surveys
                .GroupBy(s => new { s.Elevator, s.Shift})
                .Select(group => new Result2
                {
                    Key1 = group.Key.Elevator.ToString(),
                    Key2 = group.Key.Shift.ToString(),
                    Sum = group.Count()
                })
                .OrderBy(o => o.Sum)
                .First();
        }

        public IEnumerable<Result> ElevatorsFrequencyUse(List<Survey> surveys)
        {
            return surveys
                .GroupBy(s => s.Elevator)
                .Select(g => new Result
                {
                    Key = g.Key.ToString(),
                    Percentage = (g.Count()/(double)surveys.Count()) * 100
                })
                .OrderBy(o => o.Percentage);
        }
    }

    public class Result
    {
        public string Key { get; set; }
        public int Sum { get; set; }
        public double Percentage { get; set; }
    }

    public class Result2
    {
        public string Key1 { get; set; }
        public string Key2 { get; set; }
        public int Sum { get; set; }
    }
}