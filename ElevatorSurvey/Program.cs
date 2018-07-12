using System;
using System.Linq;

namespace ElevatorSurvey
{
    class Program
    {
        static void Main(string[] args)
        {
            var samples = Seed.Samples();

            var processor = new SurveyProcessor();        
            
            samples.ForEach(sample => {
                processor.Process(sample);
            });
                        
            var report = new Report();
            var leastElevator = report.LeastFavoriteFloor(SurveyRepository.Surveys);
            Console.WriteLine($"The least favorite floor is: {leastElevator.Key}. Used: {leastElevator.Sum} times.");

            var mostShift = report.ShiftMostUsed(SurveyRepository.Surveys);
            Console.WriteLine($"The most used shift is: {mostShift.Key}. Used: {mostShift.Sum} times.");
        }
    }
}