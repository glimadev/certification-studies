using System.Diagnostics;

namespace CertificationStudies
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
