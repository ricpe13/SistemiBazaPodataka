namespace ZelenaPovrsina.Forme
{
    partial class DrveceForm
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
            button2 = new Button();
            button1 = new Button();
            groupBox1 = new GroupBox();
            listView1 = new ListView();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            button4 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.Blue;
            button2.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(1194, 377);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(240, 92);
            button2.TabIndex = 5;
            button2.Text = "Obrisi";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Blue;
            button1.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1194, 128);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(244, 83);
            button1.TabIndex = 4;
            button1.Text = "Dodaj";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Blue;
            groupBox1.Controls.Add(listView1);
            groupBox1.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(40, 33);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(1055, 917);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Drvece";
            // 
            // listView1
            // 
            listView1.BackColor = Color.LightGray;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader2, columnHeader3, columnHeader1, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9 });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(8, 33);
            listView1.Margin = new Padding(4, 5, 4, 5);
            listView1.Name = "listView1";
            listView1.Size = new Size(1038, 879);
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
            columnHeader5.Text = "Visina krosnje";
            columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Vrsta";
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Datum sadnje";
            columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Povrsina krosnje";
            columnHeader8.Width = 100;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Obim debla";
            columnHeader9.Width = 100;
            // 
            // button4
            // 
            button4.BackColor = Color.Blue;
            button4.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold);
            button4.ForeColor = Color.White;
            button4.Location = new Point(1194, 247);
            button4.Margin = new Padding(4, 5, 4, 5);
            button4.Name = "button4";
            button4.Size = new Size(244, 83);
            button4.TabIndex = 7;
            button4.Text = "Izmeni";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // DrveceForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(1579, 1017);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "DrveceForm";
            Text = "Drvece";
            Load += DrveceForm_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button2;
        private Button button1;
        private GroupBox groupBox1;
        private ListView listView1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private Button button4;
    }
}