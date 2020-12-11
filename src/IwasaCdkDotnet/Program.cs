using Amazon.CDK;

namespace IwasaCdkDotnet
{
    sealed class Program
    {
        public static void Main(string[] args)
        {
            var app = new App();
            new IwasaCdkDotnetStack(app, "IwasaCdkDotnetStack");

            app.Synth();
        }
    }
}
