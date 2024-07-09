namespace ZelenaPovrsina.Forme
{
    partial class ZastiteForm
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
            btnDodajZastitu = new Button();
            btnObrisiZastitu = new Button();
            btnIzmeni = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Blue;
            groupBox1.Controls.Add(listView1);
            groupBox1.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(17, 20);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(709, 880);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Zastite";
            // 
            // listView1
            // 
            listView1.BackColor = Color.LightGray;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(9, 37);
            listView1.Margin = new Padding(4, 5, 4, 5);
            listView1.Name = "listView1";
            listView1.Size = new Size(668, 801);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID zastite";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Institucija";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Datum";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Novcana sredstva";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Znacaj";
            columnHeader5.TextAlign = HorizontalAlignment.Center;
            columnHeader5.Width = 120;
            // 
            // btnDodajZastitu
            // 
            btnDodajZastitu.BackColor = Color.Blue;
            btnDodajZastitu.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold);
            btnDodajZastitu.ForeColor = Color.White;
            btnDodajZastitu.Location = new Point(769, 75);
            btnDodajZastitu.Margin = new Padding(4, 5, 4, 5);
            btnDodajZastitu.Name = "btnDodajZastitu";
            btnDodajZastitu.Size = new Size(303, 77);
            btnDodajZastitu.TabIndex = 1;
            btnDodajZastitu.Text = "Dodaj";
            btnDodajZastitu.UseVisualStyleBackColor = false;
            btnDodajZastitu.Click += btnDodajZastitu_Click;
            // 
            // btnObrisiZastitu
            // 
            btnObrisiZastitu.BackColor = Color.Blue;
            btnObrisiZastitu.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold);
            btnObrisiZastitu.ForeColor = Color.White;
            btnObrisiZastitu.Location = new Point(769, 291);
            btnObrisiZastitu.Margin = new Padding(4, 5, 4, 5);
            btnObrisiZastitu.Name = "btnObrisiZastitu";
            btnObrisiZastitu.Size = new Size(303, 73);
            btnObrisiZastitu.TabIndex = 2;
            btnObrisiZastitu.Text = "Obrisi";
            btnObrisiZastitu.UseVisualStyleBackColor = false;
            btnObrisiZastitu.Click += btnObrisiZastitu_Click;
            // 
            // btnIzmeni
            // 
            btnIzmeni.BackColor = Color.Blue;
            btnIzmeni.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold);
            btnIzmeni.ForeColor = Color.White;
            btnIzmeni.Location = new Point(769, 185);
            btnIzmeni.Margin = new Padding(4, 5, 4, 5);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(303, 77);
            btnIzmeni.TabIndex = 3;
            btnIzmeni.Text = "Izmeni";
            btnIzmeni.UseVisualStyleBackColor = false;
            // 
            // ZastiteForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(1354, 920);
            Controls.Add(btnIzmeni);
            Controls.Add(btnObrisiZastitu);
            Controls.Add(btnDodajZastitu);
            Controls.Add(groupBox1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "ZastiteForm";
            Text = "Zastite";
            Load += ZastiteForm_Load;
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
        private Button btnDodajZastitu;
        private Button btnObrisiZastitu;
        private Button btnIzmeni;
    }
}