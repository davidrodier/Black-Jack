using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class NouvellePartie : Form
    {
        // Pour communiquer les settings
        public int Joueurs = -1;
        public int Risque1 = -1;
        public int Risque2 = -1;
        public bool Compte1 = false;
        public bool Compte2 = false;

        public NouvellePartie()
        {
            InitializeComponent();
        }

        private void CheckCommencerPossible()
        {
            if (CB_Joueurs.SelectedIndex == 1)
            {
                if (CB_Risque1.SelectedIndex == 0 || CB_Risque1.SelectedIndex == 1
                    || CB_Risque1.SelectedIndex == 2)
                {
                    BTN_Commencer.Enabled = true;
                }
                else
                {
                    BTN_Commencer.Enabled = false;
                }
            }
            else if (CB_Joueurs.SelectedIndex == 2)
            {
                if (CB_Risque1.SelectedIndex == 0 || CB_Risque1.SelectedIndex == 1
                    || CB_Risque1.SelectedIndex == 2)
                {
                    if (CB_Risque2.SelectedIndex == 0 || CB_Risque2.SelectedIndex == 1
                        || CB_Risque2.SelectedIndex == 2)
                    {
                        BTN_Commencer.Enabled = true;
                    }
                    else
                    {
                        BTN_Commencer.Enabled = false;
                    }
                }
                else
                {
                    BTN_Commencer.Enabled = false;
                }
            }
            else
            {
                BTN_Commencer.Enabled = true;
            }
        }

        private void CB_Joueurs_SelectedIndexChanged(object sender, EventArgs e)
        {
            Joueurs = CB_Joueurs.SelectedIndex;

            if (CB_Joueurs.SelectedIndex == 0)
            {
                // Humain vs humain
                CB_Risque1.Enabled = false;
                CB_Risque2.Enabled = false;
                CB_1Compte.Enabled = false;
                CB_2Compte.Enabled = false;

                BTN_Commencer.Enabled = true;
            }
            else if (CB_Joueurs.SelectedIndex == 1)
            { 
                // Humain vs AI
                CB_Risque1.Enabled = true;
                CB_Risque2.Enabled = false;
                CB_1Compte.Enabled = true;
                CB_2Compte.Enabled = false;

                BTN_Commencer.Enabled = false;
            }
            else if (CB_Joueurs.SelectedIndex == 2)
            {
                // AI vs AI
                CB_Risque1.Enabled = true;
                CB_Risque2.Enabled = true;
                CB_1Compte.Enabled = true;
                CB_2Compte.Enabled = true;

                BTN_Commencer.Enabled = false;
            }
            else
            {
                MessageBox.Show("Erreur dans 'CB_Joueurs_SelectedIndexChanged'.");
            }
            CheckCommencerPossible();
        }

        private void CB_Risque1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Risque1 = CB_Risque1.SelectedIndex;
            CheckCommencerPossible();
        }

        private void CB_Risque2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Risque2 = CB_Risque2.SelectedIndex;
            CheckCommencerPossible();
        }

        private void CB_1Compte_CheckedChanged(object sender, EventArgs e)
        {
            Compte1 = CB_1Compte.Checked;
            CheckCommencerPossible();
        }

        private void CB_2Compte_CheckedChanged(object sender, EventArgs e)
        {
            Compte2 = CB_2Compte.Checked;
            CheckCommencerPossible();
        }

        private void BTN_Commencer_Click(object sender, EventArgs e)
        {

        }
    }
}
