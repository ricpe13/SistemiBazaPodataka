﻿namespace ZelenaPovrsina.Forme
{
    partial class DodajParkForma
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
            txtOpst = new TextBox();
            txtZona = new TextBox();
            txtNaziv = new TextBox();
            txtPov = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cmdDodajPark = new Button();
            SuspendLayout();
            // 
            // txtOpst
            // 
            txtOpst.Location = new Point(143, 10);
            txtOpst.Margin = new Padding(2, 2, 2, 2);
            txtOpst.Name = "txtOpst";
            txtOpst.Size = new Size(106, 23);
            txtOpst.TabIndex = 0;
            // 
            // txtZona
            // 
            txtZona.Location = new Point(143, 32);
            txtZona.Margin = new Padding(2, 2, 2, 2);
            txtZona.Name = "txtZona";
            txtZona.Size = new Size(106, 23);
            txtZona.TabIndex = 1;
            // 
            // txtNaziv
            // 
            txtNaziv.Location = new Point(143, 54);
            txtNaziv.Margin = new Padding(2, 2, 2, 2);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(106, 23);
            txtNaziv.TabIndex = 2;
            // 
            // txtPov
            // 
            txtPov.Location = new Point(143, 76);
            txtPov.Margin = new Padding(2, 2, 2, 2);
            txtPov.Name = "txtPov";
            txtPov.Size = new Size(106, 23);
            txtPov.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 10);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 4;
            label1.Text = "Gradska opština";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 32);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 5;
            label2.Text = "Zona ugroženosti";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 54);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 6;
            label3.Text = "Naziv parka";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 76);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 7;
            label4.Text = "Površina parka";
            // 
            // cmdDodajPark
            // 
            cmdDodajPark.BackColor = Color.FromArgb(255, 128, 0);
            cmdDodajPark.Location = new Point(153, 148);
            cmdDodajPark.Margin = new Padding(2, 2, 2, 2);
            cmdDodajPark.Name = "cmdDodajPark";
            cmdDodajPark.Size = new Size(78, 30);
            cmdDodajPark.TabIndex = 8;
            cmdDodajPark.Text = "DODAJ";
            cmdDodajPark.UseVisualStyleBackColor = false;
            cmdDodajPark.Click += cmdDodajPark_Click;
            // 
            // DodajParkForma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(cmdDodajPark);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPov);
            Controls.Add(txtNaziv);
            Controls.Add(txtZona);
            Controls.Add(txtOpst);
            Margin = new Padding(2, 2, 2, 2);
            Name = "DodajParkForma";
            Text = "DodajParkForma";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtOpst;
        private TextBox txtZona;
        private TextBox txtNaziv;
        private TextBox txtPov;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button cmdDodajPark;
    }
}