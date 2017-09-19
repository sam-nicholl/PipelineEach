using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPlay
{
    public static class PipeLineEachExtension
    {
        public static IEnumerable<T> PipelineEach<T>(this IEnumerable<T> list, params Func<T, T>[] actions)
        {
            Func<T, T> applyingAction = actions[0];
            IEnumerable<T> modifiedList = list.Select(applyingAction);
            Func<T, T>[] remainingActions = actions.Skip(1).ToArray();
            if (remainingActions.Any())
            {
               return  modifiedList.PipelineEach(remainingActions);
            }
            return modifiedList;
        }
    }
}
