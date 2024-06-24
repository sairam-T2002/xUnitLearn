using SampleApplication.Interface;

namespace SampleApplication.Service
{
    public class Service1:ITest
    {
        public string Greet(string name )
        {
            return "Hello " + name;
        }
    }
}
