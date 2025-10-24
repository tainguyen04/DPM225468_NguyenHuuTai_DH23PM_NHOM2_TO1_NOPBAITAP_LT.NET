using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bai7_5
{
    public partial class Form1 : Form
    {
        private Point startPoint;
        private Point endPoint;
        private bool isDrawing = false;

        private Color borderColor = Color.Blue;
        private Color fillColor = Color.Red;
        private int borderSize = 2;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboShape.Items.AddRange(new string[] {
                "Line",
                "Rectangle",
                "Ellipse",
                "Filled Rectangle",
                "Filled Ellipse"
            });
            cboShape.SelectedIndex = 0;
            pnlBorderColor.BackColor = borderColor;
            pnlFillColor.BackColor = fillColor;
            txtSize.Text = borderSize.ToString();
        }

        private void pnlBorderColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog cd = new ColorDialog())
            {
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    borderColor = cd.Color;
                    pnlBorderColor.BackColor = cd.Color;
                }
            }
        }

        private void pnlFillColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog cd = new ColorDialog())
            {
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    fillColor = cd.Color;
                    pnlFillColor.BackColor = cd.Color;
                }
            }
        }

        private void pnlDraw_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                startPoint = e.Location;
                isDrawing = true;
            }
        }

        private void pnlDraw_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                endPoint = e.Location;
                isDrawing = false;

                using (Graphics g = pnlDraw.CreateGraphics())
                {
                    Pen pen = new Pen(borderColor, borderSize);
                    Brush brush = new SolidBrush(fillColor);
                    int x = Math.Min(startPoint.X, endPoint.X);
                    int y = Math.Min(startPoint.Y, endPoint.Y);
                    int w = Math.Abs(endPoint.X - startPoint.X);
                    int h = Math.Abs(endPoint.Y - startPoint.Y);

                    switch (cboShape.SelectedItem.ToString())
                    {
                        case "Line":
                            g.DrawLine(pen, startPoint, endPoint);
                            break;
                        case "Rectangle":
                            g.DrawRectangle(pen, x, y, w, h);
                            break;
                        case "Ellipse":
                            g.DrawEllipse(pen, x, y, w, h);
                            break;
                        case "Filled Rectangle":
                            g.FillRectangle(brush, x, y, w, h);
                            g.DrawRectangle(pen, x, y, w, h);
                            break;
                        case "Filled Ellipse":
                            g.FillEllipse(brush, x, y, w, h);
                            g.DrawEllipse(pen, x, y, w, h);
                            break;
                    }
                }
            }
        }

        private void txtSize_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtSize.Text, out int s))
                borderSize = s;
        }
    }
}
