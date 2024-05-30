namespace ZelenaPovrsina.Forme
{
    partial class DodajGrupuForma
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
            txtNaziv = new TextBox();
            label1 = new Label();
            cmdDodajGrupuRadnika = new Button();
            SuspendLayout();
            // 
            // txtNaziv
            // 
            txtNaziv.Location = new Point(190, 41);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(150, 31);
            txtNaziv.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 41);
            label1.Name = "label1";
            label1.Size = new Size(107, 25);
            label1.TabIndex = 1;
            label1.Text = "Naziv grupe";
            // 
            // cmdDodajGrupuRadnika
            // 
            cmdDodajGrupuRadnika.BackColor = Color.FromArgb(255, 128, 0);
            cmdDodajGrupuRadnika.Location = new Point(484, 231);
            cmdDodajGrupuRadnika.Name = "cmdDodajGrupuRadnika";
            cmdDodajGrupuRadnika.Size = new Size(112, 34);
            cmdDodajGrupuRadnika.TabIndex = 2;
            cmdDodajGrupuRadnika.Text = "Dodaj";
            cmdDodajGrupuRadnika.UseVisualStyleBackColor = false;
            cmdDodajGrupuRadnika.Click += cmdDodajGrupuRadnika_Click;
            // 
            // DodajGrupuForma
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmdDodajGrupuRadnika);
            Controls.Add(label1);
            Controls.Add(txtNaziv);
            Name = "DodajGrupuForma";
            Text = "DodajGrupuForma";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNaziv;
        private Label label1;
        private Button cmdDodajGrupuRadnika;
    }
}