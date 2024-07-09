namespace ZelenaPovrsina.Forme
{
    partial class DodajKlupuForma
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
            btnDodaj = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtMat = new TextBox();
            txtPark = new TextBox();
            SuspendLayout();
            // 
            // btnDodaj
            // 
            btnDodaj.BackColor = Color.White;
            btnDodaj.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDodaj.ForeColor = Color.Blue;
            btnDodaj.Location = new Point(288, 350);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(112, 34);
            btnDodaj.TabIndex = 0;
            btnDodaj.Text = "DODAJ";
            btnDodaj.UseVisualStyleBackColor = false;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Blue;
            label1.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(268, 75);
            label1.Name = "label1";
            label1.Size = new Size(144, 23);
            label1.TabIndex = 1;
            label1.Text = "Dodaj klupu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Blue;
            label2.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(94, 165);
            label2.Name = "label2";
            label2.Size = new Size(113, 23);
            label2.TabIndex = 2;
            label2.Text = "Materijal";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Blue;
            label3.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(94, 246);
            label3.Name = "label3";
            label3.Size = new Size(88, 23);
            label3.TabIndex = 3;
            label3.Text = "park id";
            // 
            // txtMat
            // 
            txtMat.Location = new Point(268, 165);
            txtMat.Name = "txtMat";
            txtMat.Size = new Size(150, 31);
            txtMat.TabIndex = 4;
            // 
            // txtPark
            // 
            txtPark.Location = new Point(268, 246);
            txtPark.Name = "txtPark";
            txtPark.Size = new Size(150, 31);
            txtPark.TabIndex = 5;
            // 
            // DodajKlupuForma
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPark);
            Controls.Add(txtMat);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDodaj);
            Name = "DodajKlupuForma";
            Text = "DodajKlupuForma";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDodaj;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtMat;
        private TextBox txtPark;
    }
}