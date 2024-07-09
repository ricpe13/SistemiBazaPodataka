namespace ZelenaPovrsina.Forme
{
    partial class IzmeniDrvoForm
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
            txtObim = new TextBox();
            txtPovrsina = new TextBox();
            label8 = new Label();
            label7 = new Label();
            txtVisina = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnIzmeni = new Button();
            SuspendLayout();
            // 
            // txtObim
            // 
            txtObim.Location = new Point(277, 171);
            txtObim.Name = "txtObim";
            txtObim.Size = new Size(150, 31);
            txtObim.TabIndex = 37;
            // 
            // txtPovrsina
            // 
            txtPovrsina.Location = new Point(277, 123);
            txtPovrsina.Name = "txtPovrsina";
            txtPovrsina.Size = new Size(150, 31);
            txtPovrsina.TabIndex = 36;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Blue;
            label8.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(136, 127);
            label8.Name = "label8";
            label8.Size = new Size(104, 23);
            label8.TabIndex = 35;
            label8.Text = "Povrsina";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Blue;
            label7.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(138, 175);
            label7.Name = "label7";
            label7.Size = new Size(60, 23);
            label7.TabIndex = 34;
            label7.Text = "Obim";
            // 
            // txtVisina
            // 
            txtVisina.Location = new Point(277, 77);
            txtVisina.Name = "txtVisina";
            txtVisina.Size = new Size(150, 31);
            txtVisina.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Blue;
            label2.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(136, 81);
            label2.Name = "label2";
            label2.Size = new Size(71, 23);
            label2.TabIndex = 24;
            label2.Text = "Visina";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Blue;
            label1.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(287, 28);
            label1.Name = "label1";
            label1.Size = new Size(134, 23);
            label1.TabIndex = 23;
            label1.Text = "Izmeni drvo";
            // 
            // btnIzmeni
            // 
            btnIzmeni.BackColor = Color.White;
            btnIzmeni.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIzmeni.ForeColor = Color.Blue;
            btnIzmeni.Location = new Point(553, 388);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(112, 34);
            btnIzmeni.TabIndex = 22;
            btnIzmeni.Text = "Izmeni";
            btnIzmeni.UseVisualStyleBackColor = false;
            btnIzmeni.Click += btnIzmeni_Click;
            // 
            // IzmeniDrvoForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(800, 450);
            Controls.Add(txtObim);
            Controls.Add(txtPovrsina);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtVisina);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnIzmeni);
            Name = "IzmeniDrvoForm";
            Text = "IzmeniDrvoForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtObim;
        private TextBox txtPovrsina;
        private Label label8;
        private Label label7;
        private TextBox txtVisina;
        private Label label2;
        private Label label1;
        private Button btnIzmeni;
    }
}