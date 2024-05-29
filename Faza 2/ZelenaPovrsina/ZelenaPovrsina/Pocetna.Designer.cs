namespace ZelenaPovrsina
{
    partial class Pocetna
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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 40F);
            label1.Location = new Point(215, 9);
            label1.Name = "label1";
            label1.Size = new Size(404, 72);
            label1.TabIndex = 0;
            label1.Text = "Zelene Povrsine";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 20F);
            button1.Location = new Point(289, 160);
            button1.Name = "button1";
            button1.Size = new Size(269, 58);
            button1.TabIndex = 1;
            button1.Text = "Radnici";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 20F);
            button2.Location = new Point(289, 255);
            button2.Name = "button2";
            button2.Size = new Size(269, 58);
            button2.TabIndex = 2;
            button2.Text = "Zelene povrsine";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 20F);
            button3.Location = new Point(289, 349);
            button3.Name = "button3";
            button3.Size = new Size(269, 58);
            button3.TabIndex = 3;
            button3.Text = "Objekti";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 20F);
            button4.Location = new Point(289, 445);
            button4.Name = "button4";
            button4.Size = new Size(269, 58);
            button4.TabIndex = 4;
            button4.Text = "Zastite";
            button4.UseVisualStyleBackColor = true;
            // 
            // Pocetna
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 557);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Pocetna";
            Text = "Pocetna";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}