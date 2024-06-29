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
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listView1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(496, 528);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Zastite";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(6, 22);
            listView1.Name = "listView1";
            listView1.Size = new Size(469, 482);
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
            btnDodajZastitu.Location = new Point(538, 45);
            btnDodajZastitu.Name = "btnDodajZastitu";
            btnDodajZastitu.Size = new Size(212, 46);
            btnDodajZastitu.TabIndex = 1;
            btnDodajZastitu.Text = "Dodaj zastitu";
            btnDodajZastitu.UseVisualStyleBackColor = true;
            // 
            // btnObrisiZastitu
            // 
            btnObrisiZastitu.Location = new Point(538, 116);
            btnObrisiZastitu.Name = "btnObrisiZastitu";
            btnObrisiZastitu.Size = new Size(212, 44);
            btnObrisiZastitu.TabIndex = 2;
            btnObrisiZastitu.Text = "Obrisi zastitu";
            btnObrisiZastitu.UseVisualStyleBackColor = true;
            // 
            // ZastiteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(948, 552);
            Controls.Add(btnObrisiZastitu);
            Controls.Add(btnDodajZastitu);
            Controls.Add(groupBox1);
            Name = "ZastiteForm";
            Text = "Zastite";
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
    }
}