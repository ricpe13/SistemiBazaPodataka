namespace ZelenaPovrsina.Forme
{
    partial class DodajTravnjakForma
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
            txtOpstina = new TextBox();
            txtZona = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtAdresa = new TextBox();
            txtPT = new TextBox();
            btnDodajT = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 33);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 0;
            label1.Text = "Gradska opstina";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 71);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 1;
            label2.Text = "Zona ugrozenosti";
            // 
            // txtOpstina
            // 
            txtOpstina.Location = new Point(116, 30);
            txtOpstina.Name = "txtOpstina";
            txtOpstina.Size = new Size(148, 23);
            txtOpstina.TabIndex = 2;
            // 
            // txtZona
            // 
            txtZona.Location = new Point(116, 68);
            txtZona.Name = "txtZona";
            txtZona.Size = new Size(148, 23);
            txtZona.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 111);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 4;
            label3.Text = "Adresa zgrade";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 147);
            label4.Name = "label4";
            label4.Size = new Size(103, 15);
            label4.TabIndex = 5;
            label4.Text = "Povrsina travnjaka";
            // 
            // txtAdresa
            // 
            txtAdresa.Location = new Point(116, 108);
            txtAdresa.Name = "txtAdresa";
            txtAdresa.Size = new Size(145, 23);
            txtAdresa.TabIndex = 6;
            // 
            // txtPT
            // 
            txtPT.Location = new Point(116, 147);
            txtPT.Name = "txtPT";
            txtPT.Size = new Size(146, 23);
            txtPT.TabIndex = 7;
            // 
            // btnDodajT
            // 
            btnDodajT.Location = new Point(128, 191);
            btnDodajT.Name = "btnDodajT";
            btnDodajT.Size = new Size(110, 25);
            btnDodajT.TabIndex = 8;
            btnDodajT.Text = "Dodaj travnjak";
            btnDodajT.UseVisualStyleBackColor = true;
            btnDodajT.Click += btnDodajT_Click;
            // 
            // DodajTravnjakForma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 395);
            Controls.Add(btnDodajT);
            Controls.Add(txtPT);
            Controls.Add(txtAdresa);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtZona);
            Controls.Add(txtOpstina);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DodajTravnjakForma";
            Text = "DodajTravnjakForma";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtOpstina;
        private TextBox txtZona;
        private Label label3;
        private Label label4;
        private TextBox txtAdresa;
        private TextBox txtPT;
        private Button btnDodajT;
    }
}