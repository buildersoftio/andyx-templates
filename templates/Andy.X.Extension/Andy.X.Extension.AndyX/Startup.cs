using Cortex.Core.Abstractions.Extensions;

namespace Andy.X.Extension.AndyX
{
    public class Startup : IExtensionStartup
    {
        public Startup()
        {

        }

        public bool Handle(object content)
        {
            Shared.RequestRunner.Run(Shared.Providers.Provider.AndyX, content);

            return true;
        }
    }
}
