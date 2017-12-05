using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestForCodePractice.Interface;

namespace UnitTestForCodePractice.TestHelper
{
    abstract class TestDataParcer<T> : IParceable<T>
    {
        abstract public T parceData(string file);
    }
}
