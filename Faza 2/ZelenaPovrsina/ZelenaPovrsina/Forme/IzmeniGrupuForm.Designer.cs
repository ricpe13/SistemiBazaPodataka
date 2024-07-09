namespace ZelenaPovrsina.Forme
{
    partial class IzmeniGrupuForm
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
            label3 = new Label();
            cmdDodajGrupuRadnika = new Button();
            label1 = new Label();
            txtNaziv = new TextBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Blue;
            label3.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(214, 56);
            label3.Name = "label3";
            label3.Size = new Size(238, 23);
            label3.TabIndex = 11;
            label3.Text = "Izmeni grupu radnika";
            // 
            // cmdDodajGrupuRadnika
            // 
            cmdDodajGrupuRadnika.BackColor = Color.White;
            cmdDodajGrupuRadnika.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmdDodajGrupuRadnika.ForeColor = Color.Blue;
            cmdDodajGrupuRadnika.Location = new Point(569, 361);
            cmdDodajGrupuRadnika.Name = "cmdDodajGrupuRadnika";
            cmdDodajGrupuRadnika.Size = new Size(112, 34);
            cmdDodajGrupuRadnika.TabIndex = 8;
            cmdDodajGrupuRadnika.Text = "Izmeni";
            cmdDodajGrupuRadnika.UseVisualStyleBackColor = false;
            cmdDodajGrupuRadnika.Click += cmdDodajGrupuRadnika_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Blue;
            label1.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(120, 176);
            label1.Name = "label1";
            label1.Size = new Size(135, 23);
            label1.TabIndex = 7;
            label1.Text = "Naziv grupe";
            // 
            // txtNaziv
            // 
            txtNaziv.Location = new Point(299, 172);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(150, 31);
            txtNaziv.TabIndex = 6;
            // 
            // IzmeniGrupuForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(cmdDodajGrupuRadnika);
            Controls.Add(label1);
            Controls.Add(txtNaziv);
            Name = "IzmeniGrupuForm";
            Text = "IzmeniGrupuForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Button cmdDodajGrupuRadnika;
        private Label label1;
        private TextBox txtNaziv;
    }
}