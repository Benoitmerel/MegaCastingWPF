﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCastingsDblib
{
    public partial class DomaineDeMetier
    {

        public DomaineDeMetier copy()
        {
            return (DomaineDeMetier)this.MemberwiseClone();
        }
    }
}
