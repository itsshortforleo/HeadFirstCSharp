namespace BeehiveManagementSystem2
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
            this.lblJob = new System.Windows.Forms.Label();
            this.cbWorkerBeeJob = new System.Windows.Forms.ComboBox();
            this.lblShifts = new System.Windows.Forms.Label();
            this.nudShifts = new System.Windows.Forms.NumericUpDown();
            this.btnWorkTheNextShift = new System.Windows.Forms.Button();
            this.btnAssignThisJobToABee = new System.Windows.Forms.Button();
            this.gbWorkerBeeAssignments = new System.Windows.Forms.GroupBox();
            this.tbReport = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudShifts)).BeginInit();
            this.SuspendLayout();
            // 
            // lblJob
            // 
            this.lblJob.AutoSize = true;
            this.lblJob.Location = new System.Drawing.Point(29, 53);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(31, 17);
            this.lblJob.TabIndex = 1;
            this.lblJob.Text = "Job";
            // 
            // cbWorkerBeeJob
            // 
            this.cbWorkerBeeJob.FormattingEnabled = true;
            this.cbWorkerBeeJob.Items.AddRange(new object[] {
            "Nectar collector",
            "Honey manufacturing",
            "Egg care",
            "Baby bee tutoring",
            "Hive maintenance",
            "Sting patrol"});
            this.cbWorkerBeeJob.Location = new System.Drawing.Point(32, 74);
            this.cbWorkerBeeJob.Name = "cbWorkerBeeJob";
            this.cbWorkerBeeJob.Size = new System.Drawing.Size(199, 24);
            this.cbWorkerBeeJob.TabIndex = 2;
            // 
            // lblShifts
            // 
            this.lblShifts.AutoSize = true;
            this.lblShifts.Location = new System.Drawing.Point(238, 53);
            this.lblShifts.Name = "lblShifts";
            this.lblShifts.Size = new System.Drawing.Size(43, 17);
            this.lblShifts.TabIndex = 3;
            this.lblShifts.Text = "Shifts";
            // 
            // nudShifts
            // 
            this.nudShifts.Location = new System.Drawing.Point(241, 74);
            this.nudShifts.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudShifts.Name = "nudShifts";
            this.nudShifts.Size = new System.Drawing.Size(120, 22);
            this.nudShifts.TabIndex = 4;
            this.nudShifts.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnWorkTheNextShift
            // 
            this.btnWorkTheNextShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWorkTheNextShift.Location = new System.Drawing.Point(390, 13);
            this.btnWorkTheNextShift.Name = "btnWorkTheNextShift";
            this.btnWorkTheNextShift.Size = new System.Drawing.Size(212, 133);
            this.btnWorkTheNextShift.TabIndex = 5;
            this.btnWorkTheNextShift.Text = "Work the next shift";
            this.btnWorkTheNextShift.UseVisualStyleBackColor = true;
            this.btnWorkTheNextShift.Click += new System.EventHandler(this.btnWorkTheNextShift_Click);
            // 
            // btnAssignThisJobToABee
            // 
            this.btnAssignThisJobToABee.Location = new System.Drawing.Point(32, 105);
            this.btnAssignThisJobToABee.Name = "btnAssignThisJobToABee";
            this.btnAssignThisJobToABee.Size = new System.Drawing.Size(329, 28);
            this.btnAssignThisJobToABee.TabIndex = 6;
            this.btnAssignThisJobToABee.Text = "Assign this job to a bee";
            this.btnAssignThisJobToABee.UseVisualStyleBackColor = true;
            this.btnAssignThisJobToABee.Click += new System.EventHandler(this.btnAssignThisJobToABee_Click);
            // 
            // gbWorkerBeeAssignments
            // 
            this.gbWorkerBeeAssignments.Location = new System.Drawing.Point(13, 13);
            this.gbWorkerBeeAssignments.Name = "gbWorkerBeeAssignments";
            this.gbWorkerBeeAssignments.Size = new System.Drawing.Size(371, 133);
            this.gbWorkerBeeAssignments.TabIndex = 7;
            this.gbWorkerBeeAssignments.TabStop = false;
            this.gbWorkerBeeAssignments.Text = "Worker Bee Assignments";
            // 
            // tbReport
            // 
            this.tbReport.Location = new System.Drawing.Point(13, 153);
            this.tbReport.Multiline = true;
            this.tbReport.Name = "tbReport";
            this.tbReport.Size = new System.Drawing.Size(589, 253);
            this.tbReport.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 418);
            this.Controls.Add(this.tbReport);
            this.Controls.Add(this.btnAssignThisJobToABee);
            this.Controls.Add(this.btnWorkTheNextShift);
            this.Controls.Add(this.nudShifts);
            this.Controls.Add(this.lblShifts);
            this.Controls.Add(this.cbWorkerBeeJob);
            this.Controls.Add(this.lblJob);
            this.Controls.Add(this.gbWorkerBeeAssignments);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "                                        Beehive Management System";
            ((System.ComponentModel.ISupportInitialize)(this.nudShifts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblJob;
        private System.Windows.Forms.ComboBox cbWorkerBeeJob;
        private System.Windows.Forms.Label lblShifts;
        private System.Windows.Forms.NumericUpDown nudShifts;
        private System.Windows.Forms.Button btnWorkTheNextShift;
        private System.Windows.Forms.Button btnAssignThisJobToABee;
        private System.Windows.Forms.GroupBox gbWorkerBeeAssignments;
        private System.Windows.Forms.TextBox tbReport;
    }
}

