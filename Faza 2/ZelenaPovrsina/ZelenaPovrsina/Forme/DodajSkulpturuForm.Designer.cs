namespace ZelenaPovrsina.Forme
{
    partial class DodajSkulpturuForm
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
            txtPark = new TextBox();
            txtAutor = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnDodaj = new Button();
            label4 = new Label();
            txtZastita = new TextBox();
            SuspendLayout();
            // 
            // txtPark
            // 
            txtPark.Location = new Point(378, 200);
            txtPark.Name = "txtPark";
            txtPark.Size = new Size(150, 31);
            txtPark.TabIndex = 11;
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(378, 141);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(150, 31);
            txtAutor.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Blue;
            label3.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(182, 204);
            label3.Name = "label3";
            label3.Size = new Size(88, 23);
            label3.TabIndex = 9;
            label3.Text = "Park id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Blue;
            label2.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(182, 145);
            label2.Name = "label2";
            label2.Size = new Size(75, 23);
            label2.TabIndex = 8;
            label2.Text = "Autor";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Blue;
            label1.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(290, 70);
            label1.Name = "label1";
            label1.Size = new Size(205, 23);
            label1.TabIndex = 7;
            label1.Text = "Dodaj skultpturu";
            // 
            // btnDodaj
            // 
            btnDodaj.BackColor = Color.White;
            btnDodaj.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDodaj.ForeColor = Color.Blue;
            btnDodaj.Location = new Point(432, 346);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(112, 34);
            btnDodaj.TabIndex = 6;
            btnDodaj.Text = "Dodaj skultpturu";
            btnDodaj.UseVisualStyleBackColor = false;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Blue;
            label4.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(182, 269);
            label4.Name = "label4";
            label4.Size = new Size(113, 23);
            label4.TabIndex = 12;
            label4.Text = "Zastita id";
            // 
            // txtZastita
            // 
            txtZastita.Location = new Point(378, 265);
            txtZastita.Name = "txtZastita";
            txtZastita.Size = new Size(150, 31);
            txtZastita.TabIndex = 13;
            // 
            // DodajSkulpturuForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(800, 450);
            Controls.Add(txtZastita);
            Controls.Add(label4);
            Controls.Add(txtPark);
            Controls.Add(txtAutor);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDodaj);
            Name = "DodajSkulpturuForm";
            Text = "DodajSkulpturuForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPark;
        private TextBox txtAutor;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnDodaj;
        private Label label4;
        private TextBox txtZastita;
    }
}