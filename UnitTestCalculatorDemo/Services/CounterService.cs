namespace UnitTestCalculatorDemo.Services
{
    public class CounterService : ICounterService
    {
        private int _count = 0;

        public CounterService() { }

        public int GetCount()
        {
            return _count;
        }

        public void Increment()
        {
            _count++;
        }
    }
}
