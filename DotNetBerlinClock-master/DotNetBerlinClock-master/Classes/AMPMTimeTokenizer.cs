

namespace BerlinClock.Classes
{
    public class AMPMTimeTokenizer
    {
        private const char SEPARATOR = ':';

        public string[] Split(string aTime)
        {
            return aTime.Split(SEPARATOR);
        }
    }
}