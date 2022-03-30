namespace Andy.X.Extension.Pulsar
{
    public class Startup
    {

        public Startup()
        {

        }

        public void Handle(object content)
        {
            Shared.RequestRunner.Run(Shared.Providers.Provider.Pulsar, content);
        }
    }
}
