﻿namespace FastColoredTextBoxNS
{
    using System.Drawing;
    using System.Windows.Forms;

    public class VisualMarker
    {
        public readonly Rectangle rectangle;

        public VisualMarker(Rectangle rectangle)
        {
            this.rectangle = rectangle;
        }

        public virtual System.Windows.Forms.Cursor Cursor
        {
            get
            {
                return Cursors.Hand;
            }
        }

        public virtual void Draw(Graphics gr, Pen pen)
        {
        }
    }
}