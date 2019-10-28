using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BerlinClock.Classes.TimeConverters;
using BerlinClock;

namespace TimeConversionUnitTests
{
    [TestClass]
    public class MinutesConversionUnitTests
    {
        [TestMethod]
        public void WhenAMPMMinutesIs00ThenBerlinExpectedMinutesIsOOOOOOOOOOOrnOOOO()
        {
            var AMPMMinutes = "00";
            var expected = "OOOOOOOOOOO\r\nOOOO";
            var minutesConverter = Setup();
            var result = minutesConverter.convertTime(AMPMMinutes);
            Assert.AreEqual(expected, result);
             
        }

        private static MinutesConverter Setup()
        {
            var merger = new BerlinTimeComponentMerger();
            var minutesConverter = new MinutesConverter(merger);
            return minutesConverter;
        }

        [TestMethod]
        public void WhenAMPMMinutesIs17ThenBerlinExpectedMinutesIsYYROOOOOOOOrnYYOO()
        {
            var AMPMMinutes = "17";
            var expected = "YYROOOOOOOO\r\nYYOO";
            var minutesConverter = Setup();
            var result = minutesConverter.convertTime(AMPMMinutes);
            Assert.AreEqual(expected, result);

        }
        [TestMethod]
        public void WhenAMPMMinutesIs59ThenBerlinExpectedMinutesIsYYRYYRYYRYYrnYYYY()
        {
            var AMPMMinutes = "59";
            var expected = "YYRYYRYYRYY\r\nYYYY";
            var minutesConverter = Setup();
            var result = minutesConverter.convertTime(AMPMMinutes);
            Assert.AreEqual(expected, result);

        }
        
    }
}
