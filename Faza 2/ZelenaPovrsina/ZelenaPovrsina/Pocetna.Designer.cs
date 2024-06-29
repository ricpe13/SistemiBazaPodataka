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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 40F);
            label1.Location = new Point(215, 9);
            label1.Name = "label1";
            label1.Size = new Size(404, 72);
            label1.TabIndex = 0;
            label1.Text = "Zelene Povrsine";
            // 
            // btnParkovi
            // 
            btnParkovi.Font = new Font("Segoe UI", 20F);
            btnParkovi.Location = new Point(286, 146);
            btnParkovi.Name = "btnParkovi";
            btnParkovi.Size = new Size(250, 52);
            btnParkovi.TabIndex = 1;
            btnParkovi.Text = "Parkovi";
            btnParkovi.UseVisualStyleBackColor = true;
            btnParkovi.Click += btnParkovi_Click;
            // 
            // btnDrvoredi
            // 
            btnDrvoredi.Font = new Font("Segoe UI", 20F);
            btnDrvoredi.Location = new Point(12, 146);
            btnDrvoredi.Name = "btnDrvoredi";
            btnDrvoredi.Size = new Size(250, 52);
            btnDrvoredi.TabIndex = 2;
            btnDrvoredi.Text = "Drvoredi";
            btnDrvoredi.UseVisualStyleBackColor = true;
            btnDrvoredi.Click += btnDrvoredi_Click;
            // 
            // btnTravnjaci
            // 
            btnTravnjaci.Font = new Font("Segoe UI", 20F);
            btnTravnjaci.Location = new Point(554, 146);
            btnTravnjaci.Name = "btnTravnjaci";
            btnTravnjaci.Size = new Size(250, 52);
            btnTravnjaci.TabIndex = 3;
            btnTravnjaci.Text = "Travnjaci";
            btnTravnjaci.UseVisualStyleBackColor = true;
            btnTravnjaci.Click += btnTravnjaci_Click;
            // 
            // btnRadnici
            // 
            btnRadnici.Font = new Font("Segoe UI", 20F);
            btnRadnici.Location = new Point(12, 263);
            btnRadnici.Name = "btnRadnici";
            btnRadnici.Size = new Size(250, 52);
            btnRadnici.TabIndex = 4;
            btnRadnici.Text = "Radnici";
            btnRadnici.UseVisualStyleBackColor = true;
            btnRadnici.Click += btnRadnici_Click;
            // 
            // btnGrupeRadnika
            // 
            btnGrupeRadnika.Font = new Font("Segoe UI", 20F);
            btnGrupeRadnika.Location = new Point(286, 263);
            btnGrupeRadnika.Name = "btnGrupeRadnika";
            btnGrupeRadnika.Size = new Size(250, 52);
            btnGrupeRadnika.TabIndex = 5;
            btnGrupeRadnika.Text = "Grupe radnika";
            btnGrupeRadnika.UseVisualStyleBackColor = true;
            btnGrupeRadnika.Click += btnGrupeRadnika_Click;
            // 
            // btnObjekti
            // 
            btnObjekti.Font = new Font("Segoe UI", 20F);
            btnObjekti.Location = new Point(554, 263);
            btnObjekti.Name = "btnObjekti";
            btnObjekti.Size = new Size(256, 52);
            btnObjekti.TabIndex = 6;
            btnObjekti.Text = "Objekti";
            btnObjekti.UseVisualStyleBackColor = true;
            btnObjekti.Click += btnObjekti_Click;
            // 
            // Pocetna
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 557);
            Controls.Add(btnObjekti);
            Controls.Add(btnGrupeRadnika);
            Controls.Add(btnRadnici);
            Controls.Add(btnTravnjaci);
            Controls.Add(btnDrvoredi);
            Controls.Add(btnParkovi);
            Controls.Add(label1);
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
    }
}