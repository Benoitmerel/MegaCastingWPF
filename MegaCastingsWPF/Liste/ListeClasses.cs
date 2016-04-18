using MegaCastingsDblib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCastingsWPF.Class
{
    public static class app
    {
        

        public static MegaCastingEntities3 db = new MegaCastingEntities3();
        public static ObservableCollection<Client> ListeClients { get; set; }
        public static ObservableCollection<TypesDeContrat> TypesDeContrat { get; set; }
        public static ObservableCollection<Metier> ListeMetier { get; set; }
        public static ObservableCollection<DomaineDeMetier> ListeDomaineDeMetier { get; set; }


    }
}
