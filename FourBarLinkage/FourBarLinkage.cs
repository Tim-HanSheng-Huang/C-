using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R09725060HSHunagAss11
{
    class FourBarLinkage
    {
        double scale;
        int xoff, yoff;

        public Point PointOfInterest
        {
            get { return TransformPoint(Pp); }
        }

        public void DrawLinkage(Graphics g, Rectangle bound)
        {
            // Update xoffset, yoffset and scale with respect to the rectangle
            scale = bound.Width / (Lc + Lf + Lg) * 1.1;
            xoff = (int)(Ld * scale * 2.0f);
            yoff = (int)(bound.Height / 3.0f);
            // set screen points
            Point s1, s2, sc, sf, sp;
            s1 = TransformPoint(P1);
            s2 = TransformPoint(P2); 
            sc = TransformPoint(Pc); 
            sf = TransformPoint(Pf); 
            sp = TransformPoint(Pp);
            // Draw 6 lines
            float penWidth = bound.Height / 40;
            Pen myPen = new Pen(Color.Green, penWidth);
            myPen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            myPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            g.DrawLine(myPen, s1, sc);
            myPen.Color = Color.Red;
            g.DrawLine(myPen, s1, s2);
            myPen.Color = Color.Yellow;
            g.DrawLine(myPen, s2, sf);
            myPen.Color = Color.Blue;
            g.DrawLine(myPen, sc, sf);
            g.DrawLine(myPen, sc, sp);
            g.DrawLine(myPen, sp, sf);


        }

        Point TransformPoint(PointF pt)
        {
            Point p = Point.Empty;
            p.X = (int)(xoff + pt.X * scale);
            p.Y = (int)(yoff + pt.Y * scale);
            return p;
        }

        double Lg = 20.0;
        double Ld = 10.0;
        double Lc = 35.0;
        double Lf = 25.0;
        double Da = 17.0;
        double Db = 5.0;
        double alpha = 1.0;
        string warnning = "";

        public string Warnning
        {
            get => warnning;
        }


        public override string ToString()
        {
            return $"Angle={alpha:0.00},P1=({P1.X},{P1.Y}),P2=({P2.X},{P2.Y}),Pc=({Pc.X:0.00},{Pc.Y:0.00}),Pf=({Pf.X:0.00},{Pf.Y:0.00}),Pp=({Pp.X:0.00},{Pp.Y:0.00})";
        }

        public FourBarLinkage()
        {
            updateConfiguration(alpha);
        }


        PointF P1=new PointF(0,0), P2, Pc, Pf, Pp;

        [Category("連桿結構")]
        public double POIAxialOffset
        {
            get => Da;
            set
            {
                Da = value;
            }
        }

        [Category("連桿結構")]
        public double POIRadialOffset
        {
            get => Db;
            set
            {
                Db = value;
            }
        }

        [Category("連桿結構"),Description("固定桿的長度")]
        public double GroundLength
        {
            get => Lg;

            set
            {
                double originalLength = Lg;
                Lg = value;
                if (!isQuadrilateralFeasible())
                {
                    Lg = originalLength;
                    warnning = "Invalid Value";
                }
                else
                    warnning = "";

            }
        }

        [Category("連桿結構"),Description("驅動桿的長度")]
        public double DriverLength
        {
            get => Ld;

            set
            {
                double originalLength = Ld;
                Ld = value;
                if (!isQuadrilateralFeasible())
                {
                    Ld = originalLength;
                    warnning = "Invalid Value";
                }
                else
                    warnning = "";

            }
        }

        [Category("連桿結構"),Description("連接桿的長度")]
        public double ConnectorLength
        {
            get => Lc;

            set
            {
                double originalLength = Lc;
                Lc = value;
                if (!isQuadrilateralFeasible())
                {
                    Lc = originalLength;
                    warnning = "Invalid Value";
                }
                else
                    warnning = "";

            }
        }

        [Category("連桿結構"),Description("被動桿的長度")]
        public double FollowerLength
        {
            get => Lf;

            set
            {
                double originalLength = Lf;
                Lf = value;
                if (!isQuadrilateralFeasible())
                {
                    Lf = originalLength;
                    warnning = "Invalid Value";
                }
                else
                    warnning = "";

            }
        }


        bool isQuadrilateralFeasible()
        {
            if (Lg > Ld + Lc + Lf || Ld > Lc + Lf + Lg || Lc > Lf + Lg + Ld || Lf > Lg + Ld + Lc)
                return false;
            return true;
        }

        //if the configuration of the linkage for newAlpha angle is
        //feasible return true and update current alpha
        public bool updateConfiguration(double newAlpha)
        {
            P2.X = (float)Lg;
            P2.Y = 0.0f;
            Pc.X = (float)(Ld * Math.Cos(newAlpha));
            Pc.Y = (float)(Ld * Math.Sin(newAlpha));

            float L;
            L = (float)Math.Sqrt(Math.Pow((Lg - Pc.X), 2) + Math.Pow(Pc.Y, 2));
            if (Lf + Lc < L || L + Lc < L || L + Lf < Lc)
            {
                this.warnning = "Invalid value";
                return false;
            }

            alpha = newAlpha;

            // Calculate Pf.X, Pf.Y
            double omega;
            double theta;

            omega = Math.Acos((Math.Pow(Lf, 2) + Math.Pow(L, 2) - Math.Pow(Lc, 2)) / (2 * Lf * L));

            // Use Math.Atan2(delta y,delta x)
            theta = Math.Atan2(Pc.Y, (Pc.X - Lg)) - omega;

            Pf.X = (float)(Lf * Math.Cos(theta) + Lg);
            Pf.Y = (float)(Lf * Math.Sin(theta));

            float unitX, unitY;

            unitX = (float)((Pf.X - Pc.X) / Math.Sqrt(Math.Pow(Pf.X - Pc.X, 2) + Math.Pow(Pf.Y - Pc.Y, 2)));
            unitY = (float)((Pf.Y - Pc.Y) / Math.Sqrt(Math.Pow(Pf.X - Pc.X, 2) + Math.Pow(Pf.Y - Pc.Y, 2)));

            Pp.X = Pc.X + (float)(unitX * Da - unitY * Db);
            Pp.Y = Pc.Y + (float)(unitY * Da + unitX * Db);

            return true;
        }

    }
}
