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
            cmdUcitavanjeRadnika = new Button();
            cmdDodavanjeRadnika = new Button();
            cmdManyToOneRadnikGrupa = new Button();
            cmdOneToManyGrupaRadnik = new Button();
            cmdDodajRadnikaUGrupu = new Button();
            cmdVratiPark = new Button();
            SuspendLayout();
            // 
            // cmdUcitavanjeRadnika
            // 
            cmdUcitavanjeRadnika.Location = new Point(12, 12);
            cmdUcitavanjeRadnika.Name = "cmdUcitavanjeRadnika";
            cmdUcitavanjeRadnika.Size = new Size(132, 23);
            cmdUcitavanjeRadnika.TabIndex = 0;
            cmdUcitavanjeRadnika.Text = "Ucitavanje radnika";
            cmdUcitavanjeRadnika.UseVisualStyleBackColor = true;
            cmdUcitavanjeRadnika.Click += cmdUcitavanjeRadnika_Click;
            // 
            // cmdDodavanjeRadnika
            // 
            cmdDodavanjeRadnika.Location = new Point(12, 41);
            cmdDodavanjeRadnika.Name = "cmdDodavanjeRadnika";
            cmdDodavanjeRadnika.Size = new Size(132, 23);
            cmdDodavanjeRadnika.TabIndex = 1;
            cmdDodavanjeRadnika.Text = "Dodaj ili azuriraj radnika";
            cmdDodavanjeRadnika.UseVisualStyleBackColor = true;
            cmdDodavanjeRadnika.Click += cmdDodavanjeRadnika_Click;
            // 
            // cmdManyToOneRadnikGrupa
            // 
            cmdManyToOneRadnikGrupa.Location = new Point(12, 70);
            cmdManyToOneRadnikGrupa.Name = "cmdManyToOneRadnikGrupa";
            cmdManyToOneRadnikGrupa.Size = new Size(132, 38);
            cmdManyToOneRadnikGrupa.TabIndex = 2;
            cmdManyToOneRadnikGrupa.Text = "Veza many-to-one (Radnik-Grupa)";
            cmdManyToOneRadnikGrupa.UseVisualStyleBackColor = true;
            cmdManyToOneRadnikGrupa.Click += cmdManyToOneRadnikGrupa_Click;
            // 
            // cmdOneToManyGrupaRadnik
            // 
            cmdOneToManyGrupaRadnik.Location = new Point(12, 114);
            cmdOneToManyGrupaRadnik.Name = "cmdOneToManyGrupaRadnik";
            cmdOneToManyGrupaRadnik.Size = new Size(132, 45);
            cmdOneToManyGrupaRadnik.TabIndex = 3;
            cmdOneToManyGrupaRadnik.Text = "Veza one-to-many (Grupa-Radnik)";
            cmdOneToManyGrupaRadnik.UseVisualStyleBackColor = true;
            cmdOneToManyGrupaRadnik.Click += cmdOneToManyGrupaRadnik_Click;
            // 
            // cmdDodajRadnikaUGrupu
            // 
            cmdDodajRadnikaUGrupu.Location = new Point(12, 165);
            cmdDodajRadnikaUGrupu.Name = "cmdDodajRadnikaUGrupu";
            cmdDodajRadnikaUGrupu.Size = new Size(132, 25);
            cmdDodajRadnikaUGrupu.TabIndex = 4;
            cmdDodajRadnikaUGrupu.Text = "Dodaj radnika u grupu";
            cmdDodajRadnikaUGrupu.UseVisualStyleBackColor = true;
            cmdDodajRadnikaUGrupu.Click += cmdDodajRadnikaUGrupu_Click;
            // 
            // cmdVratiPark
            // 
            cmdVratiPark.Location = new Point(209, 12);
            cmdVratiPark.Name = "cmdVratiPark";
            cmdVratiPark.Size = new Size(174, 32);
            cmdVratiPark.TabIndex = 5;
            cmdVratiPark.Text = "Vrati park one-to-one (Park-Grupa)";
            cmdVratiPark.UseVisualStyleBackColor = true;
            cmdVratiPark.Click += cmdVratiPark_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(942, 444);
            Controls.Add(cmdVratiPark);
            Controls.Add(cmdDodajRadnikaUGrupu);
            Controls.Add(cmdOneToManyGrupaRadnik);
            Controls.Add(cmdManyToOneRadnikGrupa);
            Controls.Add(cmdDodavanjeRadnika);
            Controls.Add(cmdUcitavanjeRadnika);
            Name = "Form1";
            Text = "Zelena Povrsina";
            ResumeLayout(false);
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

