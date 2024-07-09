namespace ZelenaPovrsina.Forme
{
    partial class ZelenePovrsineForm
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
            button4 = new Button();
            button5 = new Button();
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
            groupBox1.Size = new Size(537, 1067);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lista zelenih povrsina";
            // 
            // listView1
            // 
            listView1.BackColor = Color.LightGray;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(9, 37);
            listView1.Margin = new Padding(4, 5, 4, 5);
            listView1.Name = "listView1";
            listView1.Size = new Size(508, 1017);
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
            columnHeader2.Text = "Gradska opstina";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Zona ugrozenosti";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 110;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Tip";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 80;
            // 
            // button4
            // 
            button4.BackColor = Color.Blue;
            button4.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold);
            button4.ForeColor = Color.White;
            button4.Location = new Point(697, 57);
            button4.Margin = new Padding(4, 5, 4, 5);
            button4.Name = "button4";
            button4.Size = new Size(230, 80);
            button4.TabIndex = 4;
            button4.Text = "Dodaj";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Blue;
            button5.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold);
            button5.ForeColor = Color.White;
            button5.Location = new Point(697, 165);
            button5.Margin = new Padding(4, 5, 4, 5);
            button5.Name = "button5";
            button5.Size = new Size(230, 80);
            button5.TabIndex = 5;
            button5.Text = "Obrisi";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // ZelenePovrsineForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(1034, 1062);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(groupBox1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "ZelenePovrsineForm";
            Text = "ZELENE POVRSINE";
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
        private Button button4;
        private Button button5;
    }
}