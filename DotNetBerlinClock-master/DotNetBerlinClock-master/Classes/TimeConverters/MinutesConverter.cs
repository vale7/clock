using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Classes.TimeConverters
{
    public class MinutesConverter : ITimeConverter
    {
        private const char MINUTES_LIGHT_ON = 'Y';
        private const char MINUTES_LIGHT_QUARTER_ON = 'R';
        private const char MINUTES_LIGHT_OFF = 'O';
        private BerlinTimeComponentMerger _merger;

        public MinutesConverter(BerlinTimeComponentMerger merger)
        {
            this._merger = merger;
        }

        public string convertTime(string aTime)
        {
            var minutesTimeComponentAsInteger = Convert.ToInt32(aTime);
            var howManyMinutesLightsOnInFirstRow = minutesTimeComponentAsInteger / 5;
            var minutesLightsInFirstRow = GetLightsInFirstRow(howManyMinutesLightsOnInFirstRow);
            var howManyminutesLightsOnInSecondRow = minutesTimeComponentAsInteger % 5;
            var minutesLightsInSecondRow = GetLightsInSecondRow(howManyminutesLightsOnInSecondRow);
            return _merger.Merge(new String[2] { minutesLightsInFirstRow, minutesLightsInSecondRow });
        }

        

        private static string GetLightsInFirstRow(int howManyMinutesLightsOnInFirstRow)
        {
            var lightsOffRow = "OOOOOOOOOOO";
            var allLightsInMinutesRow = lightsOffRow.Select((lightOff, index) => GetLightRepresentationForFirstRow(index, howManyMinutesLightsOnInFirstRow));
            return String.Join("", allLightsInMinutesRow);
        }
        private static char GetLightRepresentationForFirstRow(int index, int howManyLightsOn)
        {
            if (index < howManyLightsOn && !IsQuarterMultipleMinute(index))
                return MINUTES_LIGHT_ON;
            else if (index < howManyLightsOn && IsQuarterMultipleMinute(index))
                return MINUTES_LIGHT_QUARTER_ON;
            else
                return MINUTES_LIGHT_OFF;
        }

        private static string GetLightsInSecondRow(int howManyMinutesLightsOnInSecondRow)
        {
            var lightsOffRow = "OOOO";
            var allLightsInMinutesRow = lightsOffRow.Select((lightOff, index) => GetLightRepresentationForSecondRow(index, howManyMinutesLightsOnInSecondRow));
            return String.Join("", allLightsInMinutesRow);
        }
        private static char GetLightRepresentationForSecondRow(int index, int howManyLightsOn)
        {
            if (index < howManyLightsOn)
                return MINUTES_LIGHT_ON;
            else
                return MINUTES_LIGHT_OFF;
        }


        private static Boolean IsQuarterMultipleMinute(int index)
        {
            return (index + 1) % 3 == 0;

        }

        private string GetLightInSecondsRow(int howManyminutesLightsOnInSecondRow)
        {
            return String.Empty;
        }
    }
}
