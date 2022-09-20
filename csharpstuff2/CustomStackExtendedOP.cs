using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static csharpstuff2.Interns;

namespace csharpstuff2
{
    internal class CustomStackExtendedOP
    {
        public static void DisplayAllInternsNameAndId(CustomStack<Jedi> obj)
        {
            while (obj.count() > 0)
            {
                var item = obj.Pop();
                Console.WriteLine(item.NameId);
            }
        }
    }
}
