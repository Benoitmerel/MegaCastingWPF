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
    /// Logique d'interaction pour FenetreOffre.xaml
    /// </summary>
    public partial class FenetreOffre : Window
    {
        // On crée les accesseurs pour l'offre
        public Offre offre { get; set; }

        //Creation d'une liste de tous les clients
        public ObservableCollection<Client> ListeClients { get; set; }

        //Creation d'une liste de tous les métier
        public ObservableCollection<Metier> ListeMetier { get; set; }

        //Creation d'une liste de tous contrats
        public ObservableCollection<TypesDeContrat> ListeTypesDeContrat { get; set; }

        public FenetreOffre(Offre context, MegaCastingEntities3 db)
        {
            InitializeComponent(); 

            //On récupère la liste de toutes les offres
            ListeClients = new ObservableCollection<Client>(db.Clients.ToList());

            //On récupère la liste de tous les types de contrat
            ListeTypesDeContrat = new ObservableCollection<TypesDeContrat>(db.TypesDeContrats.ToList());

            //On récupère la liste de tous les types de contrat
            ListeMetier = new ObservableCollection<Metier>(db.Metiers.ToList());

            offre = context;
          
            offre.DateDebutPublication = DateTime.Now;

            this.DataContext = this;
        }

        // Méthode pour sauvegarder l'ajout ou la modification
        private void BTN_Sauvegarder_Click(object sender, RoutedEventArgs e)
        {
            //On rentre les informations relative a l'offre taper par l'utilisateur
            //offre.Intitule = TXT_Intitule.Text;
            //offre.Localisation = TXT_Localisation.Text;
            //offre.Reference = TXT_Reference.Text;
            //offre.NombreDePostes = TXT_NombreDePostes.Text;
            //offre.DescriptionPoste = TXT_DescritptionPoste.Text;
            //offre.DescriptionProfil = TXT_DescritptionProfil.Text;

            //offre.Metier = CBX_Metier.SelectedItem as Metier;
            //offre.Client = CBX_Client.SelectedItem as Client;
            //offre.TypesDeContrat = CBX_TypesDecontrat.SelectedItem as TypesDeContrat;

            //offre.DateDebutPublication = Convert.ToDateTime(TXT_DateDebutPublication.Text);
            //offre.DureeDeDiffusion = int.Parse(TXT_DureeDiffusion.Text);
            // on envoie true en fermant la fenêtre pour confirmer la validation.
            DialogResult = true;
        }
        //Méthode pour annuler l'ajout
        private void BTN_Annuler_Click(object sender, RoutedEventArgs e)
        {
            // On envoie false en fermant la fenetre pour que les ajouts ne soit pas pris en compte.
            DialogResult = false;
        }
    }
}
