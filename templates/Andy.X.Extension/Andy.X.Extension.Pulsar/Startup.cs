using Cortex.Core.Abstractions.Extensions;

namespace Andy.X.Extension.Pulsar
{
    public class Startup : IExtensionStartup
    {
        public Startup()
        {

        }

        public bool Handle(object content)
        {
            Shared.RequestRunner.Run(Shared.Providers.Provider.Pulsar, content);

            return true;
        }
    }
}
