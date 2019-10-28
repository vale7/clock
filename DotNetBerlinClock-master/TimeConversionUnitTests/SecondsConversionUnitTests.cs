using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BerlinClock.Classes.TimeConverters;
using BerlinClock;

namespace TimeConversionUnitTests
{
    [TestClass]
    public class SecondsConversionUnitTests
    {
        [TestMethod]
        public void WhenAMPMSecondsIs00ThenBerlinExpectedSecondsIsY()
        {
            var AMPMSeconds = "00";
            var expected = "Y";
            var secondsConverter = Setup();
            var result = secondsConverter.convertTime(AMPMSeconds);
            Assert.AreEqual(expected, result);
             
        }

        private static SecondsConverter Setup()
        {
            var merger = new BerlinTimeComponentMerger();
            var secondsConverter = new SecondsConverter(merger);
            return secondsConverter;
        }

        [TestMethod]
        public void WhenAMPMSecondsIs01ThenBerlinExpectedSecondsIsO()
        {
            var AMPMSeconds = "01";
            var expected = "O";
            var secondsConverter = Setup();
            var result = secondsConverter.convertTime(AMPMSeconds);
            Assert.AreEqual(expected, result);

        }
        [TestMethod]
        public void WhenAMPMSecondsIs59ThenBerlinExpectedSecondsIsO()
        {
            var AMPMSeconds = "59";
            var expected = "O";
            var secondsConverter = Setup();
            var result = secondsConverter.convertTime(AMPMSeconds);
            Assert.AreEqual(expected, result);

        }
        
    }
}
