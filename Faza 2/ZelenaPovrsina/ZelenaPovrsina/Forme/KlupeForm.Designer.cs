namespace ZelenaPovrsina.Forme
{
    partial class KlupeForm
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
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            btnDodaj = new Button();
            btnObrisi = new Button();
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
            groupBox1.Location = new Point(10, 22);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(527, 930);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Klupe";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // listView1
            // 
            listView1.BackColor = Color.LightGray;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader2, columnHeader3, columnHeader1, columnHeader4, columnHeader5 });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(4, 35);
            listView1.Margin = new Padding(4, 5, 4, 5);
            listView1.Name = "listView1";
            listView1.Size = new Size(494, 879);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "ID";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Id parka";
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Redni broj";
            columnHeader1.Width = 80;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Tip";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Materijal";
            columnHeader5.Width = 80;
            // 
            // btnDodaj
            // 
            btnDodaj.BackColor = Color.Blue;
            btnDodaj.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold);
            btnDodaj.ForeColor = Color.White;
            btnDodaj.Location = new Point(586, 92);
            btnDodaj.Margin = new Padding(4, 5, 4, 5);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(374, 83);
            btnDodaj.TabIndex = 1;
            btnDodaj.Text = "Dodaj klupu";
            btnDodaj.UseVisualStyleBackColor = false;
            btnDodaj.Click += button1_Click;
            // 
            // btnObrisi
            // 
            btnObrisi.BackColor = Color.Blue;
            btnObrisi.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold);
            btnObrisi.ForeColor = Color.White;
            btnObrisi.Location = new Point(586, 326);
            btnObrisi.Margin = new Padding(4, 5, 4, 5);
            btnObrisi.Name = "btnObrisi";
            btnObrisi.Size = new Size(370, 92);
            btnObrisi.TabIndex = 2;
            btnObrisi.Text = "Obrisi klupu";
            btnObrisi.UseVisualStyleBackColor = false;
            btnObrisi.Click += button2_Click;
            // 
            // btnIzmeni
            // 
            btnIzmeni.BackColor = Color.Blue;
            btnIzmeni.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold);
            btnIzmeni.ForeColor = Color.White;
            btnIzmeni.Location = new Point(586, 210);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(370, 88);
            btnIzmeni.TabIndex = 3;
            btnIzmeni.Text = "Izmeni";
            btnIzmeni.UseVisualStyleBackColor = false;
            btnIzmeni.Click += btnIzmeni_Click;
            // 
            // KlupeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(1226, 1007);
            Controls.Add(btnIzmeni);
            Controls.Add(btnObrisi);
            Controls.Add(btnDodaj);
            Controls.Add(groupBox1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "KlupeForm";
            Text = "Klupe";
            Load += KlupeForm_Load;
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
        private Button btnDodaj;
        private Button btnObrisi;
        private Button btnIzmeni;
    }
}