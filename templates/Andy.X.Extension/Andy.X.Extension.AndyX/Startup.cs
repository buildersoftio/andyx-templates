namespace Andy.X.Extension.AndyX
{
    public class Startup
    {
        public Startup()
        {

        }

        public void Handle(object content)
        {
            Shared.RequestRunner.Run(Shared.Providers.Provider.AndyX, content);
        }
    }
}
