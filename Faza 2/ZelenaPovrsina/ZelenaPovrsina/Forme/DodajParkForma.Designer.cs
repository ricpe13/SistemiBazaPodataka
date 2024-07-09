namespace ZelenaPovrsina.Forme
{
    partial class DodajParkForma
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
            txtOpst = new TextBox();
            txtZona = new TextBox();
            txtNaziv = new TextBox();
            txtPov = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cmdDodajPark = new Button();
            SuspendLayout();
            // 
            // txtOpst
            // 
            txtOpst.Location = new Point(253, 17);
            txtOpst.Name = "txtOpst";
            txtOpst.Size = new Size(150, 31);
            txtOpst.TabIndex = 0;
            // 
            // txtZona
            // 
            txtZona.Location = new Point(253, 53);
            txtZona.Name = "txtZona";
            txtZona.Size = new Size(150, 31);
            txtZona.TabIndex = 1;
            // 
            // txtNaziv
            // 
            txtNaziv.Location = new Point(253, 90);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(150, 31);
            txtNaziv.TabIndex = 2;
            // 
            // txtPov
            // 
            txtPov.Location = new Point(253, 127);
            txtPov.Name = "txtPov";
            txtPov.Size = new Size(150, 31);
            txtPov.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Blue;
            label1.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(29, 17);
            label1.Name = "label1";
            label1.Size = new Size(184, 23);
            label1.TabIndex = 4;
            label1.Text = "Gradska opština";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Blue;
            label2.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(29, 53);
            label2.Name = "label2";
            label2.Size = new Size(199, 23);
            label2.TabIndex = 5;
            label2.Text = "Zona ugroženosti";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Blue;
            label3.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(29, 90);
            label3.Name = "label3";
            label3.Size = new Size(135, 23);
            label3.TabIndex = 6;
            label3.Text = "Naziv parka";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Blue;
            label4.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(29, 127);
            label4.Name = "label4";
            label4.Size = new Size(173, 23);
            label4.TabIndex = 7;
            label4.Text = "Površina parka";
            // 
            // cmdDodajPark
            // 
            cmdDodajPark.BackColor = Color.White;
            cmdDodajPark.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmdDodajPark.ForeColor = Color.Blue;
            cmdDodajPark.Location = new Point(292, 220);
            cmdDodajPark.Name = "cmdDodajPark";
            cmdDodajPark.Size = new Size(111, 50);
            cmdDodajPark.TabIndex = 8;
            cmdDodajPark.Text = "DODAJ";
            cmdDodajPark.UseVisualStyleBackColor = false;
            cmdDodajPark.Click += cmdDodajPark_Click;
            // 
            // DodajParkForma
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(800, 450);
            Controls.Add(cmdDodajPark);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPov);
            Controls.Add(txtNaziv);
            Controls.Add(txtZona);
            Controls.Add(txtOpst);
            Name = "DodajParkForma";
            Text = "DodajParkForma";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtOpst;
        private TextBox txtZona;
        private TextBox txtNaziv;
        private TextBox txtPov;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button cmdDodajPark;
    }
}