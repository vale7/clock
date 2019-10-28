using BerlinClock.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace BerlinClock
{
    public class TimeConverter : ITimeConverter
    {
        public string convertTime(string aTime)
        {
            var merger = new BerlinTimeComponentMerger();
            var timeCommandsCreator = new TimeCommandsCreator(merger);
            var timeConversionCommands = timeCommandsCreator.CreateCommands(aTime);
            var timeCommandsInvoker = new TimeCommandsInvoker();
            var berlinTimeComponents = timeCommandsInvoker.Invoke(timeConversionCommands);
            return merger.Merge(berlinTimeComponents);
        }
    }
}
