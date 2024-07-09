namespace ZelenaPovrsina.Forme
{
    partial class IzmeniParkForm
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
            btnIzmeni = new Button();
            txtZona = new TextBox();
            txtPovrsina = new TextBox();
            txtOpstina = new TextBox();
            txtNaziv = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnIzmeni
            // 
            btnIzmeni.Location = new Point(506, 364);
            btnIzmeni.Name = "btnIzmeni";
            btnIzmeni.Size = new Size(112, 34);
            btnIzmeni.TabIndex = 19;
            btnIzmeni.Text = "Izmeni";
            btnIzmeni.UseVisualStyleBackColor = true;
            btnIzmeni.Click += btnIzmeni_Click;
            // 
            // txtZona
            // 
            txtZona.Location = new Point(491, 268);
            txtZona.Name = "txtZona";
            txtZona.Size = new Size(150, 31);
            txtZona.TabIndex = 18;
            // 
            // txtPovrsina
            // 
            txtPovrsina.Location = new Point(491, 214);
            txtPovrsina.Name = "txtPovrsina";
            txtPovrsina.Size = new Size(150, 31);
            txtPovrsina.TabIndex = 17;
            // 
            // txtOpstina
            // 
            txtOpstina.Location = new Point(491, 165);
            txtOpstina.Name = "txtOpstina";
            txtOpstina.Size = new Size(150, 31);
            txtOpstina.TabIndex = 16;
            // 
            // txtNaziv
            // 
            txtNaziv.Location = new Point(491, 120);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(150, 31);
            txtNaziv.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Blue;
            label5.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlLight;
            label5.Location = new Point(159, 124);
            label5.Name = "label5";
            label5.Size = new Size(66, 23);
            label5.TabIndex = 14;
            label5.Text = "Naziv";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Blue;
            label4.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLight;
            label4.Location = new Point(159, 169);
            label4.Name = "label4";
            label4.Size = new Size(91, 23);
            label4.TabIndex = 13;
            label4.Text = "Opstina";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Blue;
            label3.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLight;
            label3.Location = new Point(159, 218);
            label3.Name = "label3";
            label3.Size = new Size(104, 23);
            label3.TabIndex = 12;
            label3.Text = "Povrsina";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Blue;
            label2.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLight;
            label2.Location = new Point(159, 272);
            label2.Name = "label2";
            label2.Size = new Size(199, 23);
            label2.TabIndex = 11;
            label2.Text = "Zona ugrozenosti";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Blue;
            label1.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(349, 52);
            label1.Name = "label1";
            label1.Size = new Size(282, 23);
            label1.TabIndex = 10;
            label1.Text = "IZMENI PODATKE O RADNIKU";
            // 
            // IzmeniParkForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(800, 450);
            Controls.Add(btnIzmeni);
            Controls.Add(txtZona);
            Controls.Add(txtPovrsina);
            Controls.Add(txtOpstina);
            Controls.Add(txtNaziv);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "IzmeniParkForm";
            Text = "IzmeniParkForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIzmeni;
        private TextBox txtZona;
        private TextBox txtPovrsina;
        private TextBox txtOpstina;
        private TextBox txtNaziv;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}