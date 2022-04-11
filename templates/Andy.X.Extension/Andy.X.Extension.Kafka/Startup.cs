using Cortex.Core.Abstractions.Extensions;

namespace Andy.X.Extension.Kafka
{
    public class Startup : IExtensionStartup
    {
        public Startup()
        {

        }

        public bool Handle(object content)
        {
            Shared.RequestRunner.Run(Shared.Providers.Provider.Kafka, content);

            return true;
        }
    }
}
