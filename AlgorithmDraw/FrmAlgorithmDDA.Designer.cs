﻿namespace AlgorithmDraw
{
    partial class FrmAlgorithmDDA
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
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtY2 = new System.Windows.Forms.TextBox();
            this.txtX1 = new System.Windows.Forms.TextBox();
            this.txtX2 = new System.Windows.Forms.TextBox();
            this.txtY1 = new System.Windows.Forms.TextBox();
            this.groupBoxDraw = new System.Windows.Forms.GroupBox();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.btnDraw = new System.Windows.Forms.Button();
            this.lstPoints = new System.Windows.Forms.ListBox();
            this.groupBoxPoints = new System.Windows.Forms.GroupBox();
            this.lblInfoPoints = new System.Windows.Forms.Label();
            this.lblTotalPoints = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBoxInput.SuspendLayout();
            this.groupBoxDraw.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.groupBoxPoints.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.lblInfoPoints);
            this.panel1.Controls.Add(this.groupBoxPoints);
            this.panel1.Controls.Add(this.lblInfo);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.groupBoxInput);
            this.panel1.Controls.Add(this.groupBoxDraw);
            this.panel1.Controls.Add(this.btnDraw);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(962, 473);
            this.panel1.TabIndex = 0;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.ForeColor = System.Drawing.Color.Lime;
            this.lblInfo.Location = new System.Drawing.Point(17, 448);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(432, 16);
            this.lblInfo.TabIndex = 13;
            this.lblInfo.Text = " Tip: You can also select the dots by clicking on the area with the mouse.";
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.Lime;
            this.btnClear.Location = new System.Drawing.Point(127, 260);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(93, 38);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Controls.Add(this.label4);
            this.groupBoxInput.Controls.Add(this.label3);
            this.groupBoxInput.Controls.Add(this.label2);
            this.groupBoxInput.Controls.Add(this.label1);
            this.groupBoxInput.Controls.Add(this.txtY2);
            this.groupBoxInput.Controls.Add(this.txtX1);
            this.groupBoxInput.Controls.Add(this.txtX2);
            this.groupBoxInput.Controls.Add(this.txtY1);
            this.groupBoxInput.ForeColor = System.Drawing.Color.Lime;
            this.groupBoxInput.Location = new System.Drawing.Point(20, 12);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(200, 208);
            this.groupBoxInput.TabIndex = 6;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Input Section";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "y2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "x2:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "y1:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "x1:";
            // 
            // txtY2
            // 
            this.txtY2.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtY2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtY2.ForeColor = System.Drawing.Color.Lime;
            this.txtY2.Location = new System.Drawing.Point(71, 155);
            this.txtY2.Name = "txtY2";
            this.txtY2.Size = new System.Drawing.Size(100, 22);
            this.txtY2.TabIndex = 10;
            // 
            // txtX1
            // 
            this.txtX1.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtX1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtX1.ForeColor = System.Drawing.Color.Lime;
            this.txtX1.Location = new System.Drawing.Point(71, 35);
            this.txtX1.Name = "txtX1";
            this.txtX1.Size = new System.Drawing.Size(100, 22);
            this.txtX1.TabIndex = 7;
            // 
            // txtX2
            // 
            this.txtX2.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtX2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtX2.ForeColor = System.Drawing.Color.Lime;
            this.txtX2.Location = new System.Drawing.Point(71, 115);
            this.txtX2.Name = "txtX2";
            this.txtX2.Size = new System.Drawing.Size(100, 22);
            this.txtX2.TabIndex = 9;
            // 
            // txtY1
            // 
            this.txtY1.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtY1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtY1.ForeColor = System.Drawing.Color.Lime;
            this.txtY1.Location = new System.Drawing.Point(71, 75);
            this.txtY1.Name = "txtY1";
            this.txtY1.Size = new System.Drawing.Size(100, 22);
            this.txtY1.TabIndex = 8;
            // 
            // groupBoxDraw
            // 
            this.groupBoxDraw.Controls.Add(this.picCanvas);
            this.groupBoxDraw.ForeColor = System.Drawing.Color.Lime;
            this.groupBoxDraw.Location = new System.Drawing.Point(256, 12);
            this.groupBoxDraw.Name = "groupBoxDraw";
            this.groupBoxDraw.Size = new System.Drawing.Size(516, 426);
            this.groupBoxDraw.TabIndex = 1;
            this.groupBoxDraw.TabStop = false;
            this.groupBoxDraw.Text = "Graphic";
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(19, 21);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(491, 399);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            this.picCanvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseClick);
            // 
            // btnDraw
            // 
            this.btnDraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDraw.ForeColor = System.Drawing.Color.Lime;
            this.btnDraw.Location = new System.Drawing.Point(20, 260);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(93, 38);
            this.btnDraw.TabIndex = 0;
            this.btnDraw.Text = "Draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
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
            // groupBoxPoints
            // 
            this.groupBoxPoints.Controls.Add(this.lblTotalPoints);
            this.groupBoxPoints.Controls.Add(this.lstPoints);
            this.groupBoxPoints.ForeColor = System.Drawing.Color.Lime;
            this.groupBoxPoints.Location = new System.Drawing.Point(806, 12);
            this.groupBoxPoints.Name = "groupBoxPoints";
            this.groupBoxPoints.Size = new System.Drawing.Size(144, 426);
            this.groupBoxPoints.TabIndex = 14;
            this.groupBoxPoints.TabStop = false;
            this.groupBoxPoints.Text = "Points";
            // 
            // lblInfoPoints
            // 
            this.lblInfoPoints.AutoSize = true;
            this.lblInfoPoints.Enabled = false;
            this.lblInfoPoints.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoPoints.ForeColor = System.Drawing.Color.Lime;
            this.lblInfoPoints.Location = new System.Drawing.Point(830, 441);
            this.lblInfoPoints.Name = "lblInfoPoints";
            this.lblInfoPoints.Size = new System.Drawing.Size(120, 36);
            this.lblInfoPoints.TabIndex = 15;
            this.lblInfoPoints.Text = "Points of the \r\nlast line";
            // 
            // lblTotalPoints
            // 
            this.lblTotalPoints.AutoSize = true;
            this.lblTotalPoints.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPoints.Location = new System.Drawing.Point(6, 18);
            this.lblTotalPoints.Name = "lblTotalPoints";
            this.lblTotalPoints.Size = new System.Drawing.Size(72, 20);
            this.lblTotalPoints.TabIndex = 12;
            this.lblTotalPoints.Text = "Total: ";
            this.lblTotalPoints.Visible = false;
            this.lblTotalPoints.Click += new System.EventHandler(this.lblTotalPoints_Click);
            // 
            // FrmAlgorithmDDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 473);
            this.Controls.Add(this.panel1);
            this.Name = "FrmAlgorithmDDA";
            this.Text = "FrmAlgorithmDDA";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            this.groupBoxDraw.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.groupBoxPoints.ResumeLayout(false);
            this.groupBoxPoints.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtY2;
        private System.Windows.Forms.TextBox txtX1;
        private System.Windows.Forms.TextBox txtX2;
        private System.Windows.Forms.TextBox txtY1;
        private System.Windows.Forms.GroupBox groupBoxDraw;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ListBox lstPoints;
        private System.Windows.Forms.GroupBox groupBoxPoints;
        private System.Windows.Forms.Label lblInfoPoints;
        private System.Windows.Forms.Label lblTotalPoints;
    }
}