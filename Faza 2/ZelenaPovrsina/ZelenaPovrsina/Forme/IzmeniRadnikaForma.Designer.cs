namespace ZelenaPovrsina.Forme
{
    partial class IzmeniRadnikaForma
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
            txtIme = new TextBox();
            txtPrezime = new TextBox();
            txtAdresa = new TextBox();
            txtBr = new TextBox();
            btnIzmeni = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Blue;
            label1.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(266, 48);
            label1.Name = "label1";
            label1.Size = new Size(282, 23);
            label1.TabIndex = 0;
            label1.Text = "IZMENI PODATKE O RADNIKU";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Blue;
            label2.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLight;
            label2.Location = new Point(76, 268);
            label2.Name = "label2";
            label2.Size = new Size(217, 23);
            label2.TabIndex = 1;
            label2.Text = "Broj radne knjizice";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Blue;
            label3.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLight;
            label3.Location = new Point(76, 215);
            label3.Name = "label3";
            label3.Size = new Size(82, 23);
            label3.TabIndex = 2;
            label3.Text = "Adresa";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Blue;
            label4.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLight;
            label4.Location = new Point(76, 167);
            label4.Name = "label4";
            label4.Size = new Size(93, 23);
            label4.TabIndex = 3;
            label4.Text = "Prezime";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Blue;
            label5.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlLight;
            label5.Location = new Point(76, 122);
            label5.Name = "label5";
            label5.Size = new Size(44, 23);
            label5.TabIndex = 4;
            label5.Text = "Ime";
            // 
            // txtIme
            // 
            txtIme.Location = new Point(409, 117);
            txtIme.Name = "txtIme";
            txtIme.Size = new Size(150, 31);
            txtIme.TabIndex = 5;
            // 
            // txtPrezime
            // 
            txtPrezime.Location = new Point(409, 162);
            txtPrezime.Name = "txtPrezime";
            txtPrezime.Size = new Size(150, 31);
            txtPrezime.TabIndex = 6;
            // 
            // txtAdresa
            // 
            txtAdresa.Location = new Point(409, 212);
            txtAdresa.Name = "txtAdresa";
            txtAdresa.Size = new Size(150, 31);
            txtAdresa.TabIndex = 7;
            // 
            // txtBr
            // 
            txtBr.Location = new Point(409, 265);
            txtBr.Name = "txtBr";
            txtBr.Size = new Size(150, 31);
            txtBr.TabIndex = 8;
            // 
            // btnIzmeni
            // 
            btnIzmeni.BackColor = Color.Blue;
            btnIzmeni.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIzmeni.ForeColor = Color.White;
            btnIzmeni.Location = new Point(423, 362);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(111, 33);
            btnIzmeni.TabIndex = 9;
            btnIzmeni.Text = "Izmeni";
            btnIzmeni.UseVisualStyleBackColor = false;
            btnIzmeni.Click += btnIzmeni_Click;
            // 
            // IzmeniRadnikaForma
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(800, 450);
            Controls.Add(btnIzmeni);
            Controls.Add(txtBr);
            Controls.Add(txtAdresa);
            Controls.Add(txtPrezime);
            Controls.Add(txtIme);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "IzmeniRadnikaForma";
            Text = "IzmeniRadnikaForma";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtIme;
        private TextBox txtPrezime;
        private TextBox txtAdresa;
        private TextBox txtBr;
        private Button btnIzmeni;
    }
}