namespace DependencyInjection.sevices
{
    public class MyService : IMyService
    {
        public string GetMessage()
        {
            return "Hello from MyService using Dependency Injection";
        }

    }
}
