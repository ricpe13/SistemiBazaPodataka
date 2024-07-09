namespace ZelenaPovrsina.Forme
{
    partial class ParkoviForm
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
            button1 = new Button();
            btnObrisiPark = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Blue;
            groupBox1.Controls.Add(listView1);
            groupBox1.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(347, 593);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lista parkova";
            // 
            // listView1
            // 
            listView1.BackColor = Color.LightGray;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(6, 20);
            listView1.Name = "listView1";
            listView1.Size = new Size(352, 567);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Naziv";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Povrsina";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 70;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Broj objekata";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 100;
            // 
            // button1
            // 
            button1.BackColor = Color.Blue;
            button1.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(398, 59);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(95, 29);
            button1.TabIndex = 1;
            button1.Text = "Dodaj";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnObrisiPark
            // 
            btnObrisiPark.BackColor = Color.Blue;
            btnObrisiPark.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold);
            btnObrisiPark.ForeColor = Color.White;
            btnObrisiPark.Location = new Point(398, 125);
            btnObrisiPark.Name = "btnObrisiPark";
            btnObrisiPark.Size = new Size(95, 28);
            btnObrisiPark.TabIndex = 2;
            btnObrisiPark.Text = "Obrisi";
            btnObrisiPark.UseVisualStyleBackColor = false;
            btnObrisiPark.Click += btnObrisiPark_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Blue;
            button2.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(398, 91);
            button2.Margin = new Padding(2, 2, 2, 2);
            button2.Name = "button2";
            button2.Size = new Size(95, 29);
            button2.TabIndex = 3;
            button2.Text = "Izmeni";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // ParkoviForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(810, 629);
            Controls.Add(button2);
            Controls.Add(btnObrisiPark);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Name = "ParkoviForm";
            Text = "PARKOVI";
            Load += ParkoviForm_Load_1;
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
        private Button button1;
        private Button btnObrisiPark;
        private Button button2;
    }
}