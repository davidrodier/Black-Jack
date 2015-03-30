using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
//using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class Form1 : Form
    {
        public class Joueur
        {
            bool AI_ = false;    // Si c'Est un AI
            int Difficulte_ = 0; // 0: 50%, 1: 65%, 2: 80%. Ça représente le risque. 
            bool Finit_ = false; // True si le joueur a passé
            bool Compte_ = false;

            public Joueur(bool AI, int Difficulte, bool Compte)
            {
                AI_ = AI;
                Difficulte_ = Difficulte;
                Compte_ = Compte;
            }

            public void Passer()
            {
                Finit_ = true;
            }

            public bool CheckPasser()
            {
                return Finit_;
            }
            public bool CheckAI()
            {
                return AI_;
            }
        }

        Joueur JoueurHaut;
        Joueur JoueurBas;

        const int NOMBREDECATES = 52;

        List<string> PaquetCartes = new List<string>();

        public Form1()
        {
            InitializeComponent();

            Random Randomizateur = new Random();

            // Merde, on peut pas faire un 'foreach' dans les ressources!!!!  FUCK
            // On peut pas les lister, on peut juste accéder à une ressource directement
            PaquetCartes.Insert(Randomizateur.Next(0, PaquetCartes.Count), "Carreau_1");
            PaquetCartes.Insert(Randomizateur.Next(0, PaquetCartes.Count), "Carreau_2");
            PaquetCartes.Insert(Randomizateur.Next(0, PaquetCartes.Count), "Carreau_3");
            PaquetCartes.Insert(Randomizateur.Next(0, PaquetCartes.Count), "Carreau_4");
            PaquetCartes.Insert(Randomizateur.Next(0, PaquetCartes.Count), "Carreau_5");
            PaquetCartes.Insert(Randomizateur.Next(0, PaquetCartes.Count), "Carreau_6");
            PaquetCartes.Insert(Randomizateur.Next(0, PaquetCartes.Count), "Carreau_7");
            PaquetCartes.Insert(Randomizateur.Next(0, PaquetCartes.Count), "Carreau_8");
            PaquetCartes.Insert(Randomizateur.Next(0, PaquetCartes.Count), "Carreau_9");
            PaquetCartes.Insert(Randomizateur.Next(0, PaquetCartes.Count), "Carreau_10");
            PaquetCartes.Insert(Randomizateur.Next(0, PaquetCartes.Count), "Carreau_11");
            PaquetCartes.Insert(Randomizateur.Next(0, PaquetCartes.Count), "Carreau_12");
            PaquetCartes.Insert(Randomizateur.Next(0, PaquetCartes.Count), "Carreau_13");

            PaquetCartes.Insert(Randomizateur.Next(0, PaquetCartes.Count), "Coeur_1");
            PaquetCartes.Insert(Randomizateur.Next(0, PaquetCartes.Count), "Coeur_2");
            PaquetCartes.Insert(Randomizateur.Next(0, PaquetCartes.Count), "Coeur_3");
            PaquetCartes.Insert(Randomizateur.Next(0, PaquetCartes.Count), "Coeur_4");
            PaquetCartes.Insert(Randomizateur.Next(0, PaquetCartes.Count), "Coeur_5");
            PaquetCartes.Insert(Randomizateur.Next(0, PaquetCartes.Count), "Coeur_6");
            PaquetCartes.Insert(Randomizateur.Next(0, PaquetCartes.Count), "Coeur_7");
            PaquetCartes.Insert(Randomizateur.Next(0, PaquetCartes.Count), "Coeur_8");
            PaquetCartes.Insert(Randomizateur.Next(0, PaquetCartes.Count), "Coeur_9");
            PaquetCartes.Insert(Randomizateur.Next(0, PaquetCartes.Count), "Coeur_10");
            PaquetCartes.Insert(Randomizateur.Next(0, PaquetCartes.Count), "Coeur_11");
            PaquetCartes.Insert(Randomizateur.Next(0, PaquetCartes.Count), "Coeur_12");
            PaquetCartes.Insert(Randomizateur.Next(0, PaquetCartes.Count), "Coeur_13");

            PaquetCartes.Insert(Randomizateur.Next(0, PaquetCartes.Count), "Pique_1");
            PaquetCartes.Insert(Randomizateur.Next(0, PaquetCartes.Count), "Pique_2");
            PaquetCartes.Insert(Randomizateur.Next(0, PaquetCartes.Count), "Pique_3");
            PaquetCartes.Insert(Randomizateur.Next(0, PaquetCartes.Count), "Pique_4");
            PaquetCartes.Insert(Randomizateur.Next(0, PaquetCartes.Count), "Pique_5");
            PaquetCartes.Insert(Randomizateur.Next(0, PaquetCartes.Count), "Pique_6");
            PaquetCartes.Insert(Randomizateur.Next(0, PaquetCartes.Count), "Pique_7");
            PaquetCartes.Insert(Randomizateur.Next(0, PaquetCartes.Count), "Pique_8");
            PaquetCartes.Insert(Randomizateur.Next(0, PaquetCartes.Count), "Pique_9");
            PaquetCartes.Insert(Randomizateur.Next(0, PaquetCartes.Count), "Pique_10");
            PaquetCartes.Insert(Randomizateur.Next(0, PaquetCartes.Count), "Pique_11");
            PaquetCartes.Insert(Randomizateur.Next(0, PaquetCartes.Count), "Pique_12");
            PaquetCartes.Insert(Randomizateur.Next(0, PaquetCartes.Count), "Pique_13");

            PaquetCartes.Insert(Randomizateur.Next(0, PaquetCartes.Count), "Trefle_1");
            PaquetCartes.Insert(Randomizateur.Next(0, PaquetCartes.Count), "Trefle_2");
            PaquetCartes.Insert(Randomizateur.Next(0, PaquetCartes.Count), "Trefle_3");
            PaquetCartes.Insert(Randomizateur.Next(0, PaquetCartes.Count), "Trefle_4");
            PaquetCartes.Insert(Randomizateur.Next(0, PaquetCartes.Count), "Trefle_5");
            PaquetCartes.Insert(Randomizateur.Next(0, PaquetCartes.Count), "Trefle_6");
            PaquetCartes.Insert(Randomizateur.Next(0, PaquetCartes.Count), "Trefle_7");
            PaquetCartes.Insert(Randomizateur.Next(0, PaquetCartes.Count), "Trefle_8");
            PaquetCartes.Insert(Randomizateur.Next(0, PaquetCartes.Count), "Trefle_9");
            PaquetCartes.Insert(Randomizateur.Next(0, PaquetCartes.Count), "Trefle_10");
            PaquetCartes.Insert(Randomizateur.Next(0, PaquetCartes.Count), "Trefle_11");
            PaquetCartes.Insert(Randomizateur.Next(0, PaquetCartes.Count), "Trefle_12");
            PaquetCartes.Insert(Randomizateur.Next(0, PaquetCartes.Count), "Trefle_13");
            // Finit. C'est un paquet de cartes mélangées. 
        }

        private string GetNomCarte(string CarteRessource)
        {
            // Donne le type de la carte à partir de son nom de ressource
            int UnderScore = CarteRessource.IndexOf("_");
            return CarteRessource.Substring(0, UnderScore);
        }

        private int GetNumCarte(string CarteRessource)
        {
            // Donne le numéro de la carte à partir de son nom de ressource
            int UnderScore = CarteRessource.IndexOf("_");
            return Convert.ToInt32(CarteRessource.Substring(UnderScore + 1, CarteRessource.Length - UnderScore));
        }

        private void nouvellePartieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NouvellePartie FormNP = new NouvellePartie();

            if (FormNP.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //JoueurHaut = new Joueur(FormNP);

                if (FormNP.Joueurs == 0)
                {
                    JoueurHaut = new Joueur(false, 0, false);
                    RTB_Ai1.Text = RTB_Ai1.Text.ToString() + "\n" + "Joueur humain";
                    BTN_J1_Skip.Enabled = true;
                    BTN_J1_Piger.Enabled = true;

                    JoueurBas = new Joueur(false, 0, false);
                    RTB_Ai2.Text = RTB_Ai2.Text.ToString() + "\n" + "Joueur humain";
                    BTN_J2_Skip.Enabled = true;
                    BTN_J2_Piger.Enabled = true;

                }
                else if (FormNP.Joueurs == 1)
                {
                    JoueurHaut = new Joueur(true, FormNP.Risque1, FormNP.Compte1);
                    RTB_Ai1.Text = RTB_Ai1.Text.ToString() + "\n" + "Joueur ordinateur";
                    BTN_J1_Skip.Enabled = false;
                    BTN_J1_Piger.Enabled = true;

                    if (FormNP.Risque1 == 0)
                    {
                        RTB_Ai1.Text = RTB_Ai1.Text.ToString() + " Courageux";
                    }
                    else if (FormNP.Risque1 == 1)
                    {
                        RTB_Ai1.Text = RTB_Ai1.Text.ToString() + " Moyen";
                    }
                    else if (FormNP.Risque1 == 2)
                    {
                        RTB_Ai1.Text = RTB_Ai1.Text.ToString() + " Prudent";
                    }

                    if (FormNP.Compte1 == true)
                    {
                        RTB_Ai1.Text = RTB_Ai1.Text.ToString() + " (Compte)";
                    }

                    JoueurBas = new Joueur(false, 0, false);
                    RTB_Ai2.Text = RTB_Ai2.Text.ToString() + "\n" + "Joueur humain";
                    BTN_J2_Skip.Enabled = true;
                    BTN_J2_Piger.Enabled = true;
                }
                else if (FormNP.Joueurs == 2)
                {
                    JoueurHaut = new Joueur(true, FormNP.Risque1, FormNP.Compte1);
                    RTB_Ai1.Text = RTB_Ai1.Text.ToString() + "\n" + "Joueur ordinateur";
                    BTN_J1_Skip.Enabled = false;
                    BTN_J1_Piger.Enabled = true;

                    if (FormNP.Risque1 == 0)
                    {
                        RTB_Ai1.Text = RTB_Ai1.Text.ToString() + " Courageux";
                    }
                    else if (FormNP.Risque1 == 1)
                    {
                        RTB_Ai1.Text = RTB_Ai1.Text.ToString() + " Moyen";
                    }
                    else if (FormNP.Risque1 == 2)
                    {
                        RTB_Ai1.Text = RTB_Ai1.Text.ToString() + " Prudent";
                    }

                    if (FormNP.Compte1 == true)
                    {
                        RTB_Ai1.Text = RTB_Ai1.Text.ToString() + " (Compte)";
                    }

                    JoueurBas = new Joueur(true, FormNP.Risque2, FormNP.Compte2);
                    RTB_Ai2.Text = RTB_Ai2.Text.ToString() + "\n" + "Joueur ordinateur";
                    BTN_J2_Skip.Enabled = false;
                    BTN_J2_Piger.Enabled = true;

                    if (FormNP.Risque2 == 0)
                    {
                        RTB_Ai2.Text = RTB_Ai2.Text.ToString() + " Courageux";
                    }
                    else if (FormNP.Risque2 == 1)
                    {
                        RTB_Ai2.Text = RTB_Ai2.Text.ToString() + " Moyen";
                    }
                    else if (FormNP.Risque2 == 2)
                    {
                        RTB_Ai2.Text = RTB_Ai2.Text.ToString() + " Prudent";
                    }

                    if (FormNP.Compte2 == true)
                    {
                        RTB_Ai2.Text = RTB_Ai2.Text.ToString() + " (Compte)";
                    }
                }
                else
                {
                    MessageBox.Show("Erreur dans 'nouvellePartieToolStripMenuItem_Click'.");
                }

            }
        }

        private void àProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Jeu 'BlackJack', par Alexandre-xavier Labonté-Lamoureux & David Rodier, \nmars 2015.");
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BTN_J1_Skip_Click(object sender, EventArgs e)
        {

        }
    }
}
