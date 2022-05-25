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
        private int karte_breite = 130;
        private int karte_hoehe = 181;
        public int karte_offset = 136;
        public bool gewaehlt;




        /// <summary>
        /// Erstelle neue Karte mit Wert w und Farbe f
        /// </summary>
        /// <param name="w">Kartenwert in Zahlen von 7-14, wobei 11 als Bube, 12 als Dame, 13 als König und 14 als Ass fungiert</param> 
        /// <param name="f">Folgende Farben existieren: Karo, Herz, Pik und Kreuz</param>
        public Karte(Kartenwert kartenwert, Kartenfarbe kartenfarbe)
        {
            wert = kartenwert;   
            farbe = kartenfarbe;
            newImage = Image.FromFile("../../Kartenbilder/" + farbe + "-" + wert + ".jpg");

        }
        
        public Kartenwert getWert()
        {
            return wert;
        }

        public Kartenfarbe getFarbe()
        {
            return farbe;
        }
        public void DrawImage(PaintEventArgs e, Panel p, int x_offset)
        {

            // Create rectangle for displaying image.
            Rectangle destRect = new Rectangle(x_offset, 0, karte_breite, karte_hoehe);

            // Create coordinates of rectangle for source image.
            float x = 0;
            float y = 0;
            float width = karte_breite;
            float height = karte_hoehe;
            gewaehlt = false;
            GraphicsUnit units = GraphicsUnit.Pixel;

            // Draw image to screen.
            e.Graphics.DrawImage(newImage, destRect, x, y, width, height, units);
        }
        public int getBreite()
        {
            return karte_breite;
        }
        public int getHoehe()
        {
            return karte_hoehe;
        }
        public bool getGewaehlt()//Gibt zurück ob Karte gewählt ist oder nicht
        {
            return gewaehlt;
        }
        public void setGewaehlt(bool a)//Wählt gewählte Karten ab und nichtgewählte Karten uas
        {
            if(a == false)
            {
                gewaehlt=true;
            }
            else
            {
                gewaehlt=false;
            }
        }
        
    }
}
