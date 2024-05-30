namespace ZelenaPovrsina.Forme
{
    partial class DodajRanikaForma
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
            textBoxIme = new TextBox();
            textBoxPrezime = new TextBox();
            textBoxRod = new TextBox();
            textBoxHig = new TextBox();
            textBoxStrucnaSprema = new TextBox();
            textBoxObj = new TextBox();
            textBoxZel = new TextBox();
            textBoxBrRad = new TextBox();
            textBoxJMBG = new TextBox();
            textBoxAdresa = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            datumRodjenja = new DateTimePicker();
            textBoxZP = new TextBox();
            label12 = new Label();
            SuspendLayout();
            // 
            // cmdUcitavanjeRadnika
            // 
            cmdUcitavanjeRadnika.BackColor = Color.FromArgb(255, 128, 0);
            cmdUcitavanjeRadnika.Location = new Point(372, 224);
            cmdUcitavanjeRadnika.Margin = new Padding(2);
            cmdUcitavanjeRadnika.Name = "cmdUcitavanjeRadnika";
            cmdUcitavanjeRadnika.Size = new Size(78, 20);
            cmdUcitavanjeRadnika.TabIndex = 0;
            cmdUcitavanjeRadnika.Text = "DODAJ";
            cmdUcitavanjeRadnika.UseVisualStyleBackColor = false;
            cmdUcitavanjeRadnika.Click += button1_Click;
            // 
            // textBoxIme
            // 
            textBoxIme.Location = new Point(177, 5);
            textBoxIme.Margin = new Padding(2);
            textBoxIme.Name = "textBoxIme";
            textBoxIme.Size = new Size(106, 23);
            textBoxIme.TabIndex = 1;
            // 
            // textBoxPrezime
            // 
            textBoxPrezime.Location = new Point(177, 28);
            textBoxPrezime.Margin = new Padding(2);
            textBoxPrezime.Name = "textBoxPrezime";
            textBoxPrezime.Size = new Size(106, 23);
            textBoxPrezime.TabIndex = 2;
            // 
            // textBoxRod
            // 
            textBoxRod.Location = new Point(177, 118);
            textBoxRod.Margin = new Padding(2);
            textBoxRod.Name = "textBoxRod";
            textBoxRod.Size = new Size(106, 23);
            textBoxRod.TabIndex = 3;
            // 
            // textBoxHig
            // 
            textBoxHig.Location = new Point(177, 185);
            textBoxHig.Margin = new Padding(2);
            textBoxHig.Name = "textBoxHig";
            textBoxHig.Size = new Size(106, 23);
            textBoxHig.TabIndex = 4;
            // 
            // textBoxStrucnaSprema
            // 
            textBoxStrucnaSprema.Location = new Point(177, 140);
            textBoxStrucnaSprema.Margin = new Padding(2);
            textBoxStrucnaSprema.Name = "textBoxStrucnaSprema";
            textBoxStrucnaSprema.Size = new Size(106, 23);
            textBoxStrucnaSprema.TabIndex = 6;
            // 
            // textBoxObj
            // 
            textBoxObj.Location = new Point(177, 229);
            textBoxObj.Margin = new Padding(2);
            textBoxObj.Name = "textBoxObj";
            textBoxObj.Size = new Size(106, 23);
            textBoxObj.TabIndex = 7;
            // 
            // textBoxZel
            // 
            textBoxZel.Location = new Point(177, 207);
            textBoxZel.Margin = new Padding(2);
            textBoxZel.Name = "textBoxZel";
            textBoxZel.Size = new Size(106, 23);
            textBoxZel.TabIndex = 8;
            // 
            // textBoxBrRad
            // 
            textBoxBrRad.Location = new Point(177, 96);
            textBoxBrRad.Margin = new Padding(2);
            textBoxBrRad.Name = "textBoxBrRad";
            textBoxBrRad.Size = new Size(106, 23);
            textBoxBrRad.TabIndex = 9;
            // 
            // textBoxJMBG
            // 
            textBoxJMBG.Location = new Point(177, 50);
            textBoxJMBG.Margin = new Padding(2);
            textBoxJMBG.Name = "textBoxJMBG";
            textBoxJMBG.Size = new Size(106, 23);
            textBoxJMBG.TabIndex = 10;
            // 
            // textBoxAdresa
            // 
            textBoxAdresa.Location = new Point(177, 72);
            textBoxAdresa.Margin = new Padding(2);
            textBoxAdresa.Name = "textBoxAdresa";
            textBoxAdresa.Size = new Size(106, 23);
            textBoxAdresa.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 9);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 12;
            label1.Text = "Ime";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 31);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 13;
            label2.Text = "Prezime";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 53);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 14;
            label3.Text = "JMBG";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(62, 76);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 15;
            label4.Text = "Adresa";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(62, 98);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(103, 15);
            label5.TabIndex = 16;
            label5.Text = "Broj radne knjizice";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(62, 122);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(73, 15);
            label6.TabIndex = 17;
            label6.Text = "Ime roditelja";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(61, 144);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(89, 15);
            label7.TabIndex = 18;
            label7.Text = "Strucna sprema";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(62, 164);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(89, 15);
            label8.TabIndex = 19;
            label8.Text = "Datum rodjenja";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(62, 187);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(66, 15);
            label9.TabIndex = 20;
            label9.Text = "Za higijenu";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(62, 209);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(63, 15);
            label10.TabIndex = 21;
            label10.Text = "Za zelenilo";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(61, 231);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(62, 15);
            label11.TabIndex = 22;
            label11.Text = "Za objekat";
            // 
            // datumRodjenja
            // 
            datumRodjenja.Location = new Point(177, 164);
            datumRodjenja.Margin = new Padding(2);
            datumRodjenja.Name = "datumRodjenja";
            datumRodjenja.Size = new Size(238, 23);
            datumRodjenja.TabIndex = 23;
            datumRodjenja.Value = new DateTime(2024, 5, 30, 1, 59, 10, 0);
            // 
            // textBoxZP
            // 
            textBoxZP.Location = new Point(177, 266);
            textBoxZP.Name = "textBoxZP";
            textBoxZP.Size = new Size(101, 23);
            textBoxZP.TabIndex = 24;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(67, 269);
            label12.Name = "label12";
            label12.Size = new Size(104, 15);
            label12.TabIndex = 25;
            label12.Text = "Zelena povrsina ID";
            // 
            // DodajRanikaForma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 314);
            Controls.Add(label12);
            Controls.Add(textBoxZP);
            Controls.Add(datumRodjenja);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxAdresa);
            Controls.Add(textBoxJMBG);
            Controls.Add(textBoxBrRad);
            Controls.Add(textBoxZel);
            Controls.Add(textBoxObj);
            Controls.Add(textBoxStrucnaSprema);
            Controls.Add(textBoxHig);
            Controls.Add(textBoxRod);
            Controls.Add(textBoxPrezime);
            Controls.Add(textBoxIme);
            Controls.Add(cmdUcitavanjeRadnika);
            Margin = new Padding(2);
            Name = "DodajRanikaForma";
            Text = "Dodaj radnika";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cmdUcitavanjeRadnika;
        private TextBox textBoxIme;
        private TextBox textBoxPrezime;
        private TextBox textBoxRod;
        private TextBox textBoxHig;
        private TextBox textBoxStrucnaSprema;
        private TextBox textBoxObj;
        private TextBox textBoxZel;
        private TextBox textBoxBrRad;
        private TextBox textBoxJMBG;
        private TextBox textBoxAdresa;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private DateTimePicker datumRodjenja;
        private TextBox textBoxZP;
        private Label label12;
    }
}