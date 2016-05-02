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
    /// Logique d'interaction pour MetierView.xaml
    /// </summary>
    public partial class MetierView : UserControl
    {
        //Creation d'une liste de tous les métiers
        public ObservableCollection<Metier> ListeMetier { get; set; }

        // on crée les accesseurs pour la liste des domaines de métiers
        public ObservableCollection<DomaineDeMetier> ListeDomaineMetier { get; set; }

        public Metier metier { get; set; }

        public MetierView()
        {
            InitializeComponent();
            // On met les métiers de la base de donnée dans la liste
           
            ListeMetier = app.ListeMetier;
            // On récupère la liste de tous les domaines de métiers.
            app.ListeDomaineDeMetier = new ObservableCollection<DomaineDeMetier>(app.db.DomaineDeMetiers.ToList());
            ListeDomaineMetier = app.ListeDomaineDeMetier;
            this.DataContext = this;
        }

        // Méthode qui permet d'ajouter un nouveau métier
        private void BTN_Ajouter_Click(object sender, RoutedEventArgs e)
        {
            metier = new Metier();
            //Ouverture d'une nouvelle fenetre pour ajouter un métier, on lui envoie un nouveau métier
            FenetreMetier fenetreMetier = new FenetreMetier(metier, app.db);
            if (fenetreMetier.ShowDialog() == true)
            {
                // Si l'utilisateur confirme l'ajout, on essaye de l'ajouter a la base de données et on sauvegarde.s
                try
                {
                    app.db.Metiers.Add(metier);
                    app.db.SaveChanges();
                    this.ListeMetier.Add(metier);

                    MessageBox.Show("Le métier a bien été ajouté");
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
                    app.db.Metiers.Remove(fenetreMetier.metier);

                }
            }
        }


        //Méthode qui permet la modification du métier séléctionnée
        private void BTN_Modifier_Click(object sender, RoutedEventArgs e)
        {
          
            try
            {
                app.db.SaveChanges();
                MessageBox.Show("Les informations sur le métier ont bien été modifiées");
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

        // Méthode pour suprimer un client.
        private void BTN_Supprimer_Click(object sender, RoutedEventArgs e)
        {
            // On lui demande si il est sur de vouleur supprimer le métier
            MessageBoxResult result = MessageBox.Show("Voulez vous vraiment supprimer ce métier ?",
    "Suppression", MessageBoxButton.YesNo);

            if (result == MessageBoxResult.Yes)
            {
                try
                {
                    // Si il a accepter on vérifie que le métier n'est pas lié à une offre.
                    if (((Metier)this.LST_Metier.SelectedItem).Offres.Count() == 0)
                    {
                        // On supprime le métier séléctionner et on sauvegarde les modifications dans la base de données.
                        app.db.Metiers.Remove((Metier)this.LST_Metier.SelectedItem);

                        app.db.SaveChanges();
                        ListeMetier.Remove((Metier)this.LST_Metier.SelectedItem);
                        MessageBox.Show("Le métier a bien été supprimé");
                    }
                    else
                    {
                        MessageBox.Show("Le métier ne peut pas être supprimer car il est toujours lié à une offre");
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
