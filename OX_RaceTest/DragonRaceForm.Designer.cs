namespace Dragon_Race
{
    partial class DragonRaceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DragonRaceForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NavBet = new System.Windows.Forms.Label();
            this.SumanBet = new System.Windows.Forms.Label();
            this.HappyBet = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.race = new System.Windows.Forms.Button();
            this.DragonNumber = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.BettingAmount = new System.Windows.Forms.NumericUpDown();
            this.Bets = new System.Windows.Forms.Button();
            this.NavButton = new System.Windows.Forms.RadioButton();
            this.SumanButton = new System.Windows.Forms.RadioButton();
            this.HappyButton = new System.Windows.Forms.RadioButton();
            this.MaximumBet = new System.Windows.Forms.Label();
            this.Dragon4 = new System.Windows.Forms.PictureBox();
            this.Dragon3 = new System.Windows.Forms.PictureBox();
            this.Dragon2 = new System.Windows.Forms.PictureBox();
            this.Dragon1 = new System.Windows.Forms.PictureBox();
            this.Racetrack = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DragonNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BettingAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dragon4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dragon3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dragon2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dragon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Racetrack)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gray;
            this.groupBox1.Controls.Add(this.NavBet);
            this.groupBox1.Controls.Add(this.SumanBet);
            this.groupBox1.Controls.Add(this.HappyBet);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.race);
            this.groupBox1.Controls.Add(this.DragonNumber);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BettingAmount);
            this.groupBox1.Controls.Add(this.Bets);
            this.groupBox1.Controls.Add(this.NavButton);
            this.groupBox1.Controls.Add(this.SumanButton);
            this.groupBox1.Controls.Add(this.HappyButton);
            this.groupBox1.Controls.Add(this.MaximumBet);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(-1, 455);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1226, 207);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Place Bet Here";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // NavBet
            // 
            this.NavBet.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.NavBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NavBet.Location = new System.Drawing.Point(675, 91);
            this.NavBet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NavBet.Name = "NavBet";
            this.NavBet.Size = new System.Drawing.Size(386, 21);
            this.NavBet.TabIndex = 13;
            this.NavBet.Text = "label6";
            this.NavBet.Click += new System.EventHandler(this.NavBet_Click);
            // 
            // SumanBet
            // 
            this.SumanBet.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SumanBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SumanBet.Location = new System.Drawing.Point(675, 56);
            this.SumanBet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SumanBet.Name = "SumanBet";
            this.SumanBet.Size = new System.Drawing.Size(386, 24);
            this.SumanBet.TabIndex = 12;
            this.SumanBet.Text = "label5";
            this.SumanBet.Click += new System.EventHandler(this.SumanBet_Click);
            // 
            // HappyBet
            // 
            this.HappyBet.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.HappyBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HappyBet.Location = new System.Drawing.Point(675, 21);
            this.HappyBet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HappyBet.Name = "HappyBet";
            this.HappyBet.Size = new System.Drawing.Size(386, 23);
            this.HappyBet.TabIndex = 11;
            this.HappyBet.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(607, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Bets";
            // 
            // race
            // 
            this.race.BackColor = System.Drawing.Color.HotPink;
            this.race.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.race.FlatAppearance.BorderSize = 5;
            this.race.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.race.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.race.ForeColor = System.Drawing.Color.White;
            this.race.Location = new System.Drawing.Point(797, 119);
            this.race.Margin = new System.Windows.Forms.Padding(4);
            this.race.Name = "race";
            this.race.Size = new System.Drawing.Size(114, 65);
            this.race.TabIndex = 9;
            this.race.Text = "START RACE";
            this.race.UseVisualStyleBackColor = false;
            this.race.Click += new System.EventHandler(this.Race_Click);
            // 
            // DragonNumber
            // 
            this.DragonNumber.Location = new System.Drawing.Point(490, 131);
            this.DragonNumber.Margin = new System.Windows.Forms.Padding(4);
            this.DragonNumber.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.DragonNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DragonNumber.Name = "DragonNumber";
            this.DragonNumber.Size = new System.Drawing.Size(85, 24);
            this.DragonNumber.TabIndex = 8;
            this.DragonNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(353, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Dragon number";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // BettingAmount
            // 
            this.BettingAmount.Location = new System.Drawing.Point(490, 59);
            this.BettingAmount.Margin = new System.Windows.Forms.Padding(4);
            this.BettingAmount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.BettingAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BettingAmount.Name = "BettingAmount";
            this.BettingAmount.Size = new System.Drawing.Size(84, 24);
            this.BettingAmount.TabIndex = 6;
            this.BettingAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BettingAmount.ValueChanged += new System.EventHandler(this.BettingAmount_ValueChanged);
            // 
            // Bets
            // 
            this.Bets.BackColor = System.Drawing.Color.HotPink;
            this.Bets.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Bets.FlatAppearance.BorderSize = 5;
            this.Bets.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bets.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bets.ForeColor = System.Drawing.Color.White;
            this.Bets.Location = new System.Drawing.Point(9, 80);
            this.Bets.Margin = new System.Windows.Forms.Padding(4);
            this.Bets.Name = "Bets";
            this.Bets.Size = new System.Drawing.Size(141, 44);
            this.Bets.TabIndex = 5;
            this.Bets.Text = "Place Bet";
            this.Bets.UseVisualStyleBackColor = false;
            this.Bets.Click += new System.EventHandler(this.Bets_Click);
            // 
            // NavButton
            // 
            this.NavButton.AutoSize = true;
            this.NavButton.Checked = true;
            this.NavButton.Location = new System.Drawing.Point(172, 142);
            this.NavButton.Margin = new System.Windows.Forms.Padding(4);
            this.NavButton.Name = "NavButton";
            this.NavButton.Size = new System.Drawing.Size(58, 22);
            this.NavButton.TabIndex = 3;
            this.NavButton.TabStop = true;
            this.NavButton.Text = "Nav";
            this.NavButton.UseVisualStyleBackColor = true;
            this.NavButton.CheckedChanged += new System.EventHandler(this.NavButton_CheckedChanged);
            // 
            // SumanButton
            // 
            this.SumanButton.AutoSize = true;
            this.SumanButton.Location = new System.Drawing.Point(172, 108);
            this.SumanButton.Margin = new System.Windows.Forms.Padding(4);
            this.SumanButton.Name = "SumanButton";
            this.SumanButton.Size = new System.Drawing.Size(81, 22);
            this.SumanButton.TabIndex = 2;
            this.SumanButton.Text = "Suman";
            this.SumanButton.UseVisualStyleBackColor = true;
            this.SumanButton.CheckedChanged += new System.EventHandler(this.SumanButton_CheckedChanged);
            // 
            // HappyButton
            // 
            this.HappyButton.AutoSize = true;
            this.HappyButton.Location = new System.Drawing.Point(172, 78);
            this.HappyButton.Margin = new System.Windows.Forms.Padding(4);
            this.HappyButton.Name = "HappyButton";
            this.HappyButton.Size = new System.Drawing.Size(76, 22);
            this.HappyButton.TabIndex = 1;
            this.HappyButton.Text = "Happy";
            this.HappyButton.UseVisualStyleBackColor = true;
            this.HappyButton.CheckedChanged += new System.EventHandler(this.HappyButton_CheckedChanged);
            // 
            // MaximumBet
            // 
            this.MaximumBet.AutoSize = true;
            this.MaximumBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumBet.Location = new System.Drawing.Point(168, 48);
            this.MaximumBet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MaximumBet.Name = "MaximumBet";
            this.MaximumBet.Size = new System.Drawing.Size(120, 20);
            this.MaximumBet.TabIndex = 0;
            this.MaximumBet.Text = "Maximum bet";
            // 
            // Dragon4
            // 
            this.Dragon4.Image = ((System.Drawing.Image)(resources.GetObject("Dragon4.Image")));
            this.Dragon4.Location = new System.Drawing.Point(23, 310);
            this.Dragon4.Margin = new System.Windows.Forms.Padding(4);
            this.Dragon4.Name = "Dragon4";
            this.Dragon4.Size = new System.Drawing.Size(96, 52);
            this.Dragon4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Dragon4.TabIndex = 4;
            this.Dragon4.TabStop = false;
            this.Dragon4.Click += new System.EventHandler(this.Dragon4_Click);
            // 
            // Dragon3
            // 
            this.Dragon3.Image = ((System.Drawing.Image)(resources.GetObject("Dragon3.Image")));
            this.Dragon3.Location = new System.Drawing.Point(23, 222);
            this.Dragon3.Margin = new System.Windows.Forms.Padding(4);
            this.Dragon3.Name = "Dragon3";
            this.Dragon3.Size = new System.Drawing.Size(96, 58);
            this.Dragon3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Dragon3.TabIndex = 3;
            this.Dragon3.TabStop = false;
            this.Dragon3.Click += new System.EventHandler(this.Dragon3_Click);
            // 
            // Dragon2
            // 
            this.Dragon2.Image = ((System.Drawing.Image)(resources.GetObject("Dragon2.Image")));
            this.Dragon2.Location = new System.Drawing.Point(23, 137);
            this.Dragon2.Margin = new System.Windows.Forms.Padding(4);
            this.Dragon2.Name = "Dragon2";
            this.Dragon2.Size = new System.Drawing.Size(96, 48);
            this.Dragon2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Dragon2.TabIndex = 2;
            this.Dragon2.TabStop = false;
            // 
            // Dragon1
            // 
            this.Dragon1.Image = ((System.Drawing.Image)(resources.GetObject("Dragon1.Image")));
            this.Dragon1.Location = new System.Drawing.Point(23, 40);
            this.Dragon1.Margin = new System.Windows.Forms.Padding(4);
            this.Dragon1.Name = "Dragon1";
            this.Dragon1.Size = new System.Drawing.Size(96, 67);
            this.Dragon1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Dragon1.TabIndex = 1;
            this.Dragon1.TabStop = false;
            // 
            // Racetrack
            // 
            this.Racetrack.BackColor = System.Drawing.SystemColors.Control;
            this.Racetrack.Image = ((System.Drawing.Image)(resources.GetObject("Racetrack.Image")));
            this.Racetrack.Location = new System.Drawing.Point(-39, 1);
            this.Racetrack.Margin = new System.Windows.Forms.Padding(4);
            this.Racetrack.Name = "Racetrack";
            this.Racetrack.Size = new System.Drawing.Size(1264, 661);
            this.Racetrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Racetrack.TabIndex = 0;
            this.Racetrack.TabStop = false;
            this.Racetrack.Click += new System.EventHandler(this.Racetrack_Click);
            // 
            // DragonRaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 661);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Dragon4);
            this.Controls.Add(this.Dragon3);
            this.Controls.Add(this.Dragon2);
            this.Controls.Add(this.Dragon1);
            this.Controls.Add(this.Racetrack);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DragonRaceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dragon Race";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DragonNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BettingAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dragon4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dragon3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dragon2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dragon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Racetrack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Racetrack;
        private System.Windows.Forms.PictureBox Dragon1;
        private System.Windows.Forms.PictureBox Dragon2;
        private System.Windows.Forms.PictureBox Dragon3;
        private System.Windows.Forms.PictureBox Dragon4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton NavButton;
        private System.Windows.Forms.RadioButton SumanButton;
        private System.Windows.Forms.RadioButton HappyButton;
        private System.Windows.Forms.Label MaximumBet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown BettingAmount;
        private System.Windows.Forms.Button Bets;
        private System.Windows.Forms.NumericUpDown DragonNumber;
        private System.Windows.Forms.Button race;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label HappyBet;
        private System.Windows.Forms.Label NavBet;
        private System.Windows.Forms.Label SumanBet;
    }
}
