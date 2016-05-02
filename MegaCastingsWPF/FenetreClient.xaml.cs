using MegaCastingsDblib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Logique d'interaction pour FenetreClient.xaml
    /// </summary>
    public partial class FenetreClient : Window
    {
        // On crée les accesseurs pour le client
        public Client client { get; set; }

        public FenetreClient(Client clientContext)
        {

            InitializeComponent();

            // On récupere les information du client si c'est une modification ou des information vierge pour un nouveau client.
            this.client = clientContext;
            this.DataContext = this;

        }


        // Méthode pour sauvegarder l'ajout
        private void BTN_Sauvegarder_Click(object sender, RoutedEventArgs e)
        {
            string patternNumero = @"^[0-9]{10}";
            Regex regex = new Regex(patternNumero);
            bool Verif = true;
         
           
            if (!String.IsNullOrWhiteSpace(TXT_Fax.Text))
            {
                if (!regex.IsMatch(TXT_Fax.Text))
                {
                    Verif = false;
                    MessageBox.Show("Le numero de fax n'est pas valide");
                }
            }

            if (!String.IsNullOrWhiteSpace(TXT_Telephone.Text))
            {
                if (!regex.IsMatch(TXT_Telephone.Text))
                {
                    Verif = false;
                    MessageBox.Show("Le numero de téléphone n'est pas valide");
                }
            }

            if (!String.IsNullOrWhiteSpace(TXT_Email.Text))
            {
                try
                {
                    MailAddress m = new MailAddress(TXT_Email.Text);
                }
                catch (FormatException)
                {
                    Verif = false;
                    MessageBox.Show("L'adresse email n'est pas valide");
                   
                }
            }


            if (Verif == true)
            {

                // on envoie true en fermant la fenêtre pour confirmer la validation.
                DialogResult = true;
            }
        }

        //Méthode pour annuler l'ajout
        private void BTN_Annuler_Click(object sender, RoutedEventArgs e)
        {
            // On envoie false en fermant la fenetre pour que les changement/ajout ne soit pas pris en compte.
            DialogResult = false;
        }
    }
}
