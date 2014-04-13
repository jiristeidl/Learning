namespace Chapter4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.StartingMileage = new System.Windows.Forms.NumericUpDown();
            this.EndingMileage = new System.Windows.Forms.NumericUpDown();
            this.Owed = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StartingMileage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndingMileage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Starting Mileage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ending Mileage";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Amount Owed";
            // 
            // StartingMileage
            // 
            this.StartingMileage.Location = new System.Drawing.Point(100, 12);
            this.StartingMileage.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.StartingMileage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.StartingMileage.Name = "StartingMileage";
            this.StartingMileage.Size = new System.Drawing.Size(120, 20);
            this.StartingMileage.TabIndex = 3;
            this.StartingMileage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // EndingMileage
            // 
            this.EndingMileage.Location = new System.Drawing.Point(100, 38);
            this.EndingMileage.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.EndingMileage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.EndingMileage.Name = "EndingMileage";
            this.EndingMileage.Size = new System.Drawing.Size(120, 20);
            this.EndingMileage.TabIndex = 4;
            this.EndingMileage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Owed
            // 
            this.Owed.AutoSize = true;
            this.Owed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Owed.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Owed.Location = new System.Drawing.Point(96, 61);
            this.Owed.Name = "Owed";
            this.Owed.Size = new System.Drawing.Size(57, 20);
            this.Owed.TabIndex = 5;
            this.Owed.Text = "label4";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 139);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Owed);
            this.Controls.Add(this.EndingMileage);
            this.Controls.Add(this.StartingMileage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.StartingMileage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndingMileage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown StartingMileage;
        private System.Windows.Forms.NumericUpDown EndingMileage;
        private System.Windows.Forms.Label Owed;
        private System.Windows.Forms.Button button1;
    }
}

