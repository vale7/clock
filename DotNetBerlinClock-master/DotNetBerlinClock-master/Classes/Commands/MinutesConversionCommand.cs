using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Classes.Commands
{
    public class MinutesConversionCommand : ITimeConversionCommand
    {
        private ITimeConverter _converter;
        private string _minutesTimeComponent;

        public MinutesConversionCommand(ITimeConverter converter, string minutesTimeComponent)
        {
            this._converter = converter;
            this._minutesTimeComponent = minutesTimeComponent;

        }

        public string Execute()
        {
            return _converter.convertTime(_minutesTimeComponent);
        }
    }
}
