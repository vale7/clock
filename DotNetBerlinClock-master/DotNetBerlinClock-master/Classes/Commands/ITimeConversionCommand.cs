using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Classes.Commands
{
    public interface ITimeConversionCommand
    {
        string Execute();
    }
}
