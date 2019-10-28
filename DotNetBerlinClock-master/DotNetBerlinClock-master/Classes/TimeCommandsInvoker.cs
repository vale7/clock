using System.Collections.Generic;
using BerlinClock.Classes.Commands;
using System.Linq;

namespace BerlinClock
{
    public class TimeCommandsInvoker
    {
       
        public string[] Invoke(IList<ITimeConversionCommand> timeConversionCommands)
        {
            return timeConversionCommands.Select(x => x.Execute()).ToArray();
        }
    }
}