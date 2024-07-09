namespace ZelenaPovrsina.Forme
{
    partial class DecijaIgralistaForm
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
            btnIzmeni = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.Blue;
            button2.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(278, 342);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(370, 92);
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
            button1.Location = new Point(274, 131);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(374, 83);
            button1.TabIndex = 4;
            button1.Text = "Dodaj";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(listView1);
            groupBox1.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Blue;
            groupBox1.Location = new Point(766, 20);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(714, 930);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Decija igralista";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // listView1
            // 
            listView1.BackColor = Color.LightGray;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader2, columnHeader3, columnHeader1, columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(0, 33);
            listView1.Margin = new Padding(4, 5, 4, 5);
            listView1.Name = "listView1";
            listView1.Size = new Size(647, 805);
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
            columnHeader5.Text = "Broj igracaka";
            columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Pesak";
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Starost";
            // 
            // btnIzmeni
            // 
            btnIzmeni.BackColor = Color.Blue;
            btnIzmeni.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold);
            btnIzmeni.ForeColor = Color.White;
            btnIzmeni.Location = new Point(274, 234);
            btnIzmeni.Margin = new Padding(4, 5, 4, 5);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(374, 83);
            btnIzmeni.TabIndex = 7;
            btnIzmeni.Text = "Izmeni";
            btnIzmeni.UseVisualStyleBackColor = false;
            btnIzmeni.Click += btnIzmeni_Click;
            // 
            // DecijaIgralistaForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(1541, 997);
            Controls.Add(btnIzmeni);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "DecijaIgralistaForm";
            Text = "Decija igralista";
            Load += DecijaIgralistaForm_Load;
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
        private Button btnIzmeni;
    }
}