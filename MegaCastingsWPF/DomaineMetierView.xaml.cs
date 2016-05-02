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
    /// Logique d'interaction pour DomaineMetierView.xaml
    /// </summary>
    public partial class DomaineMetierView : UserControl
    {
     

        //Creation d'une liste de tous les domaines de métier
        public ObservableCollection<DomaineDeMetier> ListeDomaineMetier { get; set; }

        public DomaineDeMetier domaineDeMetier { get; set; }

        public DomaineMetierView()
        {
            InitializeComponent();

            // On met domaines de métier de la base dans la liste
            
            ListeDomaineMetier = app.ListeDomaineDeMetier;
            this.DataContext = this;
        }

        // Méthode d'ajout d'un domaine de métier
        private void BTN_Ajouter_Click(object sender, RoutedEventArgs e)
        {
            domaineDeMetier = new DomaineDeMetier();
            //Ouverture d'une nouvelle fenetre pour ajouter un domaine de métier, on lui envoie un nouveau domaine de métier
            FenetreDomaineMetier fenetreDomaineMetier = new FenetreDomaineMetier(domaineDeMetier);

            if (fenetreDomaineMetier.ShowDialog() == true)
            {
                // Si l'utilisateur confirme l'ajout, on essaye de l'ajouter a la base de données et on sauvegarde.
                try
                {
                    app.db.DomaineDeMetiers.Add(domaineDeMetier);
                    app.db.SaveChanges();
                    this.ListeDomaineMetier.Add(domaineDeMetier);

                    MessageBox.Show("Le domaine de métier a bien été ajouté");
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
                    app.db.DomaineDeMetiers.Remove(fenetreDomaineMetier.domaineDeMetier);
                }
            }
        }

       

        //Méthode qui permet la modification du domaine de métier séléctionnée
        private void BTN_Modifier_Click(object sender, RoutedEventArgs e)
        {
          
            // Si l'utilisateur confirme la modification on essaye de la sauvegarder en base.
            try
            {
                app.db.SaveChanges();
                MessageBox.Show("Les informations sur le domaine de métier ont bien été modifiées");
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

        // Méthode de suppression du domaine de métier
        private void BTN_Supprimer_Click(object sender, RoutedEventArgs e)
        {
            // On lui demande si il est sur de vouleur supprimer le domaine de métier
            MessageBoxResult result = MessageBox.Show("Voulez vous vraiment supprimer ce domaine de métier ?",
   "Suppression", MessageBoxButton.YesNo);

            if (result == MessageBoxResult.Yes)
            {
                try
                {
                    // Si il a accepter on vérifie que le domaine de métier n'est pas lié à un métier.
                    if (((DomaineDeMetier)this.LST_NomDomaine.SelectedItem).Metiers.Count() == 0)
                    {
                        // On supprime le domaine de métier séléctionner et on sauvegarde les modifications dans la base de données.
                        app.db.DomaineDeMetiers.Remove((DomaineDeMetier)this.LST_NomDomaine.SelectedItem);
                        app.db.SaveChanges();
                        ListeDomaineMetier.Remove((DomaineDeMetier)this.LST_NomDomaine.SelectedItem);
                        MessageBox.Show("Le domaine de métier a bien été supprimé");
                    }
                    else
                    {
                        MessageBox.Show("Le domaine de métier ne peut pas être supprimer car il est lié à un métier");
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
