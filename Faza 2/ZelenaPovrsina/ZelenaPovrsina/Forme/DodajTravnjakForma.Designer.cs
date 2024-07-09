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
            label1.BackColor = Color.Blue;
            label1.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(10, 55);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(184, 23);
            label1.TabIndex = 0;
            label1.Text = "Gradska opstina";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Blue;
            label2.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(10, 118);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(199, 23);
            label2.TabIndex = 1;
            label2.Text = "Zona ugrozenosti";
            // 
            // txtOpstina
            // 
            txtOpstina.Location = new Point(246, 51);
            txtOpstina.Margin = new Padding(4, 5, 4, 5);
            txtOpstina.Name = "txtOpstina";
            txtOpstina.Size = new Size(210, 31);
            txtOpstina.TabIndex = 2;
            // 
            // txtZona
            // 
            txtZona.Location = new Point(246, 114);
            txtZona.Margin = new Padding(4, 5, 4, 5);
            txtZona.Name = "txtZona";
            txtZona.Size = new Size(210, 31);
            txtZona.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Blue;
            label3.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(10, 185);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(162, 23);
            label3.TabIndex = 4;
            label3.Text = "Adresa zgrade";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Blue;
            label4.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(10, 245);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(218, 23);
            label4.TabIndex = 5;
            label4.Text = "Povrsina travnjaka";
            // 
            // txtAdresa
            // 
            txtAdresa.Location = new Point(246, 181);
            txtAdresa.Margin = new Padding(4, 5, 4, 5);
            txtAdresa.Name = "txtAdresa";
            txtAdresa.Size = new Size(210, 31);
            txtAdresa.TabIndex = 6;
            // 
            // txtPT
            // 
            txtPT.Location = new Point(246, 246);
            txtPT.Margin = new Padding(4, 5, 4, 5);
            txtPT.Name = "txtPT";
            txtPT.Size = new Size(210, 31);
            txtPT.TabIndex = 7;
            // 
            // btnDodajT
            // 
            btnDodajT.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDodajT.ForeColor = Color.Blue;
            btnDodajT.Location = new Point(299, 355);
            btnDodajT.Margin = new Padding(4, 5, 4, 5);
            btnDodajT.Name = "btnDodajT";
            btnDodajT.Size = new Size(157, 33);
            btnDodajT.TabIndex = 8;
            btnDodajT.Text = "Dodaj travnjak";
            btnDodajT.UseVisualStyleBackColor = true;
            btnDodajT.Click += btnDodajT_Click;
            // 
            // DodajTravnjakForma
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(826, 658);
            Controls.Add(btnDodajT);
            Controls.Add(txtPT);
            Controls.Add(txtAdresa);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtZona);
            Controls.Add(txtOpstina);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
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