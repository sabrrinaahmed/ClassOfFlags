using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;
using System.Resources;
using System.Windows.Forms.VisualStyles;

namespace sidehelp
{
    class Flags
    {
        public void TexasFlag(PictureBox pictureBox1, Rectangle ClientRectangle)
        {
            Graphics g = pictureBox1.CreateGraphics();

            //Fill Red
            SolidBrush fillRed = new SolidBrush(Color.DarkRed);          
            g.FillRectangle(fillRed, 20, 95, 250, 75);

            //Fill Blue
            SolidBrush fillBlue = new SolidBrush(Color.DarkBlue);           
            g.FillRectangle(fillBlue, 20, 20, 80, 150);

            //Star
            g.SmoothingMode = SmoothingMode.HighQuality;
            // init 4 stars
            PointF[] Star1 = Calculate5StarPoints(new PointF(60f, 95f), 20f, 8f);
            SolidBrush FillBrush = new SolidBrush(Color.White);
            g.FillPolygon(FillBrush, Star1);


            //Outlines
            g.DrawRectangle(new Pen(Color.DarkBlue, 2), 20, 20, 80, 150);   //Blue
            g.DrawRectangle(new Pen(Color.Black, 2), 20, 20, 250, 150);     //Black
        }

        public void AmericaFlag(PictureBox pictureBox1, Rectangle ClientRectangle)
        {
            Graphics g = pictureBox1.CreateGraphics();
            ClientRectangle.X = 20;
            ClientRectangle.Y = 20;
            ClientRectangle.Width = 115;
            ClientRectangle.Height = 81;


            //Red and White Strips
            g.SmoothingMode = SmoothingMode.AntiAlias;
            float recX = 20f;
            float recY = 20f;
            const int recWidth = 250;
            const float recHeight = 11.53846153846154f;
            SolidBrush sb = new SolidBrush(Color.DarkRed);
            Pen pen = new Pen(Color.DarkRed);

            for (int i = 0; i<13; i++)
            {
                g.FillRectangle(sb, recX, recY, recWidth, recHeight);
                g.DrawRectangle(pen, recX, recY, recWidth, recHeight);
                recY += 11.53846153846154f;
                if (i % 2 == 0)
                {
                    sb = new SolidBrush(Color.White);
                    pen = new Pen(Color.White);
                }
                if (i % 2 != 0)
                {
                    sb = new SolidBrush(Color.DarkRed);
                    pen = new Pen(Color.DarkRed);
                }

            }

            //Blue
            SolidBrush sbBlue = new SolidBrush(Color.DarkBlue);
            g.FillRectangle(sbBlue, 20, 20, 115, 80.769f);
            g.DrawRectangle(new Pen(Color.DarkBlue), 20, 20, 115, 80.769f);

            //White Stars
            int x = 25;
            int y;
            for(int j = 0; j<11; j++)
            {
                if(j % 2 == 0)
                {
                    y = 27;
                    //5 Vertical Stars
                    for (int i = 0; i < 5; i++)
                    {
                        PointF[] Star1 = Calculate5StarPoints(new PointF(x, y), 5f, 2f);
                        SolidBrush FillBrush = new SolidBrush(Color.White);
                        g.FillPolygon(FillBrush, Star1);
                        y += 16;
                    }
                    x += 10;
                }
                if(j % 2 != 0)
                {
                    y = 35;
                    //4 Vertical Stars
                    for (int k = 0; k < 4; k++)
                    {
                        PointF[] Star1 = Calculate5StarPoints(new PointF(x, y), 5f, 2f);
                        SolidBrush FillBrush = new SolidBrush(Color.White);
                        g.FillPolygon(FillBrush, Star1);
                        y += 16;

                    }
                    x += 10;
                }

            }

            //Outline Black
            g.DrawRectangle(new Pen(Color.Black, 2), 20, 20, 250, 150);     

        }

        public void TurkeyFlag(PictureBox pictureBox1, Rectangle ClientRectangle)
        {
            Graphics g = pictureBox1.CreateGraphics();
            ClientRectangle.X = 60;
            ClientRectangle.Y = 60;
            ClientRectangle.Width = pictureBox1.Width - 200 ;
            ClientRectangle.Height = pictureBox1.Height - 140 ;

            //Red Background
            SolidBrush sb = new SolidBrush(Color.Red);
            g.FillRectangle(sb, 20, 20, 250, 150);

            //Cresent
            SolidBrush sbWhite = new SolidBrush(Color.White);
            SolidBrush sbRed = new SolidBrush(Color.Red);
            g.FillEllipse(sbWhite, ClientRectangle);

            ClientRectangle.X = 80;
            ClientRectangle.Y = 65;
            ClientRectangle.Width = pictureBox1.Width - 215;
            ClientRectangle.Height = pictureBox1.Height - 150;
            g.FillEllipse(sbRed, ClientRectangle);

            //Star
            g.RotateTransform(50.0F);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            ////PointF[] pts = StarPoints(5, ClientRectangle, 169, -47, 14, 14);
            //g.DrawPolygon(Pens.White, pts);
            //SolidBrush fillWhite = new SolidBrush(Color.White);
            //g.FillPolygon(fillWhite, pts);

            PointF[] Star1 = Calculate5StarPoints(new PointF(169f, -47f), 15f, 6f);
            SolidBrush FillBrush = new SolidBrush(Color.White);
            g.FillPolygon(FillBrush, Star1);


            //Outline Black
            g.RotateTransform(-50.0F);
            g.DrawRectangle(new Pen(Color.Black, 2), 20, 20, 250, 150);
        }

