using System;
using Microsoft.VisualBasic.CompilerServices;

namespace ReaderXmlFiles
{
    public interface ISeries
    {
        int GetNext();
        void Reset();
        void SetStart(int x);
        int GetPrevious();
    }
}