﻿namespace moneymanager
{
    partial class dodaj
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dodaj));
            this.wartoscdod = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dodajbutton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.wartoscdod)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // wartoscdod
            // 
            this.wartoscdod.DecimalPlaces = 2;
            this.wartoscdod.Font = new System.Drawing.Font("Georgia", 8.25F);
            this.wartoscdod.Location = new System.Drawing.Point(68, 46);
            this.wartoscdod.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.wartoscdod.Name = "wartoscdod";
            this.wartoscdod.Size = new System.Drawing.Size(120, 20);
            this.wartoscdod.TabIndex = 0;
            this.wartoscdod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.wartoscdod_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dodaj środki do salda";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(16, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kwota";
            // 
            // dodajbutton
            // 
            this.dodajbutton.BackColor = System.Drawing.Color.PeachPuff;
            this.dodajbutton.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dodajbutton.Location = new System.Drawing.Point(70, 94);
            this.dodajbutton.Name = "dodajbutton";
            this.dodajbutton.Size = new System.Drawing.Size(75, 23);
            this.dodajbutton.TabIndex = 1;
            this.dodajbutton.Text = "Dodaj";
            this.dodajbutton.UseVisualStyleBackColor = false;
            this.dodajbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.wartoscdod);
            this.panel1.Location = new System.Drawing.Point(5, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 79);
            this.panel1.TabIndex = 3;
            // 
            // dodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(215, 126);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dodajbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "dodaj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MoneyManager";
            this.Load += new System.EventHandler(this.dodaj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wartoscdod)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown wartoscdod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button dodajbutton;
        private System.Windows.Forms.Panel panel1;
    }
}