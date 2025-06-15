namespace AlgorithmDraw
{
    partial class FrmPolygon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnResetear = new System.Windows.Forms.Button();
            this.groupBoxPoints = new System.Windows.Forms.GroupBox();
            this.lstPoints = new System.Windows.Forms.ListBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.GBoxEntradas = new System.Windows.Forms.GroupBox();
            this.lblInfoSide = new System.Windows.Forms.Label();
            this.txtNumLados = new System.Windows.Forms.TextBox();
            this.lblSide = new System.Windows.Forms.Label();
            this.txtRadio = new System.Windows.Forms.TextBox();
            this.lblRadio = new System.Windows.Forms.Label();
            this.lblInfoPoints = new System.Windows.Forms.Label();
            this.lblTotalPoints = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBoxPoints.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.GBoxEntradas.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.lblInfoPoints);
            this.panel1.Controls.Add(this.btnResetear);
            this.panel1.Controls.Add(this.groupBoxPoints);
            this.panel1.Controls.Add(this.btnCalcular);
            this.panel1.Controls.Add(this.lblInfo);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.GBoxEntradas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(962, 473);
            this.panel1.TabIndex = 0;
            // 
            // btnResetear
            // 
            this.btnResetear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetear.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetear.ForeColor = System.Drawing.Color.Lime;
            this.btnResetear.Location = new System.Drawing.Point(149, 261);
            this.btnResetear.Name = "btnResetear";
            this.btnResetear.Size = new System.Drawing.Size(87, 33);
            this.btnResetear.TabIndex = 1;
            this.btnResetear.Text = "Clear";
            this.btnResetear.UseVisualStyleBackColor = true;
            this.btnResetear.Click += new System.EventHandler(this.btnResetear_Click);
            // 
            // groupBoxPoints
            // 
            this.groupBoxPoints.Controls.Add(this.lblTotalPoints);
            this.groupBoxPoints.Controls.Add(this.lstPoints);
            this.groupBoxPoints.ForeColor = System.Drawing.Color.Lime;
            this.groupBoxPoints.Location = new System.Drawing.Point(803, 12);
            this.groupBoxPoints.Name = "groupBoxPoints";
            this.groupBoxPoints.Size = new System.Drawing.Size(144, 426);
            this.groupBoxPoints.TabIndex = 53;
            this.groupBoxPoints.TabStop = false;
            this.groupBoxPoints.Text = "Points";
            // 
            // lstPoints
            // 
            this.lstPoints.BackColor = System.Drawing.Color.Black;
            this.lstPoints.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstPoints.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPoints.ForeColor = System.Drawing.Color.Lime;
            this.lstPoints.FormattingEnabled = true;
            this.lstPoints.ItemHeight = 22;
            this.lstPoints.Location = new System.Drawing.Point(6, 48);
            this.lstPoints.Name = "lstPoints";
            this.lstPoints.Size = new System.Drawing.Size(132, 374);
            this.lstPoints.TabIndex = 11;
            // 
            // btnCalcular
            // 
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.Lime;
            this.btnCalcular.Location = new System.Drawing.Point(40, 261);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(88, 33);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Draw";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.Lime;
            this.lblInfo.Location = new System.Drawing.Point(17, 448);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(384, 18);
            this.lblInfo.TabIndex = 52;
            this.lblInfo.Text = "Tip: Click on the area to apply the flood fill.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picCanvas);
            this.groupBox1.ForeColor = System.Drawing.Color.Lime;
            this.groupBox1.Location = new System.Drawing.Point(274, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 426);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Graphic:";
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(7, 22);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(497, 398);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            this.picCanvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseClick);
            // 
            // GBoxEntradas
            // 
            this.GBoxEntradas.Controls.Add(this.lblInfoSide);
            this.GBoxEntradas.Controls.Add(this.txtNumLados);
            this.GBoxEntradas.Controls.Add(this.lblSide);
            this.GBoxEntradas.Controls.Add(this.txtRadio);
            this.GBoxEntradas.Controls.Add(this.lblRadio);
            this.GBoxEntradas.ForeColor = System.Drawing.Color.Lime;
            this.GBoxEntradas.Location = new System.Drawing.Point(20, 12);
            this.GBoxEntradas.Name = "GBoxEntradas";
            this.GBoxEntradas.Size = new System.Drawing.Size(232, 147);
            this.GBoxEntradas.TabIndex = 49;
            this.GBoxEntradas.TabStop = false;
            this.GBoxEntradas.Text = "Input Section";
            // 
            // lblInfoSide
            // 
            this.lblInfoSide.AutoSize = true;
            this.lblInfoSide.Enabled = false;
            this.lblInfoSide.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoSide.Location = new System.Drawing.Point(97, 105);
            this.lblInfoSide.Name = "lblInfoSide";
            this.lblInfoSide.Size = new System.Drawing.Size(112, 18);
            this.lblInfoSide.TabIndex = 4;
            this.lblInfoSide.Text = "Range: 3 - 10";
            // 
            // txtNumLados
            // 
            this.txtNumLados.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtNumLados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumLados.ForeColor = System.Drawing.Color.Lime;
            this.txtNumLados.Location = new System.Drawing.Point(100, 80);
            this.txtNumLados.Name = "txtNumLados";
            this.txtNumLados.Size = new System.Drawing.Size(100, 22);
            this.txtNumLados.TabIndex = 3;
            this.txtNumLados.Enter += new System.EventHandler(this.txtNumLados_Enter);
            this.txtNumLados.Leave += new System.EventHandler(this.txtNumLados_Leave);
            // 
            // lblSide
            // 
            this.lblSide.AutoSize = true;
            this.lblSide.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSide.Location = new System.Drawing.Point(17, 86);
            this.lblSide.Name = "lblSide";
            this.lblSide.Size = new System.Drawing.Size(70, 22);
            this.lblSide.TabIndex = 2;
            this.lblSide.Text = "Sides:";
            // 
            // txtRadio
            // 
            this.txtRadio.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtRadio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRadio.ForeColor = System.Drawing.Color.Lime;
            this.txtRadio.Location = new System.Drawing.Point(100, 36);
            this.txtRadio.Name = "txtRadio";
            this.txtRadio.Size = new System.Drawing.Size(100, 22);
            this.txtRadio.TabIndex = 1;
            // 
            // lblRadio
            // 
            this.lblRadio.AutoSize = true;
            this.lblRadio.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRadio.Location = new System.Drawing.Point(18, 42);
            this.lblRadio.Name = "lblRadio";
            this.lblRadio.Size = new System.Drawing.Size(70, 22);
            this.lblRadio.TabIndex = 0;
            this.lblRadio.Text = "Radio:";
            // 
            // lblInfoPoints
            // 
            this.lblInfoPoints.AutoSize = true;
            this.lblInfoPoints.Enabled = false;
            this.lblInfoPoints.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoPoints.ForeColor = System.Drawing.Color.Lime;
            this.lblInfoPoints.Location = new System.Drawing.Point(827, 441);
            this.lblInfoPoints.Name = "lblInfoPoints";
            this.lblInfoPoints.Size = new System.Drawing.Size(120, 36);
            this.lblInfoPoints.TabIndex = 54;
            this.lblInfoPoints.Text = "Points of the \r\nlast filling";
            // 
            // lblTotalPoints
            // 
            this.lblTotalPoints.AutoSize = true;
            this.lblTotalPoints.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPoints.Location = new System.Drawing.Point(6, 22);
            this.lblTotalPoints.Name = "lblTotalPoints";
            this.lblTotalPoints.Size = new System.Drawing.Size(72, 20);
            this.lblTotalPoints.TabIndex = 13;
            this.lblTotalPoints.Text = "Total: ";
            this.lblTotalPoints.Visible = false;
            // 
            // FrmPolygon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 473);
            this.Controls.Add(this.panel1);
            this.Name = "FrmPolygon";
            this.Text = "FrmPolygon";
            this.Load += new System.EventHandler(this.FrmPolygon_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxPoints.ResumeLayout(false);
            this.groupBoxPoints.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.GBoxEntradas.ResumeLayout(false);
            this.GBoxEntradas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Button btnResetear;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.GroupBox GBoxEntradas;
        private System.Windows.Forms.TextBox txtNumLados;
        private System.Windows.Forms.Label lblSide;
        private System.Windows.Forms.TextBox txtRadio;
        private System.Windows.Forms.Label lblRadio;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.GroupBox groupBoxPoints;
        private System.Windows.Forms.ListBox lstPoints;
        private System.Windows.Forms.Label lblInfoSide;
        private System.Windows.Forms.Label lblInfoPoints;
        private System.Windows.Forms.Label lblTotalPoints;
    }
}