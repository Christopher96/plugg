using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace lab5
{
    class Goal : Label
    {
        public Goal(Image image)
        {
            // Sätter transparent bakgrund, storlek och synlighet
            Image = image;
            BackColor = Color.Transparent;
            Size = new Size(50, 50);
            Visible = true;
        }
    }
}
