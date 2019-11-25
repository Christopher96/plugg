using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace lab5
{
    class Ball : Label
    {
        // Globala variabler för klassen
        public static double gravity = 0;
        public static int collissions = 0;
        public double speedX, speedY;
        public double posX, posY;

        // Konstruktor som tar en bild för att skapa en boll
        public Ball(Image image)
        {
            // Sätter transparent bakgrund, storlek och synlighet
            Image = image;
            BackColor = Color.Transparent;
            Size = new Size(50, 50);
            Visible = true;
        }
    }
}
