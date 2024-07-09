namespace ZelenaPovrsina.Forme
{
    partial class GrupeRadnikaForm
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
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
            groupBox1.Size = new Size(172, 599);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lista grupa radnika";
            // 
            // listView1
            // 
            listView1.BackColor = Color.LightGray;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(6, 22);
            listView1.Name = "listView1";
            listView1.Size = new Size(146, 571);
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
            columnHeader2.Text = "Naziv";
            columnHeader2.TextAlign = HorizontalAlignment.Center;
            columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "ID parka";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.BackColor = Color.Blue;
            button1.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(300, 51);
            button1.Name = "button1";
            button1.Size = new Size(152, 32);
            button1.TabIndex = 1;
            button1.Text = "Dodaj";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Blue;
            button2.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(300, 127);
            button2.Name = "button2";
            button2.Size = new Size(152, 32);
            button2.TabIndex = 2;
            button2.Text = "Obrisi";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Blue;
            button3.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(300, 164);
            button3.Name = "button3";
            button3.Size = new Size(152, 29);
            button3.TabIndex = 3;
            button3.Text = "Sefovi";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Blue;
            button4.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold);
            button4.ForeColor = Color.White;
            button4.Location = new Point(300, 89);
            button4.Name = "button4";
            button4.Size = new Size(152, 31);
            button4.TabIndex = 4;
            button4.Text = "Izmeni";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // GrupeRadnikaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(484, 623);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Name = "GrupeRadnikaForm";
            Text = "Grupe radnika";
            Load += GrupeRadnikaForm_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}