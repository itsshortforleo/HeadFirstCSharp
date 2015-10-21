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
            this.pbRacetrack = new System.Windows.Forms.PictureBox();
            this.pbDogNumber1 = new System.Windows.Forms.PictureBox();
            this.pbDogNumber2 = new System.Windows.Forms.PictureBox();
            this.pbDogNumber3 = new System.Windows.Forms.PictureBox();
            this.pbDogNumber4 = new System.Windows.Forms.PictureBox();
            this.bettingParlorLabel = new System.Windows.Forms.Label();
            this.minimumBetLabel = new System.Windows.Forms.Label();
            this.rbJoeRadioButton = new System.Windows.Forms.RadioButton();
            this.rbBobRadioButton = new System.Windows.Forms.RadioButton();
            this.rbAlRadioButton = new System.Windows.Forms.RadioButton();
            this.lblBetsTitleInBold = new System.Windows.Forms.Label();
            this.lblJoeBetLabel = new System.Windows.Forms.Label();
            this.lblBobBetLabel = new System.Windows.Forms.Label();
            this.lblAlBetLabel = new System.Windows.Forms.Label();
            this.btnRace = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.nudAmountOfMoneyBet = new System.Windows.Forms.NumericUpDown();
            this.lblBucksOnDogNumber = new System.Windows.Forms.Label();
            this.nudDogToBetFor = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnBet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbRacetrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDogNumber1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDogNumber2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDogNumber3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDogNumber4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmountOfMoneyBet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDogToBetFor)).BeginInit();
            this.SuspendLayout();
            // 
            // pbRacetrack
            // 
            this.pbRacetrack.Image = ((System.Drawing.Image)(resources.GetObject("pbRacetrack.Image")));
            this.pbRacetrack.Location = new System.Drawing.Point(12, 12);
            this.pbRacetrack.Name = "pbRacetrack";
            this.pbRacetrack.Size = new System.Drawing.Size(600, 200);
            this.pbRacetrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbRacetrack.TabIndex = 0;
            this.pbRacetrack.TabStop = false;
            // 
            // pbDogNumber1
            // 
            this.pbDogNumber1.Image = ((System.Drawing.Image)(resources.GetObject("pbDogNumber1.Image")));
            this.pbDogNumber1.Location = new System.Drawing.Point(12, 22);
            this.pbDogNumber1.Name = "pbDogNumber1";
            this.pbDogNumber1.Size = new System.Drawing.Size(75, 25);
            this.pbDogNumber1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDogNumber1.TabIndex = 1;
            this.pbDogNumber1.TabStop = false;
            // 
            // pbDogNumber2
            // 
            this.pbDogNumber2.Image = ((System.Drawing.Image)(resources.GetObject("pbDogNumber2.Image")));
            this.pbDogNumber2.Location = new System.Drawing.Point(12, 71);
            this.pbDogNumber2.Name = "pbDogNumber2";
            this.pbDogNumber2.Size = new System.Drawing.Size(75, 24);
            this.pbDogNumber2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDogNumber2.TabIndex = 2;
            this.pbDogNumber2.TabStop = false;
            // 
            // pbDogNumber3
            // 
            this.pbDogNumber3.Image = ((System.Drawing.Image)(resources.GetObject("pbDogNumber3.Image")));
            this.pbDogNumber3.Location = new System.Drawing.Point(12, 116);
            this.pbDogNumber3.Name = "pbDogNumber3";
            this.pbDogNumber3.Size = new System.Drawing.Size(75, 28);
            this.pbDogNumber3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDogNumber3.TabIndex = 3;
            this.pbDogNumber3.TabStop = false;
            // 
            // pbDogNumber4
            // 
            this.pbDogNumber4.Image = ((System.Drawing.Image)(resources.GetObject("pbDogNumber4.Image")));
            this.pbDogNumber4.Location = new System.Drawing.Point(12, 176);
            this.pbDogNumber4.Name = "pbDogNumber4";
            this.pbDogNumber4.Size = new System.Drawing.Size(75, 25);
            this.pbDogNumber4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDogNumber4.TabIndex = 4;
            this.pbDogNumber4.TabStop = false;
            // 
            // bettingParlorLabel
            // 
            this.bettingParlorLabel.AutoSize = true;
            this.bettingParlorLabel.Location = new System.Drawing.Point(9, 215);
            this.bettingParlorLabel.Name = "bettingParlorLabel";
            this.bettingParlorLabel.Size = new System.Drawing.Size(70, 13);
            this.bettingParlorLabel.TabIndex = 5;
            this.bettingParlorLabel.Text = "Betting Parlor";
            // 
            // minimumBetLabel
            // 
            this.minimumBetLabel.AutoSize = true;
            this.minimumBetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimumBetLabel.Location = new System.Drawing.Point(10, 231);
            this.minimumBetLabel.Name = "minimumBetLabel";
            this.minimumBetLabel.Size = new System.Drawing.Size(104, 13);
            this.minimumBetLabel.TabIndex = 6;
            this.minimumBetLabel.Text = "minimumBetLabel";
            // 
            // rbJoeRadioButton
            // 
            this.rbJoeRadioButton.AutoSize = true;
            this.rbJoeRadioButton.Checked = true;
            this.rbJoeRadioButton.Location = new System.Drawing.Point(12, 247);
            this.rbJoeRadioButton.Name = "rbJoeRadioButton";
            this.rbJoeRadioButton.Size = new System.Drawing.Size(98, 17);
            this.rbJoeRadioButton.TabIndex = 7;
            this.rbJoeRadioButton.TabStop = true;
            this.rbJoeRadioButton.Text = "joeRadioButton";
            this.rbJoeRadioButton.UseVisualStyleBackColor = true;
            this.rbJoeRadioButton.CheckedChanged += new System.EventHandler(this.rbJoeRadioButton_CheckedChanged);
            // 
            // rbBobRadioButton
            // 
            this.rbBobRadioButton.AutoSize = true;
            this.rbBobRadioButton.Location = new System.Drawing.Point(12, 270);
            this.rbBobRadioButton.Name = "rbBobRadioButton";
            this.rbBobRadioButton.Size = new System.Drawing.Size(102, 17);
            this.rbBobRadioButton.TabIndex = 8;
            this.rbBobRadioButton.Text = "bobRadioButton";
            this.rbBobRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbBobRadioButton.UseVisualStyleBackColor = true;
            this.rbBobRadioButton.CheckedChanged += new System.EventHandler(this.rbBobRadioButton_CheckedChanged);
            // 
            // rbAlRadioButton
            // 
            this.rbAlRadioButton.AutoSize = true;
            this.rbAlRadioButton.Location = new System.Drawing.Point(12, 293);
            this.rbAlRadioButton.Name = "rbAlRadioButton";
            this.rbAlRadioButton.Size = new System.Drawing.Size(92, 17);
            this.rbAlRadioButton.TabIndex = 9;
            this.rbAlRadioButton.Text = "alRadioButton";
            this.rbAlRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbAlRadioButton.UseVisualStyleBackColor = true;
            this.rbAlRadioButton.CheckedChanged += new System.EventHandler(this.rbAlRadioButton_CheckedChanged);
            // 
            // lblBetsTitleInBold
            // 
            this.lblBetsTitleInBold.AutoSize = true;
            this.lblBetsTitleInBold.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBetsTitleInBold.Location = new System.Drawing.Point(211, 231);
            this.lblBetsTitleInBold.Name = "lblBetsTitleInBold";
            this.lblBetsTitleInBold.Size = new System.Drawing.Size(32, 13);
            this.lblBetsTitleInBold.TabIndex = 10;
            this.lblBetsTitleInBold.Text = "Bets";
            // 
            // lblJoeBetLabel
            // 
            this.lblJoeBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblJoeBetLabel.Location = new System.Drawing.Point(211, 249);
            this.lblJoeBetLabel.Name = "lblJoeBetLabel";
            this.lblJoeBetLabel.Size = new System.Drawing.Size(189, 15);
            this.lblJoeBetLabel.TabIndex = 11;
            this.lblJoeBetLabel.Text = "joeBetLabel";
            // 
            // lblBobBetLabel
            // 
            this.lblBobBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBobBetLabel.Location = new System.Drawing.Point(211, 272);
            this.lblBobBetLabel.Name = "lblBobBetLabel";
            this.lblBobBetLabel.Size = new System.Drawing.Size(189, 13);
            this.lblBobBetLabel.TabIndex = 12;
            this.lblBobBetLabel.Text = "bobBetLabel";
            // 
            // lblAlBetLabel
            // 
            this.lblAlBetLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAlBetLabel.Location = new System.Drawing.Point(211, 293);
            this.lblAlBetLabel.Name = "lblAlBetLabel";
            this.lblAlBetLabel.Size = new System.Drawing.Size(189, 13);
            this.lblAlBetLabel.TabIndex = 13;
            this.lblAlBetLabel.Text = "alBetLabel";
            // 
            // btnRace
            // 
            this.btnRace.Location = new System.Drawing.Point(459, 247);
            this.btnRace.Name = "btnRace";
            this.btnRace.Size = new System.Drawing.Size(152, 92);
            this.btnRace.TabIndex = 14;
            this.btnRace.Text = "Race!";
            this.btnRace.UseVisualStyleBackColor = true;
            this.btnRace.Click += new System.EventHandler(this.btnRace_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 325);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(33, 13);
            this.lblName.TabIndex = 15;
            this.lblName.Text = "name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudAmountOfMoneyBet
            // 
            this.nudAmountOfMoneyBet.Location = new System.Drawing.Point(88, 322);
            this.nudAmountOfMoneyBet.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudAmountOfMoneyBet.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudAmountOfMoneyBet.Name = "nudAmountOfMoneyBet";
            this.nudAmountOfMoneyBet.Size = new System.Drawing.Size(49, 20);
            this.nudAmountOfMoneyBet.TabIndex = 17;
            this.nudAmountOfMoneyBet.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lblBucksOnDogNumber
            // 
            this.lblBucksOnDogNumber.AutoSize = true;
            this.lblBucksOnDogNumber.Location = new System.Drawing.Point(143, 325);
            this.lblBucksOnDogNumber.Name = "lblBucksOnDogNumber";
            this.lblBucksOnDogNumber.Size = new System.Drawing.Size(110, 13);
            this.lblBucksOnDogNumber.TabIndex = 18;
            this.lblBucksOnDogNumber.Text = "bucks on dog number";
            // 
            // nudDogToBetFor
            // 
            this.nudDogToBetFor.Location = new System.Drawing.Point(259, 323);
            this.nudDogToBetFor.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudDogToBetFor.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDogToBetFor.Name = "nudDogToBetFor";
            this.nudDogToBetFor.Size = new System.Drawing.Size(41, 20);
            this.nudDogToBetFor.TabIndex = 19;
            this.nudDogToBetFor.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnBet
            // 
            this.btnBet.Location = new System.Drawing.Point(44, 320);
            this.btnBet.Name = "btnBet";
            this.btnBet.Size = new System.Drawing.Size(41, 23);
            this.btnBet.TabIndex = 20;
            this.btnBet.Text = "Bets";
            this.btnBet.UseVisualStyleBackColor = true;
            this.btnBet.Click += new System.EventHandler(this.btnBet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 351);
            this.Controls.Add(this.btnBet);
            this.Controls.Add(this.nudDogToBetFor);
            this.Controls.Add(this.lblBucksOnDogNumber);
            this.Controls.Add(this.nudAmountOfMoneyBet);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnRace);
            this.Controls.Add(this.lblAlBetLabel);
            this.Controls.Add(this.lblBobBetLabel);
            this.Controls.Add(this.lblJoeBetLabel);
            this.Controls.Add(this.lblBetsTitleInBold);
            this.Controls.Add(this.rbAlRadioButton);
            this.Controls.Add(this.rbBobRadioButton);
            this.Controls.Add(this.rbJoeRadioButton);
            this.Controls.Add(this.minimumBetLabel);
            this.Controls.Add(this.bettingParlorLabel);
            this.Controls.Add(this.pbDogNumber4);
            this.Controls.Add(this.pbDogNumber3);
            this.Controls.Add(this.pbDogNumber2);
            this.Controls.Add(this.pbDogNumber1);
            this.Controls.Add(this.pbRacetrack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "A Day at the Races";
            ((System.ComponentModel.ISupportInitialize)(this.pbRacetrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDogNumber1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDogNumber2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDogNumber3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDogNumber4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmountOfMoneyBet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDogToBetFor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbRacetrack;
        private System.Windows.Forms.PictureBox pbDogNumber1;
        private System.Windows.Forms.PictureBox pbDogNumber2;
        private System.Windows.Forms.PictureBox pbDogNumber3;
        private System.Windows.Forms.PictureBox pbDogNumber4;
        private System.Windows.Forms.Label bettingParlorLabel;
        private System.Windows.Forms.Label minimumBetLabel;
        private System.Windows.Forms.RadioButton rbJoeRadioButton;
        private System.Windows.Forms.RadioButton rbBobRadioButton;
        private System.Windows.Forms.RadioButton rbAlRadioButton;
        private System.Windows.Forms.Label lblBetsTitleInBold;
        private System.Windows.Forms.Label lblJoeBetLabel;
        private System.Windows.Forms.Label lblBobBetLabel;
        private System.Windows.Forms.Label lblAlBetLabel;
        private System.Windows.Forms.Button btnRace;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.NumericUpDown nudAmountOfMoneyBet;
        private System.Windows.Forms.Label lblBucksOnDogNumber;
        private System.Windows.Forms.NumericUpDown nudDogToBetFor;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnBet;
    }
}

