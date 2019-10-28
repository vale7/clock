using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Classes.Commands
{
    public class SecondsConversionCommand : ITimeConversionCommand
    {
        private ITimeConverter _converter;
        private string _secondsTimeComponent;

        public SecondsConversionCommand(ITimeConverter converter, string secondsTimeComponent)
        {
            this._converter = converter;
            this._secondsTimeComponent = secondsTimeComponent;

        }

        public string  Execute()
        {
            return _converter.convertTime(_secondsTimeComponent);
        }
    }
}
