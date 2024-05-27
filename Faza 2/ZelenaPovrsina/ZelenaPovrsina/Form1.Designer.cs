namespace ZelenaPovrsina
{
    partial class Form1
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
            this.cmdUcitavanjeRadnika = new System.Windows.Forms.Button();
            this.cmdDodavanjeRadnika = new System.Windows.Forms.Button();
            this.cmdManyToOneRadnikGrupa = new System.Windows.Forms.Button();
            this.cmdOneToManyGrupaRadnik = new System.Windows.Forms.Button();
            this.cmdDodajRadnikaUGrupu = new System.Windows.Forms.Button();
            this.cmdVratiPark = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdUcitavanjeRadnika
            // 
            this.cmdUcitavanjeRadnika.Location = new System.Drawing.Point(12, 12);
            this.cmdUcitavanjeRadnika.Name = "cmdUcitavanjeRadnika";
            this.cmdUcitavanjeRadnika.Size = new System.Drawing.Size(132, 23);
            this.cmdUcitavanjeRadnika.TabIndex = 0;
            this.cmdUcitavanjeRadnika.Text = "Ucitavanje radnika";
            this.cmdUcitavanjeRadnika.UseVisualStyleBackColor = true;
            this.cmdUcitavanjeRadnika.Click += new System.EventHandler(this.cmdUcitavanjeRadnika_Click);
            // 
            // cmdDodavanjeRadnika
            // 
            this.cmdDodavanjeRadnika.Location = new System.Drawing.Point(12, 41);
            this.cmdDodavanjeRadnika.Name = "cmdDodavanjeRadnika";
            this.cmdDodavanjeRadnika.Size = new System.Drawing.Size(132, 23);
            this.cmdDodavanjeRadnika.TabIndex = 1;
            this.cmdDodavanjeRadnika.Text = "Dodaj ili azuriraj radnika";
            this.cmdDodavanjeRadnika.UseVisualStyleBackColor = true;
            this.cmdDodavanjeRadnika.Click += new System.EventHandler(this.cmdDodavanjeRadnika_Click);
            // 
            // cmdManyToOneRadnikGrupa
            // 
            this.cmdManyToOneRadnikGrupa.Location = new System.Drawing.Point(12, 70);
            this.cmdManyToOneRadnikGrupa.Name = "cmdManyToOneRadnikGrupa";
            this.cmdManyToOneRadnikGrupa.Size = new System.Drawing.Size(132, 38);
            this.cmdManyToOneRadnikGrupa.TabIndex = 2;
            this.cmdManyToOneRadnikGrupa.Text = "Veza many-to-one (Radnik-Grupa)";
            this.cmdManyToOneRadnikGrupa.UseVisualStyleBackColor = true;
            this.cmdManyToOneRadnikGrupa.Click += new System.EventHandler(this.cmdManyToOneRadnikGrupa_Click);
            // 
            // cmdOneToManyGrupaRadnik
            // 
            this.cmdOneToManyGrupaRadnik.Location = new System.Drawing.Point(12, 114);
            this.cmdOneToManyGrupaRadnik.Name = "cmdOneToManyGrupaRadnik";
            this.cmdOneToManyGrupaRadnik.Size = new System.Drawing.Size(132, 34);
            this.cmdOneToManyGrupaRadnik.TabIndex = 3;
            this.cmdOneToManyGrupaRadnik.Text = "Veza one-to-many (Grupa-Radnik)";
            this.cmdOneToManyGrupaRadnik.UseVisualStyleBackColor = true;
            this.cmdOneToManyGrupaRadnik.Click += new System.EventHandler(this.cmdOneToManyGrupaRadnik_Click);
            // 
            // cmdDodajRadnikaUGrupu
            // 
            this.cmdDodajRadnikaUGrupu.Location = new System.Drawing.Point(12, 154);
            this.cmdDodajRadnikaUGrupu.Name = "cmdDodajRadnikaUGrupu";
            this.cmdDodajRadnikaUGrupu.Size = new System.Drawing.Size(132, 25);
            this.cmdDodajRadnikaUGrupu.TabIndex = 4;
            this.cmdDodajRadnikaUGrupu.Text = "Dodaj radnika u grupu";
            this.cmdDodajRadnikaUGrupu.UseVisualStyleBackColor = true;
            this.cmdDodajRadnikaUGrupu.Click += new System.EventHandler(this.cmdDodajRadnikaUGrupu_Click);
            // 
            // cmdVratiPark
            // 
            this.cmdVratiPark.Location = new System.Drawing.Point(209, 12);
            this.cmdVratiPark.Name = "cmdVratiPark";
            this.cmdVratiPark.Size = new System.Drawing.Size(174, 32);
            this.cmdVratiPark.TabIndex = 5;
            this.cmdVratiPark.Text = "Vrati park one-to-one (Park-Grupa)";
            this.cmdVratiPark.UseVisualStyleBackColor = true;
            this.cmdVratiPark.Click += new System.EventHandler(this.cmdVratiPark_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(942, 444);
            this.Controls.Add(this.cmdVratiPark);
            this.Controls.Add(this.cmdDodajRadnikaUGrupu);
            this.Controls.Add(this.cmdOneToManyGrupaRadnik);
            this.Controls.Add(this.cmdManyToOneRadnikGrupa);
            this.Controls.Add(this.cmdDodavanjeRadnika);
            this.Controls.Add(this.cmdUcitavanjeRadnika);
            this.Name = "Form1";
            this.Text = "Zelena Povrsina";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdUcitavanjeRadnika;
        private System.Windows.Forms.Button cmdDodavanjeRadnika;
        private System.Windows.Forms.Button cmdManyToOneRadnikGrupa;
        private System.Windows.Forms.Button cmdOneToManyGrupaRadnik;
        private System.Windows.Forms.Button cmdDodajRadnikaUGrupu;
        private System.Windows.Forms.Button cmdVratiPark;
    }
}

