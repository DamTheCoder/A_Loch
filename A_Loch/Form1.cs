using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_Loch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }

        private void picBoxP8_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Karte herzsieben = new Karte(Kartenwert.Sieben, Kartenfarbe.Herz);
            //herzsieben.DrawImage(e, picBoxK11);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Karte herzsieben = new Karte(Kartenwert.Sieben, Kartenfarbe.Herz);
            herzsieben.DrawImage(e, panel1, 0);
            Karte kreuzkoenig = new Karte(Kartenwert.Koenig, Kartenfarbe.Kreuz);
            kreuzkoenig.DrawImage(e, panel1, 136);
        }
    }
}
