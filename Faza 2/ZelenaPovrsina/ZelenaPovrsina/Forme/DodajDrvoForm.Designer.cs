namespace ZelenaPovrsina.Forme
{
    partial class DodajDrvoForm
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
            txtVrsta = new TextBox();
            txtVisina = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnDodaj = new Button();
            dateTime = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            txtPark = new TextBox();
            label6 = new Label();
            txtZastita = new TextBox();
            label7 = new Label();
            label8 = new Label();
            txtPovrsina = new TextBox();
            txtObim = new TextBox();
            SuspendLayout();
            // 
            // txtVrsta
            // 
            txtVrsta.Location = new Point(379, 124);
            txtVrsta.Name = "txtVrsta";
            txtVrsta.Size = new Size(150, 31);
            txtVrsta.TabIndex = 11;
            // 
            // txtVisina
            // 
            txtVisina.Location = new Point(379, 74);
            txtVisina.Name = "txtVisina";
            txtVisina.Size = new Size(150, 31);
            txtVisina.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Blue;
            label3.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(240, 128);
            label3.Name = "label3";
            label3.Size = new Size(69, 23);
            label3.TabIndex = 9;
            label3.Text = "Vrsta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Blue;
            label2.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(238, 78);
            label2.Name = "label2";
            label2.Size = new Size(71, 23);
            label2.TabIndex = 8;
            label2.Text = "Visina";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Blue;
            label1.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(389, 25);
            label1.Name = "label1";
            label1.Size = new Size(131, 23);
            label1.TabIndex = 7;
            label1.Text = "Dodaj drvo";
            // 
            // btnDodaj
            // 
            btnDodaj.BackColor = Color.White;
            btnDodaj.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDodaj.ForeColor = Color.Blue;
            btnDodaj.Location = new Point(655, 385);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(112, 34);
            btnDodaj.TabIndex = 6;
            btnDodaj.Text = "DODAJ";
            btnDodaj.UseVisualStyleBackColor = false;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // dateTime
            // 
            dateTime.Location = new Point(421, 173);
            dateTime.Name = "dateTime";
            dateTime.Size = new Size(300, 31);
            dateTime.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Blue;
            label4.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(240, 179);
            label4.Name = "label4";
            label4.Size = new Size(152, 23);
            label4.TabIndex = 13;
            label4.Text = "Datum sadnje";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Blue;
            label5.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(240, 224);
            label5.Name = "label5";
            label5.Size = new Size(88, 23);
            label5.TabIndex = 14;
            label5.Text = "Park id";
            // 
            // txtPark
            // 
            txtPark.Location = new Point(379, 220);
            txtPark.Name = "txtPark";
            txtPark.Size = new Size(150, 31);
            txtPark.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Blue;
            label6.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(240, 273);
            label6.Name = "label6";
            label6.Size = new Size(113, 23);
            label6.TabIndex = 16;
            label6.Text = "zastita id";
            // 
            // txtZastita
            // 
            txtZastita.Location = new Point(379, 269);
            txtZastita.Name = "txtZastita";
            txtZastita.Size = new Size(150, 31);
            txtZastita.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Blue;
            label7.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(240, 374);
            label7.Name = "label7";
            label7.Size = new Size(60, 23);
            label7.TabIndex = 18;
            label7.Text = "Obim";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Blue;
            label8.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(238, 326);
            label8.Name = "label8";
            label8.Size = new Size(104, 23);
            label8.TabIndex = 19;
            label8.Text = "Povrsina";
            // 
            // txtPovrsina
            // 
            txtPovrsina.Location = new Point(379, 322);
            txtPovrsina.Name = "txtPovrsina";
            txtPovrsina.Size = new Size(150, 31);
            txtPovrsina.TabIndex = 20;
            // 
            // txtObim
            // 
            txtObim.Location = new Point(379, 370);
            txtObim.Name = "txtObim";
            txtObim.Size = new Size(150, 31);
            txtObim.TabIndex = 21;
            // 
            // DodajDrvoForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(800, 450);
            Controls.Add(txtObim);
            Controls.Add(txtPovrsina);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtZastita);
            Controls.Add(label6);
            Controls.Add(txtPark);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dateTime);
            Controls.Add(txtVrsta);
            Controls.Add(txtVisina);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDodaj);
            Name = "DodajDrvoForm";
            Text = "DodajDrvoForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtVrsta;
        private TextBox txtVisina;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnDodaj;
        private DateTimePicker dateTime;
        private Label label4;
        private Label label5;
        private TextBox txtPark;
        private Label label6;
        private TextBox txtZastita;
        private Label label7;
        private Label label8;
        private TextBox txtPovrsina;
        private TextBox txtObim;
    }
}