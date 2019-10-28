using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Classes.Commands
{
    public class HoursConversionCommand : ITimeConversionCommand
    {
        private ITimeConverter _converter;
        private string _hourTimeComponent;

        public HoursConversionCommand(ITimeConverter converter, string hourTimeComponent)
        {
            this._converter = converter;
            this._hourTimeComponent = hourTimeComponent;

        }

        public string Execute()
        {
            return _converter.convertTime(_hourTimeComponent);
        }
    }
}
