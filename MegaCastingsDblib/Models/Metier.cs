using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCastingsDblib
{
    public partial class Metier
    {
        public Metier copy()
        {

            return (Metier)this.MemberwiseClone();
        }
          
    }
}
