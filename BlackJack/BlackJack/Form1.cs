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
            int Nombre_ = 0;

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
            public int NombreJoues()
            {
                return Nombre_;
            }
            public void Jouer()
            {
                Nombre_++;
            }
        }

        Joueur JoueurHaut;
        Joueur JoueurBas;

        const int NOMBREDECATES = 52;
        public bool OnJoue = false;
        int TypePartie = -1;

        List<string> PaquetCartes = new List<string>();

        public Form1()
        {
            InitializeComponent();

            GenererPaquet();
        }

        private void GenererPaquet()
        {
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
            int NumCarte = Convert.ToInt32(CarteRessource.Substring(UnderScore + 1, CarteRessource.Length - UnderScore - 1));

            if (NumCarte == 1)
            {
                DialogResult result1 = MessageBox.Show("Voulez vous échanger votre As d'une valeur de 1 pour une valeur de 11?",
                "Important", MessageBoxButtons.YesNo);

                if (result1 == System.Windows.Forms.DialogResult.Yes)
                {
                    NumCarte = 11;
                }
            }

            return NumCarte;
        }

        private int GetNumCarteAI(Joueur AI, int Place, string CarteRessource)
        {
            // Donne le numéro de la carte à partir de son nom de ressource
            int UnderScore = CarteRessource.IndexOf("_");
            int NumCarte = Convert.ToInt32(CarteRessource.Substring(UnderScore + 1, CarteRessource.Length - UnderScore - 1));
           
            if (NumCarte == 1)
            {
                if (Place == 0)
                {
                    // Parce que c'est trop certain que on va se ramasser trop proche de 21
                    if (Convert.ToInt32(TBX_Score_J1.Text.ToString()) == 10 
                        || Convert.ToInt32(TBX_Score_J1.Text.ToString()) == 9
                        || Convert.ToInt32(TBX_Score_J1.Text.ToString()) == 8
                        || Convert.ToInt32(TBX_Score_J1.Text.ToString()) == 7)
                    {
                        NumCarte = 11;
                    }

                }
                else  // Place == 1
                {
                    // Parce que c'est trop certain que on va se ramasser trop proche de 21
                    if (Convert.ToInt32(TBX_Score_J2.Text.ToString()) == 10 
                        || Convert.ToInt32(TBX_Score_J2.Text.ToString()) == 9
                        || Convert.ToInt32(TBX_Score_J2.Text.ToString()) == 8
                        || Convert.ToInt32(TBX_Score_J2.Text.ToString()) == 7)
                    {
                        NumCarte = 11;
                    }

                }
            }

            return NumCarte;
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

                TypePartie = FormNP.Joueurs;
                OnJoue = true;
            }
        }


        private void àProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Jeu 'BlackJack', par Alexandre-xavier Labonté-Lamoureux & David Rodier, \nmars 2015.");
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Être-vous sûr de vouloir arrêter la partie?",
            "Important", MessageBoxButtons.YesNo);

            if (result1 == System.Windows.Forms.DialogResult.Yes)
            {
                // Arrêter la partie
                OnJoue = false;

                // Remettre à noeuf
                Reset();
            }
        }

        private void BTN_J1_Skip_Click(object sender, EventArgs e)
        {

        }

        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Quitter la partie
            Application.Exit();
        }

        // Pour les IA
        private void JouerUnTour(Joueur AI, int Place)  // La placer c'est s'il est en haut ou en bas ( 0 ou 1 ).
        {
            // On accède à la première carte
            string Pige = PaquetCartes[0];
            PaquetCartes.RemoveAt(0);

            //int ValeurCarte = GetNumCarte(Pige);
            int ValeurCarte = GetNumCarteAI(AI, Place, Pige);
            string TypeCarte = GetNomCarte(Pige);

            // Les cartes plus grandes que 10 valent 10
            if (ValeurCarte > 10)
            {
                ValeurCarte = 10;
            }

            int Score = 0;

            if (Place == 0) // Haut
            {
                Score = Convert.ToInt32(TBX_Score_J1.Text.ToString()) + ValeurCarte;
                TBX_Score_J1.Text = (Score).ToString();
            }
            else // Place == bas
            {
                Score = Convert.ToInt32(TBX_Score_J2.Text.ToString()) + ValeurCarte;
                TBX_Score_J2.Text = (Score).ToString();
            }

            if (Score < 10)
            {


                MettreCarte(AI, Place, Pige);
            }
            else
            { 
                // En embarque des les calculs statistiques
                
                // IMPLÉMENTER AI
                // IMPLÉMENTER AI
                // IMPLÉMENTER AI

                // ELLE DOIT FAIRE UN CALCULE DE PROBABILITÉS ICI
                // D'APRÈS SON NIVEAU DE RISQUE ET LES CHANCES QU'ELLE A DE PAS DÉPASSER 21
                // IL FAUT AUSSI IMPLÉMENTER LA COMPTAGE DANS CE CALCUL DE PROBABILITÉS

            }

        }

        // POur les joueurs humains
        private void JoueurHumain(Joueur AI, int Place)
        {
            // On accède à la première carte
            string Pige = PaquetCartes[0];
            PaquetCartes.RemoveAt(0);

            //int ValeurCarte = GetNumCarte(Pige);
            int ValeurCarte = GetNumCarte(Pige);
            string TypeCarte = GetNomCarte(Pige);

            // Les cartes plus grandes que 10 valent 10
            if (ValeurCarte > 10)
            {
                ValeurCarte = 10;
            }

            int Score = 0;

            if (Place == 0) // Haut
            {
                Score = Convert.ToInt32(TBX_Score_J1.Text.ToString()) + ValeurCarte;
                TBX_Score_J1.Text = (Score).ToString();
            }
            else // Place == bas
            {
                Score = Convert.ToInt32(TBX_Score_J2.Text.ToString()) + ValeurCarte;
                TBX_Score_J2.Text = (Score).ToString();
            }

            
            MettreCarte(AI, Place, Pige);

        }

        private void MettreCarte(Joueur AI, int Place, string Carte)
        {
            AI.Jouer();

            if (Place == 0) // EN HAUT
            {
                if (AI.NombreJoues() == 0)
                {
                    PB_J1_C1.BackgroundImage = GetCarteImage("Dos");
                    PB_J1_C2.BackgroundImage = GetCarteImage("Dos");
                    PB_J1_C3.BackgroundImage = GetCarteImage("Dos");
                    PB_J1_C4.BackgroundImage = GetCarteImage("Dos");
                    PB_J1_C5.BackgroundImage = GetCarteImage("Dos");
                    PB_J1_C6.BackgroundImage = GetCarteImage("Dos");
                    PB_J1_C7.BackgroundImage = GetCarteImage("Dos");
                    PB_J1_C8.BackgroundImage = GetCarteImage("Dos"); 
                }
                else if (AI.NombreJoues() == 1)
                {
                    PB_J1_C1.BackgroundImage = GetCarteImage(Carte);
                }
                else if (AI.NombreJoues() == 2)
                {
                    PB_J1_C2.BackgroundImage = GetCarteImage(Carte);
                }
                else if (AI.NombreJoues() == 3)
                {
                    PB_J1_C3.BackgroundImage = GetCarteImage(Carte);
                }
                else if (AI.NombreJoues() == 4)
                {
                    PB_J1_C4.BackgroundImage = GetCarteImage(Carte);
                }
                else if (AI.NombreJoues() == 5)
                {
                    PB_J1_C5.BackgroundImage = GetCarteImage(Carte);
                }
                else if (AI.NombreJoues() == 6)
                {
                    PB_J1_C6.BackgroundImage = GetCarteImage(Carte);
                }
                else if (AI.NombreJoues() == 7)
                {
                    PB_J1_C7.BackgroundImage = GetCarteImage(Carte);
                }
                else if (AI.NombreJoues() == 8)
                {
                    PB_J1_C8.BackgroundImage = GetCarteImage(Carte);
                }
                else
                {
                    MessageBox.Show("Le joueur 1 (celui en haut) vient d'atteindre la limite de cartes de l'interface");
                }
            }
            else if (Place == 1) // EN BAS
            {
                if (AI.NombreJoues() == 0)
                {
                    PB_J2_C1.BackgroundImage = GetCarteImage("Dos");
                    PB_J2_C2.BackgroundImage = GetCarteImage("Dos");
                    PB_J2_C3.BackgroundImage = GetCarteImage("Dos");
                    PB_J2_C4.BackgroundImage = GetCarteImage("Dos");
                    PB_J2_C5.BackgroundImage = GetCarteImage("Dos");
                    PB_J2_C6.BackgroundImage = GetCarteImage("Dos");
                    PB_J2_C7.BackgroundImage = GetCarteImage("Dos");
                    PB_J2_C8.BackgroundImage = GetCarteImage("Dos");
                }
                else if (AI.NombreJoues() == 1)
                {
                    PB_J2_C1.BackgroundImage = GetCarteImage(Carte);
                }
                else if (AI.NombreJoues() == 2)
                {
                    PB_J2_C2.BackgroundImage = GetCarteImage(Carte);
                }
                else if (AI.NombreJoues() == 3)
                {
                    PB_J2_C3.BackgroundImage = GetCarteImage(Carte);
                }
                else if (AI.NombreJoues() == 4)
                {
                    PB_J2_C4.BackgroundImage = GetCarteImage(Carte);
                }
                else if (AI.NombreJoues() == 5)
                {
                    PB_J2_C5.BackgroundImage = GetCarteImage(Carte);
                }
                else if (AI.NombreJoues() == 6)
                {
                    PB_J2_C6.BackgroundImage = GetCarteImage(Carte);
                }
                else if (AI.NombreJoues() == 7)
                {
                    PB_J2_C7.BackgroundImage = GetCarteImage(Carte);
                }
                else if (AI.NombreJoues() == 8)
                {
                    PB_J2_C8.BackgroundImage = GetCarteImage(Carte);
                }
                else
                {
                    MessageBox.Show("Le joueur 2 (celui en bas) vient d'atteindre la limite de cartes de l'interface");
                }
            }
        }

        private System.Drawing.Bitmap GetCarteImage(string Carte)
        {
            if (Carte == "Carreau_1")
                return Properties.Resources.Carreau_1;
            else if (Carte == "Carreau_2")
                return Properties.Resources.Carreau_2;
            else if (Carte == "Carreau_3")
                return Properties.Resources.Carreau_3;
            else if (Carte == "Carreau_4")
                return Properties.Resources.Carreau_4;
            else if (Carte == "Carreau_5")
                return Properties.Resources.Carreau_5;
            else if (Carte == "Carreau_6")
                return Properties.Resources.Carreau_6;
            else if (Carte == "Carreau_7")
                return Properties.Resources.Carreau_7;
            else if (Carte == "Carreau_8")
                return Properties.Resources.Carreau_8;
            else if (Carte == "Carreau_9")
                return Properties.Resources.Carreau_9;
            else if (Carte == "Carreau_10")
                return Properties.Resources.Carreau_10;
            else if (Carte == "Carreau_11")
                return Properties.Resources.Carreau_11;
            else if (Carte == "Carreau_12")
                return Properties.Resources.Carreau_12;
            else if (Carte == "Carreau_13")
                return Properties.Resources.Carreau_13;

            else if (Carte == "Coeur_1")
                return Properties.Resources.Coeur_1;
            else if (Carte == "Coeur_2")
                return Properties.Resources.Coeur_2;
            else if (Carte == "Coeur_3")
                return Properties.Resources.Coeur_3;
            else if (Carte == "Coeur_4")
                return Properties.Resources.Coeur_4;
            else if (Carte == "Coeur_5")
                return Properties.Resources.Coeur_5;
            else if (Carte == "Coeur_6")
                return Properties.Resources.Coeur_6;
            else if (Carte == "Coeur_7")
                return Properties.Resources.Coeur_7;
            else if (Carte == "Coeur_8")
                return Properties.Resources.Coeur_8;
            else if (Carte == "Coeur_9")
                return Properties.Resources.Coeur_9;
            else if (Carte == "Coeur_10")
                return Properties.Resources.Coeur_10;
            else if (Carte == "Coeur_11")
                return Properties.Resources.Coeur_11;
            else if (Carte == "Coeur_12")
                return Properties.Resources.Coeur_12;
            else if (Carte == "Coeur_13")
                return Properties.Resources.Coeur_13;

            else if (Carte == "Pique_1")
                return Properties.Resources.Pique_1;
            else if (Carte == "Pique_2")
                return Properties.Resources.Pique_2;
            else if (Carte == "Pique_3")
                return Properties.Resources.Pique_3;
            else if (Carte == "Pique_4")
                return Properties.Resources.Pique_4;
            else if (Carte == "Pique_5")
                return Properties.Resources.Pique_5;
            else if (Carte == "Pique_6")
                return Properties.Resources.Pique_6;
            else if (Carte == "Pique_7")
                return Properties.Resources.Pique_7;
            else if (Carte == "Pique_8")
                return Properties.Resources.Pique_8;
            else if (Carte == "Pique_9")
                return Properties.Resources.Pique_9;
            else if (Carte == "Pique_10")
                return Properties.Resources.Pique_10;
            else if (Carte == "Pique_11")
                return Properties.Resources.Pique_11;
            else if (Carte == "Pique_12")
                return Properties.Resources.Pique_12;
            else if (Carte == "Pique_13")
                return Properties.Resources.Pique_13;

            else if (Carte == "Trefle_1")
                return Properties.Resources.Trefle_1;
            else if (Carte == "Trefle_2")
                return Properties.Resources.Trefle_2;
            else if (Carte == "Trefle_3")
                return Properties.Resources.Trefle_3;
            else if (Carte == "Trefle_4")
                return Properties.Resources.Trefle_4;
            else if (Carte == "Trefle_5")
                return Properties.Resources.Trefle_5;
            else if (Carte == "Trefle_6")
                return Properties.Resources.Trefle_6;
            else if (Carte == "Trefle_7")
                return Properties.Resources.Trefle_7;
            else if (Carte == "Trefle_8")
                return Properties.Resources.Trefle_8;
            else if (Carte == "Trefle_9")
                return Properties.Resources.Trefle_9;
            else if (Carte == "Trefle_10")
                return Properties.Resources.Trefle_10;
            else if (Carte == "Trefle_11")
                return Properties.Resources.Trefle_11;
            else if (Carte == "Trefle_12")
                return Properties.Resources.Trefle_12;
            else if (Carte == "Trefle_13")
                return Properties.Resources.Trefle_13;

            else
                return Properties.Resources.Dos;    // Par défaut
        }

        private void BTN_J1_Piger_Click(object sender, EventArgs e)
        {
            if (OnJoue) // Faire sûr que la partie continue
            {
                // Quand c'est ......
                if (TypePartie == 0)    // Humain vs Humain
                {
                    // Humain en haut
                    JoueurHumain(JoueurHaut, 0);
                }
                else if (TypePartie == 1)   // Humain (bas) vs AI (haut)
                {
                    // C'est le AI en haut qui joue
                    JouerUnTour(JoueurHaut, 0);
                }
                else if (TypePartie == 2)   // AI vs AI
                {
                    // C'est le AI en haut qui joue
                    JouerUnTour(JoueurHaut, 0);
                }
                else
                {
                    MessageBox.Show("Oups. Mauvais type de partie dans 'BTN_J1_Piger_Click()'.");
                }

            }
        }

        private void BTN_J2_Piger_Click(object sender, EventArgs e)
        {
            if (OnJoue) // Faire sûr que la partie continue
            {
                // Quand c'est ......
                if (TypePartie == 0)    // Humain vs Humain
                {
                    // Humain en bas
                    JoueurHumain(JoueurBas, 1);
                }
                else if (TypePartie == 1)   // Humain (bas) vs AI (haut)
                {
                    // Humain en bas
                    JoueurHumain(JoueurBas, 1);
                }
                else if (TypePartie == 2)   // AI vs AI
                {
                    // C'est le AI en bas qui joue
                    JouerUnTour(JoueurBas, 1);
                }
                else
                {
                    MessageBox.Show("Oups. Mauvais type de partie dans 'BTN_J2_Piger_Click()'.");
                }

            }
        }

        private void Reset()
        {
            PB_J1_C1.BackgroundImage = GetCarteImage("Dos");
            PB_J1_C2.BackgroundImage = GetCarteImage("Dos");
            PB_J1_C3.BackgroundImage = GetCarteImage("Dos");
            PB_J1_C4.BackgroundImage = GetCarteImage("Dos");
            PB_J1_C5.BackgroundImage = GetCarteImage("Dos");
            PB_J1_C6.BackgroundImage = GetCarteImage("Dos");
            PB_J1_C7.BackgroundImage = GetCarteImage("Dos");
            PB_J1_C8.BackgroundImage = GetCarteImage("Dos");

            PB_J2_C1.BackgroundImage = GetCarteImage("Dos");
            PB_J2_C2.BackgroundImage = GetCarteImage("Dos");
            PB_J2_C3.BackgroundImage = GetCarteImage("Dos");
            PB_J2_C4.BackgroundImage = GetCarteImage("Dos");
            PB_J2_C5.BackgroundImage = GetCarteImage("Dos");
            PB_J2_C6.BackgroundImage = GetCarteImage("Dos");
            PB_J2_C7.BackgroundImage = GetCarteImage("Dos");
            PB_J2_C8.BackgroundImage = GetCarteImage("Dos");

            BTN_J1_Skip.Enabled = false;
            BTN_J1_Piger.Enabled = false;
            TBX_Score_J1.Text = "0";

            BTN_J2_Skip.Enabled = false;
            BTN_J2_Piger.Enabled = false;
            TBX_Score_J2.Text = "0";

            OnJoue = false;
            TypePartie = -1;

            PaquetCartes.Clear();
            GenererPaquet();
        }
    }
}
