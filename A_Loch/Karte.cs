using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace A_Loch
{
    public class Karte
    {
        private Kartenwert wert;
        private Kartenfarbe farbe;
        private Image newImage;


         

        /// <summary>
        /// Erstelle neue Karte mit Wert w und Farbe f
        /// </summary>
        /// <param name="w">Kartenwert in Zahlen von 7-14, wobei 11 als Bube, 12 als Dame, 13 als König und 14 als Ass fungiert</param> 
        /// <param name="f">Folgende Farben existieren: Karo, Herz, Pik und Kreuz</param>
        public Karte(Kartenwert kartenwert, Kartenfarbe kartenfarbe)
        {
            wert = kartenwert;   
            farbe = kartenfarbe;
            newImage = Image.FromFile("H:/A_Loch/A_Loch/A_Loch/Kartenbilder/" + farbe + "-" + wert + ".jpg");
        }
        public void KarteZeichnen(Graphics g)
        {
            
        }
        public Kartenwert getWert()
        {
            return wert;
        }

        public Kartenfarbe getFarbe()
        {
            return farbe;
        }
        public void DrawImage(PaintEventArgs e, PictureBox p)
        {

            // Create rectangle for displaying image.
            Rectangle destRect = new Rectangle(140, 0, 130, 181);

            // Create coordinates of rectangle for source image.
            float x = 0;
            float y = 0;
            float width = 130;
            float height = 181;
            GraphicsUnit units = GraphicsUnit.Pixel;

            // Draw image to screen.
            e.Graphics.DrawImage(newImage, destRect, x, y, width, height, units);
        }

    }
}
