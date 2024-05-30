namespace ZelenaPovrsina.Forme
{
    partial class TravnjaciForm
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
            btnDodajTravnjak = new Button();
            btnBrisiTravnjak = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listView1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(507, 612);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lista travnjaka";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(6, 22);
            listView1.Name = "listView1";
            listView1.Size = new Size(495, 584);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Adresa zgrade";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Povrsina";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            // 
            // btnDodajTravnjak
            // 
            btnDodajTravnjak.Location = new Point(561, 78);
            btnDodajTravnjak.Name = "btnDodajTravnjak";
            btnDodajTravnjak.Size = new Size(154, 37);
            btnDodajTravnjak.TabIndex = 1;
            btnDodajTravnjak.Text = "Dodaj travnjak";
            btnDodajTravnjak.UseVisualStyleBackColor = true;
            btnDodajTravnjak.Click += btnDodajTravnjak_Click;
            // 
            // btnBrisiTravnjak
            // 
            btnBrisiTravnjak.Location = new Point(563, 138);
            btnBrisiTravnjak.Name = "btnBrisiTravnjak";
            btnBrisiTravnjak.Size = new Size(173, 40);
            btnBrisiTravnjak.TabIndex = 2;
            btnBrisiTravnjak.Text = "Obrisi travnjak";
            btnBrisiTravnjak.UseVisualStyleBackColor = true;
            // 
            // TravnjaciForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 636);
            Controls.Add(btnBrisiTravnjak);
            Controls.Add(btnDodajTravnjak);
            Controls.Add(groupBox1);
            Name = "TravnjaciForm";
            Text = "TravnjaciForm";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button btnDodajTravnjak;
        private Button btnBrisiTravnjak;
    }
}