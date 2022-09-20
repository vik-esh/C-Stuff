using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpstuff2
{
    internal class Interns
    {
        public class Jedi
        {
            private int id;
            private string name;

            public string NameId
            {
                get {return $"Jedi - {name}:{id}"; }
            }
            
            public Jedi(int id, string name)
            {
                this.id = id;
                this.name = name;
            }


        }

    }
}
