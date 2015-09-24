using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Low_Level_Use_of_IEnumerable_IEnumerator
{
    using System;

    class Program
    {
        static void Main()
        {
            string s = "Hello";

            // Because string implements IEnumerable, we can call GetEnumerator():

            IEnumerator rator = s.GetEnumerator();
            while (rator.MoveNext())
            {
                char c = (char)rator.Current;
                Console.Write(c + ".");
            }

            Console.WriteLine();
        }

    }
}
