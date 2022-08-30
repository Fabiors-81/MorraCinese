using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MorraCinese
{
    public partial class Form_MorraCinese : Form
    {
        public Form_MorraCinese()
        {
            InitializeComponent();
        }
        private string SceltaGiocatore1 = "";
        private string SceltaGiocatore2 = "";
        private int PunteggioGiocatore1 = 0;
        private int PunteggioGiocatore2 = 0;
        private void Form_MorraCinese_Load(object sender, EventArgs e)
        {
            //this.Width = 575;
            //this.Height = 355;
            this.ClientSize = new Size(400, 280);
            panel_Start.Dock = DockStyle.Fill;
            panel_1Giocatore.Dock = DockStyle.Fill;
            panel_1Giocatore.Visible = false;
        }

        private void btn_1Giocatore_Click(object sender, EventArgs e)
        {
            panel_Start.Visible = false;
            panel_1Giocatore.Visible = true;
        }

        private void btn_Successivo_Click(object sender, EventArgs e)
        {
            switch (pict_Giocatore1.Tag)
            {
                case "carta":
                    pict_Giocatore1.BackgroundImage = Properties.Resources.sasso;
                    pict_Giocatore1.Tag = "sasso";
                    lbl_SceltaGiocatore1.Text= pict_Giocatore1.Tag.ToString();
                    break;
                case "sasso":
                    pict_Giocatore1.BackgroundImage = Properties.Resources.forbice;
                    pict_Giocatore1.Tag = "forbice";
                    lbl_SceltaGiocatore1.Text = pict_Giocatore1.Tag.ToString();
                    break;
                case "forbice":
                    pict_Giocatore1.BackgroundImage = Properties.Resources.carta;
                    pict_Giocatore1.Tag = "carta";
                    lbl_SceltaGiocatore1.Text = pict_Giocatore1.Tag.ToString();
                    break;
                default:
                    pict_Giocatore1.BackgroundImage = Properties.Resources.carta;
                    pict_Giocatore1.Tag = "carta";
                    lbl_SceltaGiocatore1.Text = pict_Giocatore1.Tag.ToString();
                    break;
            }
        }
        #region PULSANTI SUCCESSIVO E PRECEDENTE
        private void btn_Precedente_Click(object sender, EventArgs e)
        {
            switch (pict_Giocatore1.Tag)
            {
                case "carta":
                    pict_Giocatore1.BackgroundImage = Properties.Resources.forbice;
                    pict_Giocatore1.Tag = "forbice";
                    lbl_SceltaGiocatore1.Text = pict_Giocatore1.Tag.ToString();
                    break;
                case "sasso":
                    pict_Giocatore1.BackgroundImage = Properties.Resources.carta;
                    pict_Giocatore1.Tag = "carta";
                    lbl_SceltaGiocatore1.Text = pict_Giocatore1.Tag.ToString();
                    break;
                case "forbice":
                    pict_Giocatore1.BackgroundImage = Properties.Resources.sasso;
                    pict_Giocatore1.Tag = "sasso";
                    lbl_SceltaGiocatore1.Text = pict_Giocatore1.Tag.ToString();
                    break;
                default:
                    pict_Giocatore1.BackgroundImage = Properties.Resources.forbice;
                    pict_Giocatore1.Tag = "carta";
                    lbl_SceltaGiocatore1.Text = pict_Giocatore1.Tag.ToString();
                    break;
            }
        }
        #endregion
    }
}