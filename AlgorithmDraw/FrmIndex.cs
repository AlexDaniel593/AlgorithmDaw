using System;
using System.Drawing;
using System.Windows.Forms;

namespace AlgorithmDraw
{
    public partial class FrmIndex : Form
    {
        private string textWelcome = "Welcome to AlgorithmDraw";
        private string textName = "Developed by Daniel Guaman";

        private int indexWelcome = 0;
        private int indexName = 0;

        private Timer timerWelcome;
        private Timer timerName;

        public FrmIndex()
        {
            this.Load += FrmIndex_Load;
            InitializeComponent();
            SetFontRecursive(this, new Font("Consolas", 11F));
        }

        private void SetFontRecursive(Control control, Font font)
        {
            control.Font = font;
            control.ForeColor = Color.Lime;
            control.BackColor = Color.Black;

            foreach (Control child in control.Controls)
            {
                SetFontRecursive(child, font);
            }
        }

        private void OpenForm(Form formulario)
        {
            panelContenedor.Controls.Clear();
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(formulario);
            formulario.Show();
        }

        private void dDAToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            OpenForm(new FrmAlgorithmDDA());
            this.Text = "DDA Algorithm";
        }

        private void bresenhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmAlgorithmBresenham());
            this.Text = "Bresenham Algorithm";
        }

        private void circleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmAlgorithmCircle());
            this.Text = "Circle Algorithm";
        }

        private void floodFillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm(new FrmPolygon());
            this.Text = "Flood Fill Algorithm";
        }

        private void FrmIndex_Load(object sender, EventArgs e)
        {
            // Configurar y centrar los labels
            lblWelcome.Text = "";
            lblName.Text = "";
            CenterLabel(lblWelcome, 100);
            CenterLabel(lblName, 150);

            // Configurar el Timer para lblWelcome
            timerWelcome = new Timer();
            timerWelcome.Interval = 80;
            timerWelcome.Tick += TimerWelcome_Tick;
            timerWelcome.Start();

            // Configurar el Timer para lblName
            timerName = new Timer();
            timerName.Interval = 80;
            timerName.Tick += TimerName_Tick;
        }

        private void TimerWelcome_Tick(object sender, EventArgs e)
        {
            if (indexWelcome < textWelcome.Length)
            {
                lblWelcome.Text += textWelcome[indexWelcome++];
                CenterLabel(lblWelcome, 100);
            }
            else
            {
                timerWelcome.Stop();
                timerName.Start(); // Iniciar segundo texto al terminar el primero
            }
        }

        private void TimerName_Tick(object sender, EventArgs e)
        {
            if (indexName < textName.Length)
            {
                lblName.Text += textName[indexName++];
                CenterLabel(lblName, 150);
            }
            else
            {
                timerName.Stop();
            }
        }

        private void CenterLabel(Label lbl, int top)
        {
            lbl.Left = (this.ClientSize.Width - lbl.Width) / 2;
            lbl.Top = top;
            lbl.Anchor = AnchorStyles.Top;
        }

        
    }
}
