using System.Runtime.InteropServices.ComTypes;

namespace ReaderXmlFiles
{
    class ByTwos : ISeries
    {
        int start;
        int val;
        int prev;
        public ByTwos()
        {
            start = 0;
            val = 0;
        }

        public int GetNext()
        {
            val += 2;
            return val;
        }

        public void Reset()
        {
            val = start;
        }

        public void SetStart(int x)
        {
            start = x;
            val = start;
        }

        public int GetPrevious()
        {
            return prev;
        }

    }
}