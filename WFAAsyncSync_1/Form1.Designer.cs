namespace WFAAsyncSync_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            btnSelam = new Button();
            btnSim = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(105, 107);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(110, 23);
            textBox1.TabIndex = 5;
            // 
            // btnSelam
            // 
            btnSelam.Location = new Point(211, 37);
            btnSelam.Margin = new Padding(3, 2, 3, 2);
            btnSelam.Name = "btnSelam";
            btnSelam.Size = new Size(82, 22);
            btnSelam.TabIndex = 4;
            btnSelam.Text = "Selamla";
            btnSelam.UseVisualStyleBackColor = true;
            btnSelam.Click += btnSelam_Click;
            // 
            // btnSim
            // 
            btnSim.Location = new Point(27, 37);
            btnSim.Margin = new Padding(3, 2, 3, 2);
            btnSim.Name = "btnSim";
            btnSim.Size = new Size(82, 22);
            btnSim.TabIndex = 3;
            btnSim.Text = "Simulasyon";
            btnSim.UseVisualStyleBackColor = true;
            btnSim.Click += btnSim_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 179);
            Controls.Add(textBox1);
            Controls.Add(btnSelam);
            Controls.Add(btnSim);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button btnSelam;
        private Button btnSim;
    }
}
