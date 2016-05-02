using MegaCastingsDblib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Logique d'interaction pour FenetreTypeContrat.xaml
    /// </summary>
    public partial class FenetreTypeContrat : Window
    {
        // On crée les accesseurs pour le types de contrat
        public TypesDeContrat typesDeContrat { get; set; }
        public FenetreTypeContrat(TypesDeContrat context)
        {
            typesDeContrat = context;

            InitializeComponent();
            this.DataContext = this;
        }

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
