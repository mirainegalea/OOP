﻿namespace ShapesCanvas
{
    partial class Form1
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
            this.pnlToolbox = new System.Windows.Forms.Panel();
            this.pnlCanvas = new System.Windows.Forms.Panel();
            this.cmbShapes = new System.Windows.Forms.ComboBox();
            this.lblShapes = new System.Windows.Forms.Label();
            this.lblRadius = new System.Windows.Forms.Label();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.pnlToolbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlToolbox
            // 
            this.pnlToolbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlToolbox.Controls.Add(this.txtRadius);
            this.pnlToolbox.Controls.Add(this.lblRadius);
            this.pnlToolbox.Controls.Add(this.lblShapes);
            this.pnlToolbox.Controls.Add(this.cmbShapes);
            this.pnlToolbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolbox.Location = new System.Drawing.Point(0, 0);
            this.pnlToolbox.Name = "pnlToolbox";
            this.pnlToolbox.Size = new System.Drawing.Size(1440, 104);
            this.pnlToolbox.TabIndex = 0;
            // 
            // pnlCanvas
            // 
            this.pnlCanvas.BackColor = System.Drawing.Color.White;
            this.pnlCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCanvas.Location = new System.Drawing.Point(0, 104);
            this.pnlCanvas.Name = "pnlCanvas";
            this.pnlCanvas.Size = new System.Drawing.Size(1440, 532);
            this.pnlCanvas.TabIndex = 1;
            this.pnlCanvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlCanvas_MouseClick);
 
            // 
            // cmbShapes
            // 
            this.cmbShapes.FormattingEnabled = true;
            this.cmbShapes.Items.AddRange(new object[] {
            "Square",
            "Circle",
            "Rectangle"});
            this.cmbShapes.Location = new System.Drawing.Point(142, 11);
            this.cmbShapes.Name = "cmbShapes";
            this.cmbShapes.Size = new System.Drawing.Size(154, 21);
            this.cmbShapes.TabIndex = 0;
            // 
            // lblShapes
            // 
            this.lblShapes.AutoSize = true;
            this.lblShapes.Location = new System.Drawing.Point(37, 11);
            this.lblShapes.Name = "lblShapes";
            this.lblShapes.Size = new System.Drawing.Size(77, 13);
            this.lblShapes.TabIndex = 1;
            this.lblShapes.Text = "Choose Shape";
            // 
            // lblRadius
            // 
            this.lblRadius.AutoSize = true;
            this.lblRadius.Location = new System.Drawing.Point(446, 8);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(40, 13);
            this.lblRadius.TabIndex = 2;
            this.lblRadius.Text = "Radius";
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(505, 8);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(122, 20);
            this.txtRadius.TabIndex = 3;
           
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 636);
            this.Controls.Add(this.pnlCanvas);
            this.Controls.Add(this.pnlToolbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlToolbox.ResumeLayout(false);
            this.pnlToolbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlToolbox;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.Label lblRadius;
        private System.Windows.Forms.Label lblShapes;
        private System.Windows.Forms.ComboBox cmbShapes;
        private System.Windows.Forms.Panel pnlCanvas;
    }
}

