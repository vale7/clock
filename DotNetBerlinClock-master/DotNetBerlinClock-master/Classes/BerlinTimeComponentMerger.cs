using System;

namespace BerlinClock
{
    public class BerlinTimeComponentMerger
    {
        
            public string Merge(string[] timeComponents)
            {
                return String.Join("\r\n", timeComponents);
            }
        
    }
}