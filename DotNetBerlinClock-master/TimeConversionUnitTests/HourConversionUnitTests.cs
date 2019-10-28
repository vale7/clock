using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BerlinClock.Classes.TimeConverters;
using BerlinClock;

namespace TimeConversionUnitTests
{
    [TestClass]
    public class HourConversionUnitTests
    {
        [TestMethod]
        public void WhenAMPMHourIs00ThenBerlinExpectedHourIsOOOOrnOOOO()
        {
            var AMPMHour = "00";
            var expected = "OOOO\r\nOOOO";
            var hoursConverter = Setup();
            var result = hoursConverter.convertTime(AMPMHour);
            Assert.AreEqual(expected, result);

        }

        private static HoursConverter Setup()
        {
            var merger = new BerlinTimeComponentMerger();
            var hoursConverter = new HoursConverter(merger);
            return hoursConverter;
        }


        [TestMethod]
        public void WhenAMPMHourIs24ThenBerlinExpectedHourIsRRRRrnRRRR()
        {
            var AMPMHour = "24";
            var expected = "RRRR\r\nRRRR";
            var hoursConverter = Setup();
            var result = hoursConverter.convertTime(AMPMHour);
            Assert.AreEqual(expected, result);

        }
        [TestMethod]
        public void WhenAMPMHourIs13ThenBerlinExpectedHourIsRROOrnRRRO()
        {
            var AMPMHour = "13";
            var expected = "RROO\r\nRRRO";
            var hoursConverter = Setup();
            var result = hoursConverter.convertTime(AMPMHour);
            Assert.AreEqual(expected, result);

        }
        [TestMethod]
        public void WhenAMPMHourIs23ThenBerlinExpectedHourIsRRRRrnRRRO()
        {
            var AMPMHour = "23";
            var expected = "RRRR\r\nRRRO";
            var hoursConverter = Setup();
            var result = hoursConverter.convertTime(AMPMHour);
            Assert.AreEqual(expected, result);

        }
    }
}
