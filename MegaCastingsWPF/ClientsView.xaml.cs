using MegaCastingsDblib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace MegaCastingsWPF
{
    /// <summary>
    /// Logique d'interaction pour ClientsView.xaml
    /// </summary>
    public partial class ClientsView : UserControl
    {
        //Creation d'une liste de toutes les clients
        public ObservableCollection<Client> ListeClients { get; set; }
        public Client client { get; set; }

        public ClientsView()
        {
            InitializeComponent();
            app.ListeClients = new ObservableCollection<Client>(app.db.Clients.ToList());
            ListeClients = app.ListeClients;
            ObservableCollection<Client> liste = app.ListeClients;
            this.DataContext = this;
        }

     



        // Méthode qui permet d'ajouter un nouveau client
        private void BTN_Ajouter_Click(object sender, RoutedEventArgs e)
        {
            client = new Client();
            //Ouverture d'une nouvelle fenetre pour ajouter un client, on lui envoie un nouveau client
            FenetreClient fenetreClient = new FenetreClient(client);
            if (fenetreClient.ShowDialog() == true)
            {


                // Si l'utilisateur confirme l'ajout, on essaye de l'ajouter a la base de données et on sauvegarde.
                try
                {
                    app.db.Clients.Add(client);
                    app.db.SaveChanges();
                    ListeClients.Add(client);


                    MessageBox.Show("Le client a bien été ajouté");
                }
                catch(DbEntityValidationException DbEx)
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
                    app.db.Clients.Remove(fenetreClient.client);
                }
            }
        }


        //Méthode qui permet la modification du client séléctionnée
        private void BTN_Modifier_Click(object sender, RoutedEventArgs e)
        {

            string patternNumero = @"^[0-9]{10}";
            Regex regex = new Regex(patternNumero);
            bool Verif = true;

            if (TXT_Fax.Text != "")
            {
                if (!regex.IsMatch(TXT_Fax.Text))
                {
                    Verif = false;
                    MessageBox.Show("Le numero de fax n'est pas valide");
                }
            }

            if (TXT_Telephone.Text != "")
            {
                if (!regex.IsMatch(TXT_Telephone.Text))
                {
                    Verif = false;
                    MessageBox.Show("Le numero de téléphone n'est pas valide");
                }
            }

            if (TXT_Email.Text != "")
            {
                try
                {
                    MailAddress m = new MailAddress(TXT_Email.Text);
                }
                catch (FormatException)
                {
                    Verif = false;
                    MessageBox.Show("L'adresse email n'est pas valide");
                    //DialogResult = false;
                }
            }

            if(Verif == true)
            {
                try
                {
                    app.db.SaveChanges();
                    MessageBox.Show("Les informations sur le client ont bien été modifiées");
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
           
        }

        // Méthode pour suprimer un client.
        private void BTN_Supprimer_Click(object sender, RoutedEventArgs e)
        {
            // On lui demande si il est sur de vouleur supprimer le client
            MessageBoxResult result = MessageBox.Show("Voulez vous vraiment supprimer ce client ?",
    "Suppression",  MessageBoxButton.YesNo);

            if (result == MessageBoxResult.Yes)
            {
                try
                {
                    // Si il a accepter on vérifie que le client n'est pas lié à une offre.
                    if (((Client)this.LST_Clients.SelectedItem).Offres.Count() == 0)
                    {
                        // On supprime le client séléctionner et on sauvegarde les modifications dans la base de données.
                        app.db.Clients.Remove((Client)this.LST_Clients.SelectedItem);

                        app.db.SaveChanges();
                        ListeClients.Remove((Client)this.LST_Clients.SelectedItem);
                        MessageBox.Show("Le client a bien été supprimé");
                    }
                    else
                    {
                        MessageBox.Show("Le client ne peut pas être supprimer car il est toujours lié à une offre");
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
