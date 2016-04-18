using MegaCastingsDblib;
using MegaCastingsWPF.Class;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Validation;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MegaCastingsWPF
{
    /// <summary>
    /// Logique d'interaction pour OffresView.xaml
    /// </summary>
    public partial class OffresView : UserControl
    {

        //Creation d'une liste de toutes les clients
        public ObservableCollection<Client> ListeClients { get; set; }

        //Creation d'une liste de tous les Types de contrat
        public ObservableCollection<TypesDeContrat> ListeTypesDeContrat { get; set; }

        //Creation d'une liste de toutes les offre
        public ObservableCollection<Offre> ListeOffres { get; set; }

        //Creation d'une liste de toutes les métier
        public ObservableCollection<Metier> ListeMetier { get; set; }

        public OffresView()
        {
            InitializeComponent();

            ListeClients = app.ListeClients;

            //On récupère la liste de toutes les offres
            ListeOffres = new ObservableCollection<Offre>(app.db.Offres.ToList());

            //On récupère la liste de tous les types de contrat
            app.TypesDeContrat = new ObservableCollection<TypesDeContrat>(app.db.TypesDeContrats.ToList());
            ListeTypesDeContrat = app.TypesDeContrat;

            //On récupère la liste de tous les types de contrat
            app.ListeMetier = new ObservableCollection<Metier>(app.db.Metiers.ToList());
            ListeMetier = app.ListeMetier;

            this.DataContext = this;
        }

        // Méthode qui permet d'ajouter une nouvelle offre
        private void BTN_Ajouter_Click(object sender, RoutedEventArgs e)
        {
            //Ouverture d'une nouvelle fenetre pour ajouter une offre, on lui envoie une nouvelle offre
            FenetreOffre fenetreOffre = new FenetreOffre(new Offre(), app.db);
            if (fenetreOffre.ShowDialog() == true)
            {
                // Si l'utilisateur confirme l'ajout, on essaye de l'ajouter a la base de données et on sauvegarde.
                try
                {
                    app.db.Offres.Add(fenetreOffre.offre);
                    app.db.SaveChanges();
                    this.ListeOffres.Add(fenetreOffre.offre);

                    MessageBox.Show("L'offre a bien été ajouté");
                }
                catch (DbEntityValidationException DbEx)
                {
                    String errors = "";

                    foreach (DbEntityValidationResult dbEntityValidationResult in DbEx.EntityValidationErrors)
                    {
                        foreach (DbValidationError dbValidationError in dbEntityValidationResult.ValidationErrors)
                        {
                            errors += dbValidationError.ErrorMessage + "\n";
                        }
                    }

                    // On affiche les éventuelles erreur et on supprime l'ajout si celui ci contient des erreurs.
                    MessageBox.Show(errors);
                    app.db.Offres.Remove(fenetreOffre.offre);
                }
            }
        }

        //Méthode qui permet la modification d'une offre séléctionnée
        private void BTN_Modifier_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                app.db.SaveChanges();
                MessageBox.Show("Les informations sur l'offre ont bien été modifiées");
            }
            catch (DbEntityValidationException DbEx)
            {
                String errors = "";

                foreach (DbEntityValidationResult dbEntityValidationResult in DbEx.EntityValidationErrors)
                {
                    foreach (DbValidationError dbValidationError in dbEntityValidationResult.ValidationErrors)
                    {
                        errors += dbValidationError.ErrorMessage + "\n";
                    }
                }
                // On affiche les éventuelles erreurs récupérés lors de la modification.
                MessageBox.Show(errors);
            }
        }

        // Méthode pour suprimer une offre.
        private void BTN_Supprimer_Click(object sender, RoutedEventArgs e)
        {
            // On lui demande si il est sur de vouleur supprimer les offres
            MessageBoxResult result = MessageBox.Show("Voulez vous vraiment supprimer cette offre ?",
    "Suppression", MessageBoxButton.YesNo);

            if (result == MessageBoxResult.Yes)
            {
                try
                {
                    // On supprime l'offre séléctionner et on sauvegarde les modifications dans la base de données.
                    app.db.Offres.Remove((Offre)this.LST_Offres.SelectedItem);

                    app.db.SaveChanges();
                    ListeOffres.Remove((Offre)this.LST_Offres.SelectedItem);
                    MessageBox.Show("L'offre a bien été supprimé");


                }
                catch (DbEntityValidationException DbEx)
                {
                    String errors = "";

                    foreach (DbEntityValidationResult dbEntityValidationResult in DbEx.EntityValidationErrors)
                    {
                        foreach (DbValidationError dbValidationError in dbEntityValidationResult.ValidationErrors)
                        {
                            errors += dbValidationError.ErrorMessage + "\n";
                        }
                    }

                    //On affiche les éventuelles erreurs survenues lors de la supression
                    MessageBox.Show(errors);
                }
            }
        }
    }
}
