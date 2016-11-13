namespace Events.Tests.Mocks
{
    using Events.Contracts;

    public class MyCommandEngine : CommandEngine
    {
        public MyCommandEngine(IEventHolder eventHolder)
            : base(eventHolder)
        {
        }

        public void AddTestEvent(string command)
        {
            this.AddEvent(command);
        }
    }
}
