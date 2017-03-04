using System.Threading.Tasks;
using Orleans;
using System;

namespace Grains
{
    public class DummyGrain : Grain, IDummyGrain
    {
        public async Task DummyMethod()
        {
            Console.WriteLine("Grain invoked!");

            await Task.Delay(100);
        }
    }
}
