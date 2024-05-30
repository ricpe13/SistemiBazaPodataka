namespace ZelenaPovrsina.Forme
{
    partial class DodajDrvoredForma
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtOpstinaDrvored = new TextBox();
            txtZonaDrvored = new TextBox();
            txtUlicaDrvored = new TextBox();
            txtDuzinaDrvored = new TextBox();
            txtVrstaDrvored = new TextBox();
            txtBrojDrvored = new TextBox();
            btnDodajDrvor = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 25);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 0;
            label1.Text = "Gradska opstina";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 61);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 1;
            label2.Text = "Zona ugrozenosti";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(81, 94);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 2;
            label3.Text = "Ulica";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(71, 133);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 3;
            label4.Text = "Duzina";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 172);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 4;
            label5.Text = "Vrsta drveta";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(46, 219);
            label6.Name = "label6";
            label6.Size = new Size(68, 15);
            label6.TabIndex = 5;
            label6.Text = "Broj stabala";
            // 
            // txtOpstinaDrvored
            // 
            txtOpstinaDrvored.Location = new Point(124, 22);
            txtOpstinaDrvored.Name = "txtOpstinaDrvored";
            txtOpstinaDrvored.Size = new Size(113, 23);
            txtOpstinaDrvored.TabIndex = 6;
            // 
            // txtZonaDrvored
            // 
            txtZonaDrvored.Location = new Point(125, 58);
            txtZonaDrvored.Name = "txtZonaDrvored";
            txtZonaDrvored.Size = new Size(121, 23);
            txtZonaDrvored.TabIndex = 7;
            // 
            // txtUlicaDrvored
            // 
            txtUlicaDrvored.Location = new Point(125, 91);
            txtUlicaDrvored.Name = "txtUlicaDrvored";
            txtUlicaDrvored.Size = new Size(132, 23);
            txtUlicaDrvored.TabIndex = 8;
            // 
            // txtDuzinaDrvored
            // 
            txtDuzinaDrvored.Location = new Point(124, 130);
            txtDuzinaDrvored.Name = "txtDuzinaDrvored";
            txtDuzinaDrvored.Size = new Size(167, 23);
            txtDuzinaDrvored.TabIndex = 9;
            // 
            // txtVrstaDrvored
            // 
            txtVrstaDrvored.Location = new Point(124, 171);
            txtVrstaDrvored.Name = "txtVrstaDrvored";
            txtVrstaDrvored.Size = new Size(170, 23);
            txtVrstaDrvored.TabIndex = 10;
            // 
            // txtBrojDrvored
            // 
            txtBrojDrvored.Location = new Point(125, 211);
            txtBrojDrvored.Name = "txtBrojDrvored";
            txtBrojDrvored.Size = new Size(148, 23);
            txtBrojDrvored.TabIndex = 11;
            // 
            // btnDodajDrvor
            // 
            btnDodajDrvor.Location = new Point(136, 263);
            btnDodajDrvor.Name = "btnDodajDrvor";
            btnDodajDrvor.Size = new Size(134, 35);
            btnDodajDrvor.TabIndex = 12;
            btnDodajDrvor.Text = "Dodaj drvored";
            btnDodajDrvor.UseVisualStyleBackColor = true;
            btnDodajDrvor.Click += btnDodajDrvor_Click;
            // 
            // DodajDrvoredForma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDodajDrvor);
            Controls.Add(txtBrojDrvored);
            Controls.Add(txtVrstaDrvored);
            Controls.Add(txtDuzinaDrvored);
            Controls.Add(txtUlicaDrvored);
            Controls.Add(txtZonaDrvored);
            Controls.Add(txtOpstinaDrvored);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DodajDrvoredForma";
            Text = "DodajDrvoredForma";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtOpstinaDrvored;
        private TextBox txtZonaDrvored;
        private TextBox txtUlicaDrvored;
        private TextBox txtDuzinaDrvored;
        private TextBox txtVrstaDrvored;
        private TextBox txtBrojDrvored;
        private Button btnDodajDrvor;
    }
}