using SampleApplication.Interface;

namespace SampleApplication.Service
{
    public class Service2:ITest
    {
        public string Conclude( string name )
        {
            return "Bye " + name;
        }
    }
}
