namespace Events.Tests
{
    using Mocks;
    using NUnit.Framework;

    [TestFixture]
    public class LoggerTests
    {
        [Test]
        public void LoggerIsLoggingEventsCorrectly()
        {
            var logger = new Logger();
            var eventHolder = new EventHolder(logger);
            var commandEngine = new MyCommandEngine(eventHolder);

            commandEngine.AddTestEvent("AddEvent|2008-09-15T 09:30:41|AAAA");
            Assert.AreEqual("Event added\n", logger.ToString());
        }
    }
}
