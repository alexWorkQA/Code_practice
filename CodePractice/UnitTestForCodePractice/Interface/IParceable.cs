using System.IO;
using UnitTestForCodePractice.Model;

namespace UnitTestForCodePractice.Interface
{
    interface IParceable<T>
    {
        T parceData(string file);
    }
}
