namespace ZelenaPovrsina.Forme
{
    partial class DodajSpomenikForm
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
            txtZastita = new TextBox();
            label4 = new Label();
            txtPark = new TextBox();
            txtNaziv = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnDodaj = new Button();
            SuspendLayout();
            // 
            // txtZastita
            // 
            txtZastita.Location = new Point(415, 265);
            txtZastita.Name = "txtZastita";
            txtZastita.Size = new Size(150, 31);
            txtZastita.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Blue;
            label4.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(219, 269);
            label4.Name = "label4";
            label4.Size = new Size(113, 23);
            label4.TabIndex = 20;
            label4.Text = "Zastita id";
            // 
            // txtPark
            // 
            txtPark.Location = new Point(415, 200);
            txtPark.Name = "txtPark";
            txtPark.Size = new Size(150, 31);
            txtPark.TabIndex = 19;
            // 
            // txtNaziv
            // 
            txtNaziv.Location = new Point(415, 141);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(150, 31);
            txtNaziv.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Blue;
            label3.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(219, 204);
            label3.Name = "label3";
            label3.Size = new Size(88, 23);
            label3.TabIndex = 17;
            label3.Text = "Park id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Blue;
            label2.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(219, 145);
            label2.Name = "label2";
            label2.Size = new Size(66, 23);
            label2.TabIndex = 16;
            label2.Text = "Naziv";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Blue;
            label1.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(327, 70);
            label1.Name = "label1";
            label1.Size = new Size(176, 23);
            label1.TabIndex = 15;
            label1.Text = "dodaj spomenik";
            // 
            // btnDodaj
            // 
            btnDodaj.BackColor = Color.White;
            btnDodaj.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDodaj.ForeColor = Color.Blue;
            btnDodaj.Location = new Point(469, 346);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(112, 34);
            btnDodaj.TabIndex = 14;
            btnDodaj.Text = "Dodaj skultpturu";
            btnDodaj.UseVisualStyleBackColor = false;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // DodajSpomenikForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(800, 450);
            Controls.Add(txtZastita);
            Controls.Add(label4);
            Controls.Add(txtPark);
            Controls.Add(txtNaziv);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDodaj);
            Name = "DodajSpomenikForm";
            Text = "DodajSpomenikForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtZastita;
        private Label label4;
        private TextBox txtPark;
        private TextBox txtNaziv;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnDodaj;
    }
}