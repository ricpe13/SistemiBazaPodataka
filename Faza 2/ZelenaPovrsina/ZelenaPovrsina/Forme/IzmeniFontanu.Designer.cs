namespace ZelenaPovrsina.Forme
{
    partial class IzmeniFontanu
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
            txtPov = new TextBox();
            label4 = new Label();
            txtBrPrs = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnDodaj = new Button();
            SuspendLayout();
            // 
            // txtPov
            // 
            txtPov.Location = new Point(415, 191);
            txtPov.Name = "txtPov";
            txtPov.Size = new Size(150, 31);
            txtPov.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Blue;
            label4.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(219, 195);
            label4.Name = "label4";
            label4.Size = new Size(109, 23);
            label4.TabIndex = 28;
            label4.Text = "povrsina ";
            // 
            // txtBrPrs
            // 
            txtBrPrs.Location = new Point(415, 141);
            txtBrPrs.Name = "txtBrPrs";
            txtBrPrs.Size = new Size(150, 31);
            txtBrPrs.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Blue;
            label2.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(219, 145);
            label2.Name = "label2";
            label2.Size = new Size(168, 23);
            label2.TabIndex = 24;
            label2.Text = "Broj prskalica";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Blue;
            label1.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(327, 70);
            label1.Name = "label1";
            label1.Size = new Size(170, 23);
            label1.TabIndex = 23;
            label1.Text = "Izmeni fontanu";
            // 
            // btnDodaj
            // 
            btnDodaj.BackColor = Color.White;
            btnDodaj.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDodaj.ForeColor = Color.Blue;
            btnDodaj.Location = new Point(469, 346);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(112, 34);
            btnDodaj.TabIndex = 22;
            btnDodaj.Text = "Izmeni";
            btnDodaj.UseVisualStyleBackColor = false;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // IzmeniFontanu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPov);
            Controls.Add(label4);
            Controls.Add(txtBrPrs);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDodaj);
            Name = "IzmeniFontanu";
            Text = "IzmeniFontanu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPov;
        private Label label4;
        private TextBox txtBrPrs;
        private Label label2;
        private Label label1;
        private Button btnDodaj;
    }
}