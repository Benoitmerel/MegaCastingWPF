using MegaCastingsDblib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Validation;
using System.Linq;
using System.Security.Cryptography;
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
    /// Logique d'interaction pour PartenaireView.xaml
    /// </summary>
    public partial class PartenaireView : UserControl
    {

        // Connection a la base de données
        public MegaCastingEntities3 db = new MegaCastingEntities3();

        //Creation d'une liste de tous les partenaires
        public ObservableCollection<Partenaire> ListePartenaire { get; set; }

        public Partenaire partenaire { get; set; }


        public PartenaireView()
        {
            InitializeComponent();
            //On met les clients de la base de donnée dans la liste
            ListePartenaire = new ObservableCollection<Partenaire>(db.Partenaires.ToList());

            this.DataContext = this;
        }

        // Méthode qui permet d'ajouter un nouveau partenaire
        private void BTN_Ajouter_Click(object sender, RoutedEventArgs e)
        {
            partenaire = new Partenaire();
            //Ouverture d'une nouvelle fenetre pour ajouter un partenaire, on lui envoie un nouveau partenaire
            FenetrePartenaire fenetrePartenaire = new FenetrePartenaire(partenaire);
            if (fenetrePartenaire.ShowDialog() == true)
            {
                // Si l'utilisateur confirme l'ajout, on essaye de l'ajouter a la base de données et on sauvegarde.
                try
                {
                    db.Partenaires.Add(partenaire);
                    db.SaveChanges();
                    this.ListePartenaire.Add(partenaire);

                    MessageBox.Show("Le partenaire a bien été ajouté");
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
                    db.Partenaires.Remove(fenetrePartenaire.partenaire);
                }
            }
        }

        //Méthode qui permet la modification du partenaire séléctionnée
        private void BTN_Modifier_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                
                db.SaveChanges();
                MessageBox.Show("Les informations sur le partenaire ont bien été modifiées");
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

        // Méthode pour suprimer un partenaire.
        private void BTN_Supprimer_Click(object sender, RoutedEventArgs e)
        {
            // On lui demande si il est sur de vouleur supprimer le client
            MessageBoxResult result = MessageBox.Show("Voulez vous vraiment supprimer ce partenaire ?",
    "Suppression", MessageBoxButton.YesNo);

            if (result == MessageBoxResult.Yes)
            {
                try
                {
                   
                        // On supprime le partenaire séléctionner et on sauvegarde les modifications dans la base de données.
                        db.Partenaires.Remove((Partenaire)this.LST_Partenaire.SelectedItem);

                        db.SaveChanges();
                        ListePartenaire.Remove((Partenaire)this.LST_Partenaire.SelectedItem);
                        MessageBox.Show("Le partenaire a bien été supprimé");
                  


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
