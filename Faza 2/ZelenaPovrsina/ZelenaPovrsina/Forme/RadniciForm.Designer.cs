namespace ZelenaPovrsina.Forme
{
    partial class RadniciForm
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
            groupBox1 = new GroupBox();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            columnHeader13 = new ColumnHeader();
            columnHeader14 = new ColumnHeader();
            button2 = new Button();
            btnDodajRadnika = new Button();
            btnIzmeni = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Blue;
            groupBox1.Controls.Add(listView1);
            groupBox1.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1203, 565);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lista radnika";
            // 
            // listView1
            // 
            listView1.BackColor = Color.LightGray;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9, columnHeader10, columnHeader11, columnHeader12, columnHeader13, columnHeader14 });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(6, 18);
            listView1.Name = "listView1";
            listView1.Size = new Size(1272, 566);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Ime";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Prezime";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Jmbg";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Adresa";
            columnHeader5.TextAlign = HorizontalAlignment.Center;
            columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Broj radne knjizice";
            columnHeader6.TextAlign = HorizontalAlignment.Center;
            columnHeader6.Width = 110;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Ime roditelja";
            columnHeader7.TextAlign = HorizontalAlignment.Center;
            columnHeader7.Width = 80;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Strucna sprema";
            columnHeader8.TextAlign = HorizontalAlignment.Center;
            columnHeader8.Width = 100;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Datum rodjenja";
            columnHeader9.TextAlign = HorizontalAlignment.Center;
            columnHeader9.Width = 100;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Za zelenilo";
            columnHeader10.TextAlign = HorizontalAlignment.Center;
            columnHeader10.Width = 70;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Za higijenu";
            columnHeader11.TextAlign = HorizontalAlignment.Center;
            columnHeader11.Width = 80;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "Za objekat";
            columnHeader12.TextAlign = HorizontalAlignment.Center;
            columnHeader12.Width = 70;
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "ID zelene povrsine";
            columnHeader13.TextAlign = HorizontalAlignment.Center;
            columnHeader13.Width = 110;
            // 
            // columnHeader14
            // 
            columnHeader14.Text = "ID grupe";
            columnHeader14.TextAlign = HorizontalAlignment.Center;
            // 
            // button2
            // 
            button2.BackColor = Color.Blue;
            button2.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(1367, 386);
            button2.Name = "button2";
            button2.Size = new Size(102, 30);
            button2.TabIndex = 2;
            button2.Text = "Obrisi ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnDodajRadnika
            // 
            btnDodajRadnika.BackColor = Color.Blue;
            btnDodajRadnika.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold);
            btnDodajRadnika.ForeColor = Color.White;
            btnDodajRadnika.Location = new Point(1367, 349);
            btnDodajRadnika.Name = "btnDodajRadnika";
            btnDodajRadnika.Size = new Size(102, 31);
            btnDodajRadnika.TabIndex = 3;
            btnDodajRadnika.Text = "Dodaj ";
            btnDodajRadnika.UseVisualStyleBackColor = false;
            btnDodajRadnika.Click += btnDodajRadnika_Click;
            // 
            // btnIzmeni
            // 
            btnIzmeni.BackColor = Color.Blue;
            btnIzmeni.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold);
            btnIzmeni.ForeColor = Color.White;
            btnIzmeni.Location = new Point(1367, 421);
            btnIzmeni.Margin = new Padding(2, 2, 2, 2);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(102, 31);
            btnIzmeni.TabIndex = 1;
            btnIzmeni.Text = "Izmeni";
            btnIzmeni.UseVisualStyleBackColor = false;
            btnIzmeni.Click += button1_Click;
            // 
            // RadniciForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(1503, 618);
            Controls.Add(btnIzmeni);
            Controls.Add(btnDodajRadnika);
            Controls.Add(button2);
            Controls.Add(groupBox1);
            Name = "RadniciForm";
            Text = "RADNICI";
            Load += RadniciForm_Load_1;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private Button button2;
        private Button btnDodajRadnika;
        private Button btnIzmeni;
    }
}