using System.Threading.Tasks;
using Orleans;

namespace Grains
{

	public interface IDummyGrain : IGrainWithGuidKey
    {
        Task DummyMethod();
    }
}
