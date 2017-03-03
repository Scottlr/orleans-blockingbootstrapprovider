using System.Threading.Tasks;
using Orleans;

namespace Grains
{
    public class DummyGrain : Grain, IDummyGrain
    {
        public async Task DummyMethod()
        {
            await Task.Delay(100);
        }
    }
}
