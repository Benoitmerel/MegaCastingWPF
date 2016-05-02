using MegaCastingsDblib;
using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace MegaCastingsWPF
{
    /// <summary>
    /// Logique d'interaction pour FenetrePartenaire.xaml
    /// </summary>
    public partial class FenetrePartenaire : Window
    {

        // On crée les accesseurs pour le partenaire
        public Partenaire partenaire { get; set; }

        public FenetrePartenaire(Partenaire partenairecontext)
        {
            InitializeComponent();


            // On récupere le nouveau partenaire.
            this.partenaire = partenairecontext;
            this.DataContext = this;
        }

        // Méthode pour sauvegarder l'ajout
        private void BTN_Sauvegarder_Click(object sender, RoutedEventArgs e)
        {
            Boolean Verif = true;
            // On met les informations relative au client des TextBox au client
            String MotDePasse;
            String ConfirmationMotDePasse;

            byte[] buffer = System.Text.Encoding.ASCII.GetBytes(TXT_MotDePasse.Password);
            byte[] bufferConfirmation = System.Text.Encoding.ASCII.GetBytes(TXT_ConfirmationMotDePasse.Password);
            SHA1CryptoServiceProvider cryptoTransformSHA1 = new SHA1CryptoServiceProvider();
            MotDePasse = BitConverter.ToString(cryptoTransformSHA1.ComputeHash(buffer)).Replace("-", "");
            ConfirmationMotDePasse = BitConverter.ToString(cryptoTransformSHA1.ComputeHash(bufferConfirmation)).Replace("-", "");
            if (MotDePasse.Equals(ConfirmationMotDePasse))
            {

                partenaire.MotDePasse = MotDePasse;
                // on envoie true en fermant la fenêtre pour confirmer la validation.
                DialogResult = true;
            }
            else
            {
                MessageBox.Show("Les mots de passes ne sont pas identiques.");
                Verif = false;
            }

            if (String.IsNullOrEmpty(TXT_MotDePasse.Password))
            {
                MessageBox.Show("Veuillez renseigner un mot de passe.");
                Verif = false;
            }

                if (Verif == true)
            {

            }
            


            
           
        }

        //Méthode pour annuler l'ajout
        private void BTN_Annuler_Click(object sender, RoutedEventArgs e)
        {
            // On envoie false en fermant la fenetre pour que les changement/ ajout ne soit pas pris en compte.
            DialogResult = false;
        }
    }
}
