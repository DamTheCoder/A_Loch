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
        Spielleiter s1 = new Spielleiter();
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
            s1.kartengenerieren();
            s1.kartenmischeln();
            s1.kartenzuteilen();
            s1.spielerhinzufügen(txtBoxName.Text);
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //hier soll der Spielleiter zeichnen
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            MouseEventArgs evt = (MouseEventArgs)e;
            evt.Button = System.Windows.Forms.MouseButtons.Left;
            s1.getaktuellerspieler().kartenwaehlen(evt.X, evt.Y)
            //panel1_Click(evt.X, evt.Y);
            panel1.Invalidate();
        }

        private void txtBoxName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
