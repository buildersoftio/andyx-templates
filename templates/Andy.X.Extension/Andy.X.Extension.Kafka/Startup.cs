namespace Andy.X.Extension.Kafka
{
    public class Startup
    {

        public Startup()
        {

        }

        public void Handle(object content)
        {
            Shared.RequestRunner.Run(Shared.Providers.Provider.Kafka, content);
        }
    }
}
