using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R09725060HSHunagAss11
{
    public partial class MainForm : Form
    {
        FourBarLinkage myLinkage;
        public MainForm()
        {
            InitializeComponent();
            myLinkage = new FourBarLinkage();
            //ppgLinkage.SelectedObject = myLinkage;
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
            object[] pars = { ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true };
            MethodInfo mm= typeof(Panel).GetMethod("SetStyle", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            mm.Invoke(spcMain.Panel2, pars);
        }

        private void btnCalculation_Click(object sender, EventArgs e)
        {
            double delta = (double)nudDeltaAngle.Value;
            double limit = Math.PI * 2;
            rtbOutput.Clear();
            for (double angle = 0.0; angle <= limit; angle += delta)
            {
                myLinkage.updateConfiguration(angle);
                rtbOutput.AppendText(myLinkage.ToString());
                rtbOutput.AppendText("\n");
            }

        }

        /*private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = button1.CreateGraphics();
            Draw(g, button1.ClientRectangle);
            g = spcMain.Panel2.CreateGraphics();
            Draw(g, spcMain.Panel2.ClientRectangle);

            Rectangle rect = new Rectangle(10, 5, 100, 50);
            //rect.Width = 100;
            //rect.Height = 50;
            //rect.X = 10;
            //rect.Y = 5;
            g.FillEllipse(Brushes.Gold, rect);
            g.DrawEllipse(Pens.Red, rect);
            Point p1 = new Point(0, 0);
            Point p2 = new Point(button1.Width, button1.Height);
            Pen myPen = new Pen(Color.Blue, 10.0f);
            g.DrawLine(myPen, p1, p2);
            g.DrawString("NTU", this.Font, Brushes.Magenta, 0, 0);
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;//橫向的
            sf.LineAlignment = StringAlignment.Center;
            g.DrawString("機械系", this.Font,Brushes.Maroon,rect,sf);
            Font myFont = new Font("微軟正黑體", 36);
            g.DrawString("機械系", myFont, Brushes.Maroon, button1.ClientRectangle, sf);


        }*/

        /*void Draw(Graphics g, Rectangle bound)
        {
            Rectangle rect = new Rectangle(10, 5, 100, 50);
            //rect.Width = 100;
            //rect.Height = 50;
            //rect.X = 10;
            //rect.Y = 5;
            g.FillEllipse(Brushes.Gold, rect);
            g.DrawEllipse(Pens.Red, rect);
            Point p1 = new Point(0, 0);
            //Point p2 = new Point(bound.Width, button1.Height);
            Pen myPen = new Pen(Color.Blue, 10.0f);
            g.DrawLine(myPen, p1, p2);
            g.DrawString("NTU", this.Font, Brushes.Magenta, 0, 0);
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;//橫向的
            sf.LineAlignment = StringAlignment.Center;
            g.DrawString("機械系", this.Font, Brushes.Maroon, rect, sf);
            Font myFont = new Font("微軟正黑體", 36);
            g.DrawString("機械系", myFont, Brushes.Maroon, bound, sf);
        }*/

        private void spcMain_Panel2_Paint(object sender, PaintEventArgs e)
        {
            //Draw(e.Graphics, e.ClipRectangle);
            if(myLinkage!=null)
            {
                myLinkage.DrawLinkage(e.Graphics, e.ClipRectangle);
                //draw all pois point
                Rectangle r = new Rectangle(0, 0, 6, 6);
                foreach(Point pt in POIs)
                {
                    r.X = pt.X - 3;
                    r.Y = pt.Y - 3;
                    e.Graphics.DrawRectangle(Pens.DarkGray, r);
                }
            }
            labWarning.Text = myLinkage.Warnning;
                
        }

        List<Point> POIs = new List<Point>();

        float currentAngle = 0;
        private void tmrAnimation_Tick(object sender, EventArgs e)
        {
            myLinkage.updateConfiguration(currentAngle);
            if(chbtrajectory.Checked)
                POIs.Add(myLinkage.PointOfInterest);

            if (rdbFast.Checked)
                currentAngle += 0.4f;
            else if (rdbSlow.Checked)
                currentAngle += 0.05f;
            else
                currentAngle += 0.2f;
            spcMain.Panel2.Refresh();
        }

        private void btnAnimation_Click(object sender, EventArgs e)
        {
            tmrAnimation.Enabled = !tmrAnimation.Enabled;
            if (tmrAnimation.Enabled)
                btnAnimation.Text = "Stop";
            else
                btnAnimation.Text = "Animate";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            POIs.Clear();
            spcMain.Panel2.Refresh();
        }

        private void tbGroundLength_Scroll(object sender, EventArgs e)
        {
            labGoundLength.Text = tbGroundLength.Value.ToString();
            myLinkage.GroundLength = tbGroundLength.Value;
            tbGroundLength.Value = (int)myLinkage.GroundLength;
            labGoundLength.Text = tbGroundLength.Value.ToString();
        }

        private void tbConnectorLength_Scroll(object sender, EventArgs e)
        {
            labConnectorLength.Text = tbConnectorLength.Value.ToString();
            myLinkage.ConnectorLength = tbConnectorLength.Value;
            tbConnectorLength.Value = (int)myLinkage.ConnectorLength;
            labConnectorLength.Text = tbConnectorLength.Value.ToString();
            spcMain.Panel2.Refresh();
            //labWarning.Text = myLinkage.Warnning;
        }

        private void tbDriverLength_Scroll(object sender, EventArgs e)
        {
            labDriverLength.Text = tbDriverLength.Value.ToString();
            myLinkage.DriverLength = tbDriverLength.Value;
            tbDriverLength.Value = (int)myLinkage.DriverLength;
            labDriverLength.Text = tbDriverLength.Value.ToString();
            spcMain.Panel2.Refresh();
            labWarning.Text = myLinkage.Warnning;
        }

        private void tbFollwerLength_Scroll(object sender, EventArgs e)
        {
            labFollowerLength.Text = tbFollowerLength.Value.ToString();
            myLinkage.FollowerLength = tbFollowerLength.Value;
            tbFollowerLength.Value = (int)myLinkage.FollowerLength;
            labFollowerLength.Text = tbFollowerLength.Value.ToString();
            spcMain.Panel2.Refresh();
            labWarning.Text = myLinkage.Warnning;
        }

        private void tbPOIAxialOffsets_Scroll(object sender, EventArgs e)
        {
            labPOIAxialOffsets.Text = tbPOIAxialOffsets.Value.ToString();
            myLinkage.POIAxialOffset = tbPOIAxialOffsets.Value;
            tbPOIAxialOffsets.Value = (int)myLinkage.POIAxialOffset;
            labPOIAxialOffsets.Text = tbPOIAxialOffsets.Value.ToString();
            labWarning.Text = myLinkage.Warnning;
        }

        private void tbPOIRaiaOffsets_Scroll(object sender, EventArgs e)
        {
            labPOIRadialOffsets.Text = tbPOIRaialOffsets.Value.ToString();
            myLinkage.POIRadialOffset = tbPOIRaialOffsets.Value;
            tbPOIRaialOffsets.Value = (int)myLinkage.POIRadialOffset;
            labPOIRadialOffsets.Text = tbPOIRaialOffsets.Value.ToString();
            spcMain.Panel2.Refresh();
            labWarning.Text = myLinkage.Warnning;
        }
    }
}
