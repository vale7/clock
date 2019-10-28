using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Classes.TimeConverters
{
    public class SecondsConverter : ITimeConverter
    {
        private const char SECONDS_LIGHT_ON = 'Y';
        private const char SECONDS_LIGHT_OFF = 'O';
        private BerlinTimeComponentMerger _merger;

        public SecondsConverter(BerlinTimeComponentMerger merger)
        {
            this._merger = merger;
        }

        public string convertTime(string aTime)
        {
            var secondsTimeComponentAsInteger = Convert.ToInt32(aTime);
            return IsEven(secondsTimeComponentAsInteger) ? SECONDS_LIGHT_ON.ToString() : SECONDS_LIGHT_OFF.ToString();

        }
        private static Boolean IsEven(int secondsTimeComponentAsInteger)
        {
            return secondsTimeComponentAsInteger % 2 == 0;

        }

    }
}
