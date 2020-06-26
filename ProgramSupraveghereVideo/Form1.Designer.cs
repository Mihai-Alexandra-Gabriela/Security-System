using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ProgramSupraveghereVideo
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Timer timer1;
            this.butonVideo = new System.Windows.Forms.Button();
            this.panelDormitor = new System.Windows.Forms.Panel();
            this.labelDormitor = new System.Windows.Forms.Label();
            this.panelSufragerie = new System.Windows.Forms.Panel();
            this.labelSufragerie = new System.Windows.Forms.Label();
            this.panelBucatarie = new System.Windows.Forms.Panel();
            this.labelBucatarie = new System.Windows.Forms.Label();
            this.labelTitluDormitor = new System.Windows.Forms.Label();
            this.labelTitluSufragerie = new System.Windows.Forms.Label();
            this.labelTitluBucatarie = new System.Windows.Forms.Label();
            timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelDormitor.SuspendLayout();
            this.panelSufragerie.SuspendLayout();
            this.panelBucatarie.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 500;
            timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // butonVideo
            // 
            this.butonVideo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.butonVideo.Location = new System.Drawing.Point(509, 64);
            this.butonVideo.Name = "butonVideo";
            this.butonVideo.Size = new System.Drawing.Size(205, 66);
            this.butonVideo.TabIndex = 1;
            this.butonVideo.Text = "Vezi WebCam";
            this.butonVideo.UseVisualStyleBackColor = true;
            this.butonVideo.Click += new System.EventHandler(this.butonVideo_Click);
            // 
            // panelDormitor
            // 
            this.panelDormitor.BackColor = System.Drawing.Color.Green;
            this.panelDormitor.Controls.Add(this.labelDormitor);
            this.panelDormitor.Location = new System.Drawing.Point(22, 38);
            this.panelDormitor.Name = "panelDormitor";
            this.panelDormitor.Size = new System.Drawing.Size(413, 119);
            this.panelDormitor.TabIndex = 2;
            // 
            // labelDormitor
            // 
            this.labelDormitor.AllowDrop = true;
            this.labelDormitor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDormitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDormitor.ForeColor = System.Drawing.Color.White;
            this.labelDormitor.Location = new System.Drawing.Point(0, 0);
            this.labelDormitor.Name = "labelDormitor";
            this.labelDormitor.Size = new System.Drawing.Size(413, 119);
            this.labelDormitor.TabIndex = 4;
            this.labelDormitor.Text = "DORMITOR";
            this.labelDormitor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelSufragerie
            // 
            this.panelSufragerie.BackColor = System.Drawing.Color.Green;
            this.panelSufragerie.Controls.Add(this.labelSufragerie);
            this.panelSufragerie.Location = new System.Drawing.Point(22, 192);
            this.panelSufragerie.Name = "panelSufragerie";
            this.panelSufragerie.Size = new System.Drawing.Size(413, 119);
            this.panelSufragerie.TabIndex = 3;
            // 
            // labelSufragerie
            // 
            this.labelSufragerie.AllowDrop = true;
            this.labelSufragerie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSufragerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSufragerie.ForeColor = System.Drawing.Color.White;
            this.labelSufragerie.Location = new System.Drawing.Point(0, 0);
            this.labelSufragerie.Name = "labelSufragerie";
            this.labelSufragerie.Size = new System.Drawing.Size(413, 119);
            this.labelSufragerie.TabIndex = 4;
            this.labelSufragerie.Text = "SUFRAGERIE";
            this.labelSufragerie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBucatarie
            // 
            this.panelBucatarie.BackColor = System.Drawing.Color.Green;
            this.panelBucatarie.Controls.Add(this.labelBucatarie);
            this.panelBucatarie.Location = new System.Drawing.Point(22, 347);
            this.panelBucatarie.Name = "panelBucatarie";
            this.panelBucatarie.Size = new System.Drawing.Size(413, 119);
            this.panelBucatarie.TabIndex = 4;
            // 
            // labelBucatarie
            // 
            this.labelBucatarie.AllowDrop = true;
            this.labelBucatarie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelBucatarie.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBucatarie.ForeColor = System.Drawing.Color.White;
            this.labelBucatarie.Location = new System.Drawing.Point(0, 0);
            this.labelBucatarie.Name = "labelBucatarie";
            this.labelBucatarie.Size = new System.Drawing.Size(413, 119);
            this.labelBucatarie.TabIndex = 4;
            this.labelBucatarie.Text = "BUCATARIE";
            this.labelBucatarie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTitluDormitor
            // 
            this.labelTitluDormitor.AutoSize = true;
            this.labelTitluDormitor.Location = new System.Drawing.Point(19, 18);
            this.labelTitluDormitor.Name = "labelTitluDormitor";
            this.labelTitluDormitor.Size = new System.Drawing.Size(62, 17);
            this.labelTitluDormitor.TabIndex = 5;
            this.labelTitluDormitor.Text = "Dormitor";
            // 
            // labelTitluSufragerie
            // 
            this.labelTitluSufragerie.AutoSize = true;
            this.labelTitluSufragerie.Location = new System.Drawing.Point(19, 172);
            this.labelTitluSufragerie.Name = "labelTitluSufragerie";
            this.labelTitluSufragerie.Size = new System.Drawing.Size(74, 17);
            this.labelTitluSufragerie.TabIndex = 6;
            this.labelTitluSufragerie.Text = "Sufragerie";
            // 
            // labelTitluBucatarie
            // 
            this.labelTitluBucatarie.Location = new System.Drawing.Point(19, 327);
            this.labelTitluBucatarie.Name = "labelTitluBucatarie";
            this.labelTitluBucatarie.Size = new System.Drawing.Size(68, 17);
            this.labelTitluBucatarie.TabIndex = 7;
            this.labelTitluBucatarie.Text = "Bucatarie";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 494);
            this.Controls.Add(this.labelTitluBucatarie);
            this.Controls.Add(this.labelTitluSufragerie);
            this.Controls.Add(this.labelTitluDormitor);
            this.Controls.Add(this.panelBucatarie);
            this.Controls.Add(this.panelSufragerie);
            this.Controls.Add(this.panelDormitor);
            this.Controls.Add(this.butonVideo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Program supraveghere video";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelDormitor.ResumeLayout(false);
            this.panelSufragerie.ResumeLayout(false);
            this.panelBucatarie.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button butonVideo;
        private System.Windows.Forms.Panel panelDormitor;
        private System.Windows.Forms.Label labelDormitor;
        private System.Windows.Forms.Panel panelSufragerie;
        private System.Windows.Forms.Label labelSufragerie;
        private System.Windows.Forms.Panel panelBucatarie;
        private System.Windows.Forms.Label labelBucatarie;
        private System.Windows.Forms.Label labelTitluDormitor;
        private System.Windows.Forms.Label labelTitluSufragerie;
        private System.Windows.Forms.Label labelTitluBucatarie;
    }
}

