using System.Diagnostics;

namespace CertificationStudies.BuildSegment
{
    public class DebugAssertExample
    {
        public void Run()
        {
            int i = 3;

            Debug.Assert(i > 4);
        }
    }
}
