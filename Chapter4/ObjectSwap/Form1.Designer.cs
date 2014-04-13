namespace ObjectSwap
{
    partial class Form1
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
            this.LloydButton = new System.Windows.Forms.Button();
            this.LucindaButton = new System.Windows.Forms.Button();
            this.SwapButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LloydButton
            // 
            this.LloydButton.Location = new System.Drawing.Point(91, 13);
            this.LloydButton.Name = "LloydButton";
            this.LloydButton.Size = new System.Drawing.Size(75, 23);
            this.LloydButton.TabIndex = 0;
            this.LloydButton.Text = "Lloyd";
            this.LloydButton.UseVisualStyleBackColor = true;
            this.LloydButton.Click += new System.EventHandler(this.LloydButton_Click);
            // 
            // LucindaButton
            // 
            this.LucindaButton.Location = new System.Drawing.Point(91, 43);
            this.LucindaButton.Name = "LucindaButton";
            this.LucindaButton.Size = new System.Drawing.Size(75, 23);
            this.LucindaButton.TabIndex = 1;
            this.LucindaButton.Text = "Lucinda";
            this.LucindaButton.UseVisualStyleBackColor = true;
            this.LucindaButton.Click += new System.EventHandler(this.LucindaButton_Click);
            // 
            // SwapButton
            // 
            this.SwapButton.Location = new System.Drawing.Point(91, 73);
            this.SwapButton.Name = "SwapButton";
            this.SwapButton.Size = new System.Drawing.Size(75, 23);
            this.SwapButton.TabIndex = 2;
            this.SwapButton.Text = "Swap!";
            this.SwapButton.UseVisualStyleBackColor = true;
            this.SwapButton.Click += new System.EventHandler(this.SwapButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(91, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Tell Me";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(91, 133);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Speak To";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 174);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SwapButton);
            this.Controls.Add(this.LucindaButton);
            this.Controls.Add(this.LloydButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Swap";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LloydButton;
        private System.Windows.Forms.Button LucindaButton;
        private System.Windows.Forms.Button SwapButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

