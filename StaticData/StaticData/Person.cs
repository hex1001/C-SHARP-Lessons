using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StaticData
{
    class Person
    {
        private static int count = 0;
        public static int GetCount() {  return count; }
        public Person() { count++; }
    }
}
