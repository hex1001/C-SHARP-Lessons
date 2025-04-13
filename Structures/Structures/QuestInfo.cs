using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    struct QuestInfo
    {
        public string title;
        public int award;

        public void print()
        {
            Console.WriteLine($"\n\nНазвание квеста:{title}; Награда: {award}\n\n");
        }
    }
}
