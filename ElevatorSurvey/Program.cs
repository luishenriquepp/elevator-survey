using System;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;  

namespace ElevatorSurvey
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
            .AddSingleton<IInputPatternReader, InputPatternReader>()
            .AddSingleton<IInputPatternParser, InputPatternParser>()
            .AddSingleton<ISurveyBuilder, SurveyBuilder>()
            .AddSingleton<ISurveyProcessor, SurveyProcessor>()
            .BuildServiceProvider();

            var processor = serviceProvider.GetService<ISurveyProcessor>();
            
            var samples = Seed.Samples();
                  
            samples.ForEach(sample => {
                processor.Process(sample);
            });
                        
            var report = new Report();
            var leastElevator = report.LeastFavoriteFloor(SurveyRepository.Surveys);
            Console.WriteLine($"The least favorite floor is: {leastElevator.Key}. Used: {leastElevator.Sum} times.");

            var mostShift = report.ShiftMostUsed(SurveyRepository.Surveys);
            Console.WriteLine($"The most used shift is: {mostShift.Key}. Used: {mostShift.Sum} times.");

            var mostElevatorAndShift = report.MostUsedElevatorAndMostUsedShift(SurveyRepository.Surveys);
            Console.WriteLine($"The most used elevator is {mostElevatorAndShift.Key1} on the shift {mostElevatorAndShift.Key2}");

            var leastElevatorAndShift = report.LeastUsedElevatorAndLeastUsedShift(SurveyRepository.Surveys);
            Console.WriteLine($"The least used elevator is {leastElevatorAndShift.Key1} on the shift {leastElevatorAndShift.Key2}");
        }
    }
}