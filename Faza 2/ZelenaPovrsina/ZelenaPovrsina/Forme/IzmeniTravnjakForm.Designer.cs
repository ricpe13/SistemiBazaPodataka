namespace ZelenaPovrsina.Forme
{
    partial class IzmeniTravnjakForm
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
            btnIzmeni = new Button();
            txtPT = new TextBox();
            txtAdresa = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txtZona = new TextBox();
            txtOpstina = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnIzmeni
            // 
            btnIzmeni.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIzmeni.ForeColor = Color.Blue;
            btnIzmeni.Location = new Point(466, 361);
            btnIzmeni.Margin = new Padding(4, 5, 4, 5);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(157, 33);
            btnIzmeni.TabIndex = 17;
            btnIzmeni.Text = "Izmeni";
            btnIzmeni.UseVisualStyleBackColor = true;
            btnIzmeni.Click += btnIzmeni_Click;
            // 
            // txtPT
            // 
            txtPT.Location = new Point(413, 252);
            txtPT.Margin = new Padding(4, 5, 4, 5);
            txtPT.Name = "txtPT";
            txtPT.Size = new Size(210, 31);
            txtPT.TabIndex = 16;
            // 
            // txtAdresa
            // 
            txtAdresa.Location = new Point(413, 187);
            txtAdresa.Margin = new Padding(4, 5, 4, 5);
            txtAdresa.Name = "txtAdresa";
            txtAdresa.Size = new Size(210, 31);
            txtAdresa.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Blue;
            label4.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(177, 251);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(218, 23);
            label4.TabIndex = 14;
            label4.Text = "Povrsina travnjaka";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Blue;
            label3.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(177, 191);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(162, 23);
            label3.TabIndex = 13;
            label3.Text = "Adresa zgrade";
            // 
            // txtZona
            // 
            txtZona.Location = new Point(413, 120);
            txtZona.Margin = new Padding(4, 5, 4, 5);
            txtZona.Name = "txtZona";
            txtZona.Size = new Size(210, 31);
            txtZona.TabIndex = 12;
            // 
            // txtOpstina
            // 
            txtOpstina.Location = new Point(413, 57);
            txtOpstina.Margin = new Padding(4, 5, 4, 5);
            txtOpstina.Name = "txtOpstina";
            txtOpstina.Size = new Size(210, 31);
            txtOpstina.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Blue;
            label2.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(177, 124);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(199, 23);
            label2.TabIndex = 10;
            label2.Text = "Zona ugrozenosti";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Blue;
            label1.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(177, 61);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(184, 23);
            label1.TabIndex = 9;
            label1.Text = "Gradska opstina";
            // 
            // IzmeniTravnjakForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(800, 450);
            Controls.Add(btnIzmeni);
            Controls.Add(txtPT);
            Controls.Add(txtAdresa);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtZona);
            Controls.Add(txtOpstina);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "IzmeniTravnjakForm";
            Text = "IzmeniTravnjakForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIzmeni;
        private TextBox txtPT;
        private TextBox txtAdresa;
        private Label label4;
        private Label label3;
        private TextBox txtZona;
        private TextBox txtOpstina;
        private Label label2;
        private Label label1;
    }
}