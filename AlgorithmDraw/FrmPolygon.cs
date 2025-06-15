using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgorithmDraw
{
    public partial class FrmPolygon : Form
    {
        private Bitmap canvasBitmap;
        private Polygon polygon = new Polygon();
        public FrmPolygon()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!polygon.ReadData(txtRadio, txtNumLados))
            {
                return;
            }
            using (Graphics g = Graphics.FromImage(canvasBitmap))
            {
                polygon.PlotShape(g, picCanvas);
            }
            picCanvas.Invalidate();
        }

        private void FrmPolygon_Load(object sender, EventArgs e)
        {
            polygon.InitializeData(txtRadio, txtNumLados, picCanvas);
            canvasBitmap = new Bitmap(picCanvas.Width, picCanvas.Height);
            picCanvas.Image = canvasBitmap;
            picCanvas.Invalidate();
        }

        private void btnResetear_Click(object sender, EventArgs e)
        {
            polygon.InitializeData(txtRadio, txtNumLados, picCanvas);
            // Limpiar el bitmap 
            using (Graphics g = Graphics.FromImage(canvasBitmap))
            {
                g.Clear(Color.Black); // Borra el contenido
            }

            picCanvas.Invalidate(); // Fuerza repintado
            lblInfoPoints.Enabled = false;
            lblTotalPoints.Visible = false;
        }

        private void picCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            Color target = canvasBitmap.GetPixel(e.X, e.Y);
            polygon.FloodFill(new Point(e.X, e.Y), canvasBitmap, target, Color.Lime, picCanvas);
            picCanvas.Invalidate();
            lstPoints.Items.Clear();
            List<Point> points = new List<Point>(polygon.GetPixels()); // convertir de Stack a List
            foreach (Point pt in points)
            {
                lstPoints.Items.Add($"({pt.X}, {pt.Y})");
            }
            lblInfoPoints.Enabled = true;
            lblTotalPoints.Visible = true;
            lblTotalPoints.Text = "Total: " + lstPoints.Items.Count.ToString();
        }

        private void txtNumLados_Enter(object sender, EventArgs e)
        {
            lblInfoSide.Enabled = true;
        }

        private void txtNumLados_Leave(object sender, EventArgs e)
        {
            lblInfoSide.Enabled = false;
        }
    }
}
