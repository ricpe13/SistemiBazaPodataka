namespace ZelenaPovrsina
{
    partial class Pocetna
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
            btnParkovi = new Button();
            btnDrvoredi = new Button();
            btnTravnjaci = new Button();
            btnRadnici = new Button();
            btnGrupeRadnika = new Button();
            btnObjekti = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Blue;
            label1.Font = new Font("Showcard Gothic", 40F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(281, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(723, 98);
            label1.TabIndex = 0;
            label1.Text = "Zelene Povrsine";
            // 
            // btnParkovi
            // 
            btnParkovi.BackColor = Color.Blue;
            btnParkovi.Font = new Font("Showcard Gothic", 20F, FontStyle.Bold);
            btnParkovi.ForeColor = Color.White;
            btnParkovi.Location = new Point(1118, 534);
            btnParkovi.Margin = new Padding(4, 5, 4, 5);
            btnParkovi.Name = "btnParkovi";
            btnParkovi.Size = new Size(281, 61);
            btnParkovi.TabIndex = 1;
            btnParkovi.Text = "Parkovi";
            btnParkovi.UseVisualStyleBackColor = false;
            btnParkovi.Click += btnParkovi_Click;
            // 
            // btnDrvoredi
            // 
            btnDrvoredi.BackColor = Color.Blue;
            btnDrvoredi.Font = new Font("Showcard Gothic", 20F, FontStyle.Bold);
            btnDrvoredi.ForeColor = Color.White;
            btnDrvoredi.Location = new Point(1118, 129);
            btnDrvoredi.Margin = new Padding(4, 5, 4, 5);
            btnDrvoredi.Name = "btnDrvoredi";
            btnDrvoredi.Size = new Size(281, 61);
            btnDrvoredi.TabIndex = 2;
            btnDrvoredi.Text = "Drvoredi";
            btnDrvoredi.UseVisualStyleBackColor = false;
            btnDrvoredi.Click += btnDrvoredi_Click;
            // 
            // btnTravnjaci
            // 
            btnTravnjaci.BackColor = Color.Blue;
            btnTravnjaci.Font = new Font("Showcard Gothic", 20F, FontStyle.Bold);
            btnTravnjaci.ForeColor = Color.White;
            btnTravnjaci.Location = new Point(1118, 231);
            btnTravnjaci.Margin = new Padding(4, 5, 4, 5);
            btnTravnjaci.Name = "btnTravnjaci";
            btnTravnjaci.Size = new Size(281, 61);
            btnTravnjaci.TabIndex = 3;
            btnTravnjaci.Text = "Travnjaci";
            btnTravnjaci.UseVisualStyleBackColor = false;
            btnTravnjaci.Click += btnTravnjaci_Click;
            // 
            // btnRadnici
            // 
            btnRadnici.BackColor = Color.Blue;
            btnRadnici.Font = new Font("Showcard Gothic", 20F, FontStyle.Bold);
            btnRadnici.ForeColor = Color.White;
            btnRadnici.Location = new Point(1118, 737);
            btnRadnici.Margin = new Padding(4, 5, 4, 5);
            btnRadnici.Name = "btnRadnici";
            btnRadnici.Size = new Size(281, 63);
            btnRadnici.TabIndex = 4;
            btnRadnici.Text = "Radnici";
            btnRadnici.UseVisualStyleBackColor = false;
            btnRadnici.Click += btnRadnici_Click;
            // 
            // btnGrupeRadnika
            // 
            btnGrupeRadnika.BackColor = Color.Blue;
            btnGrupeRadnika.Font = new Font("Showcard Gothic", 20F, FontStyle.Bold);
            btnGrupeRadnika.ForeColor = Color.White;
            btnGrupeRadnika.Location = new Point(1118, 635);
            btnGrupeRadnika.Margin = new Padding(4, 5, 4, 5);
            btnGrupeRadnika.Name = "btnGrupeRadnika";
            btnGrupeRadnika.Size = new Size(281, 63);
            btnGrupeRadnika.TabIndex = 5;
            btnGrupeRadnika.Text = "Grupe radnika";
            btnGrupeRadnika.UseVisualStyleBackColor = false;
            btnGrupeRadnika.Click += btnGrupeRadnika_Click;
            // 
            // btnObjekti
            // 
            btnObjekti.BackColor = Color.Blue;
            btnObjekti.Font = new Font("Showcard Gothic", 20F, FontStyle.Bold);
            btnObjekti.ForeColor = Color.White;
            btnObjekti.Location = new Point(1118, 329);
            btnObjekti.Margin = new Padding(4, 5, 4, 5);
            btnObjekti.Name = "btnObjekti";
            btnObjekti.Size = new Size(281, 63);
            btnObjekti.TabIndex = 6;
            btnObjekti.Text = "Objekti";
            btnObjekti.UseVisualStyleBackColor = false;
            btnObjekti.Click += btnObjekti_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Blue;
            button1.Font = new Font("Showcard Gothic", 20F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1118, 432);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(281, 62);
            button1.TabIndex = 7;
            button1.Text = "Zastite";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Pocetna
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(1924, 1170);
            Controls.Add(button1);
            Controls.Add(btnObjekti);
            Controls.Add(btnGrupeRadnika);
            Controls.Add(btnRadnici);
            Controls.Add(btnTravnjaci);
            Controls.Add(btnDrvoredi);
            Controls.Add(btnParkovi);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Pocetna";
            Text = "Pocetna";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnParkovi;
        private Button btnDrvoredi;
        private Button btnTravnjaci;
        private Button btnRadnici;
        private Button btnGrupeRadnika;
        private Button btnObjekti;
        private Button button1;
    }
}