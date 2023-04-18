using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawStringWrapped
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Rectangle rect = new Rectangle(10, 10, 200, 200);
            e.Graphics.FillRectangle(Brushes.SaddleBrown, rect);
            rect.Inflate(-10, -10);
            string text = @"A particular Bible passage, sometimes a single verse or verse fragment 
Textbook, a standardized instructional book 
in electronic communication and computing";

            var format = new StringFormat(StringFormatFlags.DirectionVertical);
            e.Graphics.DrawString(text, this.Font, Brushes.Pink, rect, format);
        }
    }
}
