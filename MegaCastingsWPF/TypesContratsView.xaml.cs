using MegaCastingsDblib;
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
using MegaCastingsWPF.Class;

namespace MegaCastingsWPF
{
    /// <summary>
    /// Logique d'interaction pour TypesContratsView.xaml
    /// </summary>
    public partial class TypesContratsView : UserControl
    {

        //Creation d'une liste de tous les clients
        public ObservableCollection<TypesDeContrat> ListeTypesDeContrat { get; set; }

        public TypesDeContrat typesDeContrat { get; set; }

        public TypesContratsView()
        {
            InitializeComponent();

            //On récupère les clients de la base de donnée.
         
            ListeTypesDeContrat = app.TypesDeContrat;
            this.DataContext = this;
        }

        // Méthode qui permet d'ajouter un nouveau type de contrat
        private void BTN_Ajouter_Click(object sender, RoutedEventArgs e)
        {
            typesDeContrat = new TypesDeContrat();
            //Ouverture d'une nouvelle fenetre pour ajouter un type de contrat, on lui envoie un nouveau type de contrat
            FenetreTypeContrat fenetreTypeContrat = new FenetreTypeContrat(typesDeContrat);
            if (fenetreTypeContrat.ShowDialog() == true)
            {
                // Si l'utilisateur confirme l'ajout, on essaye de l'ajouter a la base de données et on sauvegarde.
                try
                {
                  
                    app.db.TypesDeContrats.Add(fenetreTypeContrat.typesDeContrat);
                    app.db.SaveChanges();
                    this.ListeTypesDeContrat.Add(fenetreTypeContrat.typesDeContrat);

                    MessageBox.Show("Le type de contrat  a bien été ajouté");
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
                    app.db.TypesDeContrats.Remove(fenetreTypeContrat.typesDeContrat);
                }
            }
        }

        //Méthode qui permet la modification du type de contrat séléctionnée
        private void BTN_Modifier_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                app.db.SaveChanges();
                MessageBox.Show("Les informations sur le type de contrat ont bien été modifiées");
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

        // Méthode pour suprimer un type de contrat.
        private void BTN_Supprimer_Click(object sender, RoutedEventArgs e)
        {
            // On lui demande si il est sur de vouleur supprimer le client
            MessageBoxResult result = MessageBox.Show("Voulez vous vraiment supprimer ce type de contrat ?",
    "Suppression", MessageBoxButton.YesNo);

            if (result == MessageBoxResult.Yes)
            {
                try
                {
                    // Si il a accepter on vérifie que le type de contrat n'est pas lié à une offre.
                    if (((TypesDeContrat)this.LST_Contrat.SelectedItem).Offres.Count() == 0)
                    {
                        // On supprime le type de contrat séléctionner et on sauvegarde les modifications dans la base de données.
                        app.db.TypesDeContrats.Remove((TypesDeContrat)this.LST_Contrat.SelectedItem);

                        app.db.SaveChanges();
                        ListeTypesDeContrat.Remove((TypesDeContrat)this.LST_Contrat.SelectedItem);
                        MessageBox.Show("Le type de contrat a bien été supprimé");
                    }
                    else
                    {
                        MessageBox.Show("Le type de contrat ne peut pas être supprimer car il est toujours lié à une offre");
                    }


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
