namespace ZelenaPovrsina.Forme
{
    partial class IzmeniDrvoredForm
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
            label7 = new Label();
            btnIzmeni = new Button();
            txtBrojDrvored = new TextBox();
            txtDuzinaDrvored = new TextBox();
            label6 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Blue;
            label7.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(337, -31);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(192, 23);
            label7.TabIndex = 27;
            label7.Text = "Dodajte drvored";
            // 
            // btnIzmeni
            // 
            btnIzmeni.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIzmeni.ForeColor = Color.Blue;
            btnIzmeni.Location = new Point(387, 269);
            btnIzmeni.Margin = new Padding(4, 5, 4, 5);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(173, 58);
            btnIzmeni.TabIndex = 26;
            btnIzmeni.Text = "Izmeni";
            btnIzmeni.UseVisualStyleBackColor = true;
            btnIzmeni.Click += btnDodajDrvor_Click;
            // 
            // txtBrojDrvored
            // 
            txtBrojDrvored.Location = new Point(387, 140);
            txtBrojDrvored.Margin = new Padding(4, 5, 4, 5);
            txtBrojDrvored.Name = "txtBrojDrvored";
            txtBrojDrvored.Size = new Size(171, 31);
            txtBrojDrvored.TabIndex = 25;
            // 
            // txtDuzinaDrvored
            // 
            txtDuzinaDrvored.Location = new Point(387, 80);
            txtDuzinaDrvored.Margin = new Padding(4, 5, 4, 5);
            txtDuzinaDrvored.Name = "txtDuzinaDrvored";
            txtDuzinaDrvored.Size = new Size(173, 31);
            txtDuzinaDrvored.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Blue;
            label6.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(193, 144);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(146, 23);
            label6.TabIndex = 19;
            label6.Text = "Broj stabala";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Blue;
            label4.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(193, 84);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(82, 23);
            label4.TabIndex = 17;
            label4.Text = "Duzina";
            // 
            // IzmeniDrvoredForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(btnIzmeni);
            Controls.Add(txtBrojDrvored);
            Controls.Add(txtDuzinaDrvored);
            Controls.Add(label6);
            Controls.Add(label4);
            Name = "IzmeniDrvoredForm";
            Text = "IzmeniDrvoredForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Button btnIzmeni;
        private TextBox txtBrojDrvored;
        private TextBox txtDuzinaDrvored;
        private Label label6;
        private Label label4;
    }
}