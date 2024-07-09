namespace ZelenaPovrsina.Forme
{
    partial class SkulptureForm
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
            button3 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.Blue;
            button2.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(714, 300);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(370, 92);
            button2.TabIndex = 5;
            button2.Text = "obrisi";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Blue;
            button1.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(714, 55);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(374, 83);
            button1.TabIndex = 4;
            button1.Text = "dodaj";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Blue;
            groupBox1.Controls.Add(listView1);
            groupBox1.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(17, 20);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(603, 930);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Skulpture";
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
            listView1.Size = new Size(573, 879);
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
            columnHeader5.Text = "Autor";
            columnHeader5.Width = 130;
            // 
            // button3
            // 
            button3.BackColor = Color.Blue;
            button3.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(714, 177);
            button3.Margin = new Padding(4, 5, 4, 5);
            button3.Name = "button3";
            button3.Size = new Size(374, 83);
            button3.TabIndex = 6;
            button3.Text = "izmeni";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // SkulptureForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(1237, 958);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "SkulptureForm";
            Text = "Skulpture";
            Load += SkulptureForm_Load;
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
        private Button button3;
    }
}