namespace ZelenaPovrsina.Forme
{
    partial class IzmeniIgralisteForm
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
            txtBr = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnIzmeni = new Button();
            SuspendLayout();
            // 
            // txtBr
            // 
            txtBr.Location = new Point(405, 106);
            txtBr.Name = "txtBr";
            txtBr.Size = new Size(150, 31);
            txtBr.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Blue;
            label2.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(199, 110);
            label2.Name = "label2";
            label2.Size = new Size(159, 23);
            label2.TabIndex = 18;
            label2.Text = "Broj igracaka";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Blue;
            label1.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(394, 47);
            label1.Name = "label1";
            label1.Size = new Size(177, 23);
            label1.TabIndex = 17;
            label1.Text = "Izmeni igraliste";
            label1.Click += label1_Click;
            // 
            // btnIzmeni
            // 
            btnIzmeni.BackColor = Color.White;
            btnIzmeni.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIzmeni.ForeColor = Color.Blue;
            btnIzmeni.Location = new Point(429, 255);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(112, 34);
            btnIzmeni.TabIndex = 16;
            btnIzmeni.Text = "Izmeni";
            btnIzmeni.UseVisualStyleBackColor = false;
            btnIzmeni.Click += btnIzmeni_Click;
            // 
            // IzmeniIgralisteForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(800, 450);
            Controls.Add(txtBr);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnIzmeni);
            Name = "IzmeniIgralisteForm";
            Text = "IzmeniIgralisteForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBr;
        private Label label2;
        private Label label1;
        private Button btnIzmeni;
    }
}