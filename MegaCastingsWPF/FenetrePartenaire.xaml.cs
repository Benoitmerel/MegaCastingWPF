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

            InitializeComponent();

            // On récupere le nouveau partenaire.
            this.partenaire = partenairecontext;
            this.DataContext = this;
        }

        // Méthode pour sauvegarder l'ajout
        private void BTN_Sauvegarder_Click(object sender, RoutedEventArgs e)
        {
            // On met les informations relative au client des TextBox au client
            partenaire.Nom = TXT_NomPartenaire.Text;

            byte[] buffer = System.Text.Encoding.ASCII.GetBytes(TXT_MotDePasse.Password);
            SHA1CryptoServiceProvider cryptoTransformSHA1 = new SHA1CryptoServiceProvider();
            partenaire.MotDePasse = BitConverter.ToString(cryptoTransformSHA1.ComputeHash(buffer)).Replace("-", "");


            // on envoie true en fermant la fenêtre pour confirmer la validation.
            DialogResult = true;
        }

        //Méthode pour annuler l'ajout
        private void BTN_Annuler_Click(object sender, RoutedEventArgs e)
        {
            // On envoie false en fermant la fenetre pour que les changement/ ajout ne soit pas pris en compte.
            DialogResult = false;
        }
    }
}
