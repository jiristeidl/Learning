namespace ADayAtTheRaces
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.raceTrack = new System.Windows.Forms.PictureBox();
            this.dog1 = new System.Windows.Forms.PictureBox();
            this.dog2 = new System.Windows.Forms.PictureBox();
            this.dog3 = new System.Windows.Forms.PictureBox();
            this.dog4 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bettingParlorBox = new System.Windows.Forms.GroupBox();
            this.dogPicker = new System.Windows.Forms.NumericUpDown();
            this.startButton = new System.Windows.Forms.Button();
            this.johnBetLabel = new System.Windows.Forms.Label();
            this.bobBetLabel = new System.Windows.Forms.Label();
            this.joeBetLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.betPicker = new System.Windows.Forms.NumericUpDown();
            this.betsButton = new System.Windows.Forms.Button();
            this.bettorNameLabel = new System.Windows.Forms.Label();
            this.johnRadioB = new System.Windows.Forms.RadioButton();
            this.bobRadioB = new System.Windows.Forms.RadioButton();
            this.joesRadioB = new System.Windows.Forms.RadioButton();
            this.minimumBetLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.raceTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog4)).BeginInit();
            this.bettingParlorBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogPicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betPicker)).BeginInit();
            this.SuspendLayout();
            // 
            // raceTrack
            // 
            this.raceTrack.Image = ((System.Drawing.Image)(resources.GetObject("raceTrack.Image")));
            this.raceTrack.Location = new System.Drawing.Point(12, 12);
            this.raceTrack.Name = "raceTrack";
            this.raceTrack.Size = new System.Drawing.Size(600, 200);
            this.raceTrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.raceTrack.TabIndex = 2;
            this.raceTrack.TabStop = false;
            // 
            // dog1
            // 
            this.dog1.Image = ((System.Drawing.Image)(resources.GetObject("dog1.Image")));
            this.dog1.Location = new System.Drawing.Point(22, 21);
            this.dog1.Name = "dog1";
            this.dog1.Size = new System.Drawing.Size(75, 20);
            this.dog1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.dog1.TabIndex = 3;
            this.dog1.TabStop = false;
            // 
            // dog2
            // 
            this.dog2.Image = ((System.Drawing.Image)(resources.GetObject("dog2.Image")));
            this.dog2.Location = new System.Drawing.Point(22, 72);
            this.dog2.Name = "dog2";
            this.dog2.Size = new System.Drawing.Size(75, 20);
            this.dog2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.dog2.TabIndex = 4;
            this.dog2.TabStop = false;
            // 
            // dog3
            // 
            this.dog3.Image = ((System.Drawing.Image)(resources.GetObject("dog3.Image")));
            this.dog3.Location = new System.Drawing.Point(22, 124);
            this.dog3.Name = "dog3";
            this.dog3.Size = new System.Drawing.Size(75, 20);
            this.dog3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.dog3.TabIndex = 5;
            this.dog3.TabStop = false;
            // 
            // dog4
            // 
            this.dog4.Image = ((System.Drawing.Image)(resources.GetObject("dog4.Image")));
            this.dog4.Location = new System.Drawing.Point(22, 175);
            this.dog4.Name = "dog4";
            this.dog4.Size = new System.Drawing.Size(75, 20);
            this.dog4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.dog4.TabIndex = 6;
            this.dog4.TabStop = false;
            // 
            // bettingParlorBox
            // 
            this.bettingParlorBox.Controls.Add(this.dogPicker);
            this.bettingParlorBox.Controls.Add(this.startButton);
            this.bettingParlorBox.Controls.Add(this.johnBetLabel);
            this.bettingParlorBox.Controls.Add(this.bobBetLabel);
            this.bettingParlorBox.Controls.Add(this.joeBetLabel);
            this.bettingParlorBox.Controls.Add(this.label2);
            this.bettingParlorBox.Controls.Add(this.label1);
            this.bettingParlorBox.Controls.Add(this.betPicker);
            this.bettingParlorBox.Controls.Add(this.betsButton);
            this.bettingParlorBox.Controls.Add(this.bettorNameLabel);
            this.bettingParlorBox.Controls.Add(this.johnRadioB);
            this.bettingParlorBox.Controls.Add(this.bobRadioB);
            this.bettingParlorBox.Controls.Add(this.joesRadioB);
            this.bettingParlorBox.Controls.Add(this.minimumBetLabel);
            this.bettingParlorBox.Location = new System.Drawing.Point(12, 219);
            this.bettingParlorBox.Name = "bettingParlorBox";
            this.bettingParlorBox.Size = new System.Drawing.Size(600, 174);
            this.bettingParlorBox.TabIndex = 7;
            this.bettingParlorBox.TabStop = false;
            this.bettingParlorBox.Text = "Betting Parlor";
            // 
            // dogPicker
            // 
            this.dogPicker.Location = new System.Drawing.Point(268, 124);
            this.dogPicker.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.dogPicker.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dogPicker.Name = "dogPicker";
            this.dogPicker.Size = new System.Drawing.Size(66, 20);
            this.dogPicker.TabIndex = 13;
            this.dogPicker.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(352, 20);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(203, 125);
            this.startButton.TabIndex = 12;
            this.startButton.Text = "Race!";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // johnBetLabel
            // 
            this.johnBetLabel.AutoSize = true;
            this.johnBetLabel.Location = new System.Drawing.Point(204, 85);
            this.johnBetLabel.Name = "johnBetLabel";
            this.johnBetLabel.Size = new System.Drawing.Size(35, 13);
            this.johnBetLabel.TabIndex = 11;
            this.johnBetLabel.Text = "label5";
            // 
            // bobBetLabel
            // 
            this.bobBetLabel.AutoSize = true;
            this.bobBetLabel.Location = new System.Drawing.Point(204, 61);
            this.bobBetLabel.Name = "bobBetLabel";
            this.bobBetLabel.Size = new System.Drawing.Size(35, 13);
            this.bobBetLabel.TabIndex = 10;
            this.bobBetLabel.Text = "label4";
            // 
            // joeBetLabel
            // 
            this.joeBetLabel.AutoSize = true;
            this.joeBetLabel.Location = new System.Drawing.Point(204, 37);
            this.joeBetLabel.Name = "joeBetLabel";
            this.joeBetLabel.Size = new System.Drawing.Size(35, 13);
            this.joeBetLabel.TabIndex = 9;
            this.joeBetLabel.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(201, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Bets";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "bucks on dog number";
            // 
            // betPicker
            // 
            this.betPicker.Location = new System.Drawing.Point(101, 125);
            this.betPicker.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.betPicker.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.betPicker.Name = "betPicker";
            this.betPicker.Size = new System.Drawing.Size(44, 20);
            this.betPicker.TabIndex = 6;
            this.betPicker.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // betsButton
            // 
            this.betsButton.Location = new System.Drawing.Point(51, 122);
            this.betsButton.Name = "betsButton";
            this.betsButton.Size = new System.Drawing.Size(44, 23);
            this.betsButton.TabIndex = 5;
            this.betsButton.Text = "Bets";
            this.betsButton.UseVisualStyleBackColor = true;
            this.betsButton.Click += new System.EventHandler(this.betsButton_Click);
            // 
            // bettorNameLabel
            // 
            this.bettorNameLabel.Location = new System.Drawing.Point(10, 127);
            this.bettorNameLabel.Name = "bettorNameLabel";
            this.bettorNameLabel.Size = new System.Drawing.Size(42, 18);
            this.bettorNameLabel.TabIndex = 4;
            this.bettorNameLabel.Text = "Name";
            // 
            // johnRadioB
            // 
            this.johnRadioB.AutoSize = true;
            this.johnRadioB.Location = new System.Drawing.Point(10, 85);
            this.johnRadioB.Name = "johnRadioB";
            this.johnRadioB.Size = new System.Drawing.Size(85, 17);
            this.johnRadioB.TabIndex = 3;
            this.johnRadioB.TabStop = true;
            this.johnRadioB.Text = "radioButton3";
            this.johnRadioB.UseVisualStyleBackColor = true;
            // 
            // bobRadioB
            // 
            this.bobRadioB.AutoSize = true;
            this.bobRadioB.Location = new System.Drawing.Point(10, 61);
            this.bobRadioB.Name = "bobRadioB";
            this.bobRadioB.Size = new System.Drawing.Size(85, 17);
            this.bobRadioB.TabIndex = 2;
            this.bobRadioB.TabStop = true;
            this.bobRadioB.Text = "radioButton2";
            this.bobRadioB.UseVisualStyleBackColor = true;
            // 
            // joesRadioB
            // 
            this.joesRadioB.AutoSize = true;
            this.joesRadioB.Location = new System.Drawing.Point(10, 37);
            this.joesRadioB.Name = "joesRadioB";
            this.joesRadioB.Size = new System.Drawing.Size(85, 17);
            this.joesRadioB.TabIndex = 1;
            this.joesRadioB.TabStop = true;
            this.joesRadioB.Text = "radioButton1";
            this.joesRadioB.UseVisualStyleBackColor = true;
            // 
            // minimumBetLabel
            // 
            this.minimumBetLabel.AutoSize = true;
            this.minimumBetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimumBetLabel.Location = new System.Drawing.Point(7, 20);
            this.minimumBetLabel.Name = "minimumBetLabel";
            this.minimumBetLabel.Size = new System.Drawing.Size(76, 13);
            this.minimumBetLabel.TabIndex = 0;
            this.minimumBetLabel.Text = "minimum bet";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 405);
            this.Controls.Add(this.bettingParlorBox);
            this.Controls.Add(this.dog4);
            this.Controls.Add(this.dog3);
            this.Controls.Add(this.dog2);
            this.Controls.Add(this.dog1);
            this.Controls.Add(this.raceTrack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "A Day at the Races";
            ((System.ComponentModel.ISupportInitialize)(this.raceTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog4)).EndInit();
            this.bettingParlorBox.ResumeLayout(false);
            this.bettingParlorBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogPicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betPicker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox raceTrack;
        private System.Windows.Forms.PictureBox dog1;
        private System.Windows.Forms.PictureBox dog2;
        private System.Windows.Forms.PictureBox dog3;
        private System.Windows.Forms.PictureBox dog4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox bettingParlorBox;
        private System.Windows.Forms.NumericUpDown dogPicker;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label johnBetLabel;
        private System.Windows.Forms.Label bobBetLabel;
        private System.Windows.Forms.Label joeBetLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown betPicker;
        private System.Windows.Forms.Button betsButton;
        private System.Windows.Forms.Label bettorNameLabel;
        private System.Windows.Forms.RadioButton johnRadioB;
        private System.Windows.Forms.RadioButton bobRadioB;
        private System.Windows.Forms.RadioButton joesRadioB;
        private System.Windows.Forms.Label minimumBetLabel;
    }
}