        public void UKFlag(PictureBox pictureBox1, Rectangle ClientRectangle)
        {
            Graphics g = pictureBox1.CreateGraphics();
            SolidBrush sbBlue = new SolidBrush(Color.DarkBlue);
            SolidBrush sbRed = new SolidBrush(Color.Red);
            SolidBrush sbWhite = new SolidBrush(Color.White);

            //Blue Background
            g.FillRectangle(sbBlue, 20, 20, 250, 150);

            //Top Left White and Red
            g.RotateTransform(30.0f);
            g.FillRectangle(sbWhite, 20, -1, 300, 25);
            g.FillRectangle(sbRed, 20, 11, 150, 7);
            g.FillRectangle(sbRed, 178, 4, 150, 7);
            g.RotateTransform(-30.0f);

            //Top Right White and Red
            g.RotateTransform(-30.0f);
            g.FillRectangle(sbWhite, -72, 142, 300, 25);
            g.FillRectangle(sbRed, 73, 148, 150, 7);
            g.FillRectangle(sbRed, -72, 153, 150, 7);
            g.RotateTransform(30.0f);

            //Vertical and Horizontal White
            g.FillRectangle(sbWhite, 122, 20, 45, 150);
            g.FillRectangle(sbWhite, 20, 75, 270, 45);

            //Vertical and Horizontal Red
            g.FillRectangle(sbRed, 132, 20, 25, 150);
            g.FillRectangle(sbRed, 20, 84, 250, 25);

            //Outline Black and White
            g.DrawRectangle(new Pen(Color.White, 25), 6, 6, 275, 175);
            g.DrawRectangle(new Pen(Color.Black, 2), 20, 20, 250, 150);

        }

        public void GreeceFlag(PictureBox pictureBox1, Rectangle ClientRectangle)
        {
            Graphics g = pictureBox1.CreateGraphics();
            const int x = 20;
            float y = 20;
            SolidBrush sbBlue = new SolidBrush(Color.DodgerBlue);
            SolidBrush sbWhite = new SolidBrush(Color.White);

            //Horizontal Blue and White
            for (int i = 0; i < 9; i++)
            {
                if(i % 2 == 0)
                {
                    g.FillRectangle(sbBlue, x, y, 250, 16.67f);
                    y += 16.67f;
                }
                if(i % 2 != 0)
                {
                    g.FillRectangle(sbWhite, x, y, 250, 16.67f);
                    y += 16.67f;
                }
            }

            //Blue Box
            g.FillRectangle(sbBlue, 20, 20, 115, 80.769f);
            g.FillRectangle(sbWhite, 70, 20, 16.67f, 84);
            g.FillRectangle(sbWhite, 20, 53.34f, 115, 16.67f); 


            g.DrawRectangle(new Pen(Color.Black, 2), 20, 20, 250, 150);
        }
        //Algorithm for Stars
        private PointF[] Calculate5StarPoints(PointF Orig, float outerradius, float innerradius)
        {
            // Define some variables to avoid as much calculations as possible
            // conversions to radians
            double Ang36 = Math.PI / 5.0;   // 36Â° x PI/180
            double Ang72 = 2.0 * Ang36;     // 72Â° x PI/180
            // some sine and cosine values we need
            float Sin36 = (float)Math.Sin(Ang36);
            float Sin72 = (float)Math.Sin(Ang72);
            float Cos36 = (float)Math.Cos(Ang36);
            float Cos72 = (float)Math.Cos(Ang72);
            // Fill array with 10 origin points
            PointF[] pnts = { Orig, Orig, Orig, Orig, Orig, Orig, Orig, Orig, Orig, Orig };
            pnts[0].Y -= outerradius;  // top off the star, or on a clock this is 12:00 or 0:00 hours
            pnts[1].X += innerradius * Sin36; pnts[1].Y -= innerradius * Cos36; // 0:06 hours
            pnts[2].X += outerradius * Sin72; pnts[2].Y -= outerradius * Cos72; // 0:12 hours
            pnts[3].X += innerradius * Sin72; pnts[3].Y += innerradius * Cos72; // 0:18
            pnts[4].X += outerradius * Sin36; pnts[4].Y += outerradius * Cos36; // 0:24 
            // Phew! Glad I got that trig working.
            pnts[5].Y += innerradius;
            // I use the symmetry of the star figure here
            pnts[6].X += pnts[6].X - pnts[4].X; pnts[6].Y = pnts[4].Y;  // mirror point
            pnts[7].X += pnts[7].X - pnts[3].X; pnts[7].Y = pnts[3].Y;  // mirror point
            pnts[8].X += pnts[8].X - pnts[2].X; pnts[8].Y = pnts[2].Y;  // mirror point
            pnts[9].X += pnts[9].X - pnts[1].X; pnts[9].Y = pnts[1].Y;  // mirror point
            return pnts;
        }
    }
}
