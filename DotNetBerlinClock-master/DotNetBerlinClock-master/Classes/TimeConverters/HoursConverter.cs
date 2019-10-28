using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Classes.TimeConverters
{
    

    public class HoursConverter : ITimeConverter
    {
        private const char HOUR_LIGHT_ON = 'R';
        private const char HOUR_LIGHT_OFF = 'O';

        private BerlinTimeComponentMerger _merger;

        public HoursConverter(BerlinTimeComponentMerger merger)
        {
            this._merger = merger;
        }

        public string convertTime(string aTime)
        {
            var hourTimeComponentAsInteger = Convert.ToInt32(aTime);
            var howManyHourLightsOnInFirstRow = hourTimeComponentAsInteger / 5;
            var hourLightsFirstRow = GetLightsRow(howManyHourLightsOnInFirstRow);
            var howManyHourLightsOnInSecondRow = hourTimeComponentAsInteger % 5;
            var hourLightsSecondRow = GetLightsRow(howManyHourLightsOnInSecondRow);
            return _merger.Merge(new String[2] { hourLightsFirstRow, hourLightsSecondRow});
        }

        private static string GetLightsRow(int howManyHourLightsOnInFirstRow)
        {
            var lightsOffRow = "OOOO";
            var allLightsInHourRow = lightsOffRow.Select((lightOff, index) => GetLightRepresentation(index, howManyHourLightsOnInFirstRow));
            return String.Join("", allLightsInHourRow);
        }

        private static char GetLightRepresentation(int index, int howManyLightsOn)
        {
            return (index < howManyLightsOn) ? HOUR_LIGHT_ON : HOUR_LIGHT_OFF;
        }
    }
}
