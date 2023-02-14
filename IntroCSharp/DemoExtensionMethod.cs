using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroCSharp
{
    public static class DemoExtensionMethod
    {
        public static void Times(this int times, Action<string> doSomething)
        {
            for (int i = 0; i < times; i++)
            {
                doSomething("hello");
            }
        }
    }
}
