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
    }

    public class Result
    {
        public string Key { get; set; }
        public int Sum { get; set; }
    }
}

// Qual é o andar menos utilizado pelos usuários
// Qual o período de maior utilização do conjunto de elevadores
// Qual é o elevador mais frequentado e o período que se encontra maior fluxo
// Qual é o elevador menos frequentado e o período que se encontra menor fluxo
// Qual o percentual de uso de cada elevador com relação a todos os serviços prestado