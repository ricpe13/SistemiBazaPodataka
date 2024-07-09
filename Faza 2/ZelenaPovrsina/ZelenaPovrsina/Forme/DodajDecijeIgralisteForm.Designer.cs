namespace ZelenaPovrsina.Forme
{
    partial class DodajDecijeIgralisteForm
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
            txtBr = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnDodaj = new Button();
            label4 = new Label();
            label5 = new Label();
            txtPesak = new TextBox();
            txtStarost = new TextBox();
            SuspendLayout();
            // 
            // txtPark
            // 
            txtPark.Location = new Point(337, 133);
            txtPark.Name = "txtPark";
            txtPark.Size = new Size(150, 31);
            txtPark.TabIndex = 11;
            // 
            // txtBr
            // 
            txtBr.Location = new Point(337, 83);
            txtBr.Name = "txtBr";
            txtBr.Size = new Size(150, 31);
            txtBr.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Blue;
            label3.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(142, 137);
            label3.Name = "label3";
            label3.Size = new Size(88, 23);
            label3.TabIndex = 9;
            label3.Text = "park id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Blue;
            label2.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(142, 87);
            label2.Name = "label2";
            label2.Size = new Size(159, 23);
            label2.TabIndex = 8;
            label2.Text = "Broj igracaka";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Blue;
            label1.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(337, 24);
            label1.Name = "label1";
            label1.Size = new Size(174, 23);
            label1.TabIndex = 7;
            label1.Text = "Dodaj igraliste";
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
            btnDodaj.Text = "DODAJ";
            btnDodaj.UseVisualStyleBackColor = false;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Blue;
            label4.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(142, 190);
            label4.Name = "label4";
            label4.Size = new Size(70, 23);
            label4.TabIndex = 12;
            label4.Text = "pesak";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Blue;
            label5.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(142, 243);
            label5.Name = "label5";
            label5.Size = new Size(93, 23);
            label5.TabIndex = 13;
            label5.Text = "starost";
            // 
            // txtPesak
            // 
            txtPesak.Location = new Point(337, 186);
            txtPesak.Name = "txtPesak";
            txtPesak.Size = new Size(150, 31);
            txtPesak.TabIndex = 14;
            // 
            // txtStarost
            // 
            txtStarost.Location = new Point(337, 239);
            txtStarost.Name = "txtStarost";
            txtStarost.Size = new Size(150, 31);
            txtStarost.TabIndex = 15;
            // 
            // DodajDecijeIgralisteForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(800, 450);
            Controls.Add(txtStarost);
            Controls.Add(txtPesak);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtPark);
            Controls.Add(txtBr);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDodaj);
            Name = "DodajDecijeIgralisteForm";
            Text = "DodajDecijeIgralisteForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPark;
        private TextBox txtBr;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnDodaj;
        private Label label4;
        private Label label5;
        private TextBox txtPesak;
        private TextBox txtStarost;
    }
}