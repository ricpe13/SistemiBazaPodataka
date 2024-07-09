namespace ZelenaPovrsina.Forme
{
    partial class IzmeniSkulpturuForm
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
            txtAutor = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnDodaj = new Button();
            SuspendLayout();
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(415, 141);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(150, 31);
            txtAutor.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Blue;
            label2.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(312, 145);
            label2.Name = "label2";
            label2.Size = new Size(75, 23);
            label2.TabIndex = 16;
            label2.Text = "Autor";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Blue;
            label1.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(327, 70);
            label1.Name = "label1";
            label1.Size = new Size(196, 23);
            label1.TabIndex = 15;
            label1.Text = "Izmeni skulpturu";
            // 
            // btnDodaj
            // 
            btnDodaj.BackColor = Color.White;
            btnDodaj.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDodaj.ForeColor = Color.Blue;
            btnDodaj.Location = new Point(453, 289);
            btnDodaj.Name = "btnDodaj";
            btnDodaj.Size = new Size(112, 34);
            btnDodaj.TabIndex = 14;
            btnDodaj.Text = "Izmeni";
            btnDodaj.UseVisualStyleBackColor = false;
            btnDodaj.Click += btnDodaj_Click;
            // 
            // IzmeniSkulpturuForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(800, 450);
            Controls.Add(txtAutor);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDodaj);
            Name = "IzmeniSkulpturuForm";
            Text = "IzmeniSkulpturuForm";
            Load += IzmeniSkulpturuForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtAutor;
        private Label label2;
        private Label label1;
        private Button btnDodaj;
    }
}