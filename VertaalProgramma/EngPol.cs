using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VertaalProgramma
{
    public class EngPol
    {
        private string engPolEnglish, engPolPolish;

        
        public EngPol() { }
        public string EngPolEnglish
        {
            get { return engPolEnglish; }
            set { engPolEnglish = value; }
        }
        public string EngPolPolish 
        {
            get { return engPolPolish; }
            set { engPolPolish = value; }
        }

    }
}
