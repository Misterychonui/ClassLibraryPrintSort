using System;

namespace ClassLibraryPrintSort
{
    public interface IPrintSort
    {
        string[] Print();
        void SortByName();
        void SortByValue();
    }
}
