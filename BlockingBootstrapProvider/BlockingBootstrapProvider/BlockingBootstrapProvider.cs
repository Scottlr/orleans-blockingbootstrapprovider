using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orleans;
using Orleans.Providers;

namespace BlockingBootstrapProvider
{
    public class BlockingBootstrapProvider : IBootstrapProvider
    {
        public Task Init(string name, IProviderRuntime providerRuntime, IProviderConfiguration config)
        {
            return TaskDone.Done;
//            while (true)
//            {
//            }
        }

        public Task Close()
        {
            throw new NotImplementedException();
        }

        public string Name { get; }
    }
}
