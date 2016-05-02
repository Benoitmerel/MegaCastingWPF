using MegaCastingsDblib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MegaCastingsWPF
{
    /// <summary>
    /// Logique d'interaction pour FenetreDomaineMetier.xaml
    /// </summary>
    public partial class FenetreDomaineMetier : Window
    {
      // Creation d'un accesseur pour le domaine de métier.
        public DomaineDeMetier domaineDeMetier { get; set; }

        public FenetreDomaineMetier(DomaineDeMetier DomaineMetierContext)
        {
            InitializeComponent();

            // On récupère les information sur le domaine de métier si c'est une modification, ou des information vierge si c'est un ajout.
            this.domaineDeMetier = DomaineMetierContext;
            this.DataContext = this;
        }

        // Méthode pour confirmer la modification/ajout
        private void BTN_Sauvegarder_Click(object sender, RoutedEventArgs e)
        {

            // on envoie true en fermant la fenêtre pour confirmer la validation.
            DialogResult = true;
        }

        private void BTN_Annuler_Click(object sender, RoutedEventArgs e)
        {
            // On envoie false en fermant la fenetre pour que les changement/ajout ne soit pas pris en compte.
            DialogResult = false;
        }
    }
}
