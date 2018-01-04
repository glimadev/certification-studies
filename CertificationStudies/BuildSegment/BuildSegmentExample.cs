using System;

namespace CertificationStudies.BuildSegment
{
    public class BuildSegmentExample
    {
        public void Run()
        {
            string image = "test";

#if (DEBUG)
            image = "debug";
#else
        image = "release";
#endif
            Console.WriteLine(image);
        }
    }
}
