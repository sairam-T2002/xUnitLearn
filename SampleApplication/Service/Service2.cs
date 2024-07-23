using SampleApplication.Interface;

namespace SampleApplication.Service
{
    public class Service2:ITest
    {
        public string Conclude( string name )=> "Bye " + name;
    }
}
