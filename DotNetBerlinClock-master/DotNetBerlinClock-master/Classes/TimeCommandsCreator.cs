using BerlinClock.Classes;
using BerlinClock.Classes.Commands;
using BerlinClock.Classes.TimeConverters;
using System.Collections.Generic;

namespace BerlinClock
{
    public class TimeCommandsCreator
    {
        private AMPMTimeTokenizer _tokenizer;
        private BerlinTimeComponentMerger _merger;

        public TimeCommandsCreator(BerlinTimeComponentMerger merger)
        {
            _tokenizer = new AMPMTimeTokenizer();
            _merger = merger;
        }

        public IList<ITimeConversionCommand> CreateCommands(string aTime)
        {
            var timeConversionCommands = new List<ITimeConversionCommand>();
            var AMPMTimeComponents =_tokenizer.Split(aTime);
            timeConversionCommands.Add(new SecondsConversionCommand(new SecondsConverter(_merger), AMPMTimeComponents[2]));
            timeConversionCommands.Add(new HoursConversionCommand(new HoursConverter(_merger), AMPMTimeComponents[0]));
            timeConversionCommands.Add(new MinutesConversionCommand(new MinutesConverter(_merger), AMPMTimeComponents[1]));
            
            return timeConversionCommands;
        }
        
    }
}