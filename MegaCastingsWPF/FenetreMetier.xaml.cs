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
    /// Logique d'interaction pour FenetreMetier.xaml
    /// </summary>
    public partial class FenetreMetier : Window
    {
        // On crée les accesseurs pour le métier
        public Metier metier { get; set; }
     
        // on crée les accesseurs pour la liste des domaines de métiers
        public ObservableCollection<DomaineDeMetier> ListeDomaineMetier { get; set; }
        public FenetreMetier(Metier MetierContext, MegaCastingEntities3 db)
        {
            InitializeComponent();

            //On récupere le métier séléctionner, ou un nouveau métier si c'est un ajout.
            metier = MetierContext;
          
            // On récupère la liste de tous les domaines de métiers.
            ListeDomaineMetier = new ObservableCollection<DomaineDeMetier>(db.DomaineDeMetiers.ToList());
            this.DataContext = this;
        }

        // Méthode pour sauvegarder l'ajout ou la modification
        private void BTN_Sauvegarder_Click(object sender, RoutedEventArgs e)
        {

            // on envoie true en fermant la fenêtre pour confirmer la validation.
            DialogResult = true;
        }
        //Méthode pour annuler l'ajout ou la modification
        private void BTN_Annuler_Click(object sender, RoutedEventArgs e)
        {
            // On envoie false en fermant la fenetre pour que les changement/ajout ne soit pas pris en compte.
            DialogResult = false;
        }
    }
}
