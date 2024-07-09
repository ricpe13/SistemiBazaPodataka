namespace ZelenaPovrsina.Forme
{
    partial class IzmeniSvetiljkuForm
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
            txtBrSij = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnIzmeni = new Button();
            SuspendLayout();
            // 
            // txtBrSij
            // 
            txtBrSij.Location = new Point(415, 141);
            txtBrSij.Name = "txtBrSij";
            txtBrSij.Size = new Size(150, 31);
            txtBrSij.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Blue;
            label2.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(219, 145);
            label2.Name = "label2";
            label2.Size = new Size(144, 23);
            label2.TabIndex = 22;
            label2.Text = "broj sijalica";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Blue;
            label1.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(327, 70);
            label1.Name = "label1";
            label1.Size = new Size(181, 23);
            label1.TabIndex = 21;
            label1.Text = "Izmeni svetiljku";
            // 
            // btnIzmeni
            // 
            btnIzmeni.BackColor = Color.White;
            btnIzmeni.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIzmeni.ForeColor = Color.Blue;
            btnIzmeni.Location = new Point(469, 346);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(112, 34);
            btnIzmeni.TabIndex = 20;
            btnIzmeni.Text = "Izmeni";
            btnIzmeni.UseVisualStyleBackColor = false;
            btnIzmeni.Click += btnDodaj_Click;
            // 
            // IzmeniSvetiljkuForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(800, 450);
            Controls.Add(txtBrSij);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnIzmeni);
            Name = "IzmeniSvetiljkuForm";
            Text = "IzmeniSvetiljkuForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBrSij;
        private Label label2;
        private Label label1;
        private Button btnIzmeni;
    }
}