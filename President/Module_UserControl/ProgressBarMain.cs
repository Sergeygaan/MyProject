using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module_UserControl
{
    public class ProgressBarEx : ProgressBar
    {
        public ProgressBarEx()
        {
            SetStyle(ControlStyles.UserPaint, true);
        }

        protected override void OnPaintBackground(PaintEventArgs pevent) { }
        // None... Helps control the flicker.                

        protected override void OnPaint(PaintEventArgs e)
        {
            const int inset = 2; // A single inset value to control teh sizing of the inner rect.

            using (Image offscreenImage = new Bitmap(Width, Height))
            {
                using (Graphics offscreen = Graphics.FromImage(offscreenImage))
                {
                    Rectangle rect = new Rectangle(0, 0, Width, Height);

                    if (ProgressBarRenderer.IsSupported)
                    {
                        ProgressBarRenderer.DrawHorizontalBar(offscreen, rect);
                    }

                    rect.Inflate(new Size(-inset, -inset)); // Deflate inner rect.
                    rect.Width = (int)(rect.Width * ((double)Value / Maximum));

                    if (rect.Width != 0)
                    {
                        LinearGradientBrush brush = new LinearGradientBrush(rect, ForeColor, BackColor, LinearGradientMode.Vertical);
                        offscreen.FillRectangle(brush, inset, inset, rect.Width, rect.Height);
                        e.Graphics.DrawImage(offscreenImage, 0, 0);
                        offscreenImage.Dispose();
                    }
                }
            }
        }
    }
}
