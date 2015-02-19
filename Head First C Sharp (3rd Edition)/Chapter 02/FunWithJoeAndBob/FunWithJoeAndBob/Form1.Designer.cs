namespace FunWithJoeAndBob
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
            this.btnGive10ToJoe = new System.Windows.Forms.Button();
            this.btnReceive5FromBob = new System.Windows.Forms.Button();
            this.joesCashLabel = new System.Windows.Forms.Label();
            this.bobsCashLabel = new System.Windows.Forms.Label();
            this.bankCashLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGive10ToJoe
            // 
            this.btnGive10ToJoe.Location = new System.Drawing.Point(15, 90);
            this.btnGive10ToJoe.Name = "btnGive10ToJoe";
            this.btnGive10ToJoe.Size = new System.Drawing.Size(83, 38);
            this.btnGive10ToJoe.TabIndex = 0;
            this.btnGive10ToJoe.Text = "Give $10 to Joe";
            this.btnGive10ToJoe.UseVisualStyleBackColor = true;
            this.btnGive10ToJoe.Click += new System.EventHandler(this.btnGive10ToJoe_Click);
            // 
            // btnReceive5FromBob
            // 
            this.btnReceive5FromBob.Location = new System.Drawing.Point(104, 90);
            this.btnReceive5FromBob.Name = "btnReceive5FromBob";
            this.btnReceive5FromBob.Size = new System.Drawing.Size(75, 38);
            this.btnReceive5FromBob.TabIndex = 1;
            this.btnReceive5FromBob.Text = "Receive $5 from Bob";
            this.btnReceive5FromBob.UseVisualStyleBackColor = true;
            this.btnReceive5FromBob.Click += new System.EventHandler(this.btnReceive5FromBob_Click);
            // 
            // joesCashLabel
            // 
            this.joesCashLabel.AutoSize = true;
            this.joesCashLabel.Location = new System.Drawing.Point(12, 9);
            this.joesCashLabel.Name = "joesCashLabel";
            this.joesCashLabel.Size = new System.Drawing.Size(35, 13);
            this.joesCashLabel.TabIndex = 2;
            this.joesCashLabel.Text = "label1";
            // 
            // bobsCashLabel
            // 
            this.bobsCashLabel.AutoSize = true;
            this.bobsCashLabel.Location = new System.Drawing.Point(12, 34);
            this.bobsCashLabel.Name = "bobsCashLabel";
            this.bobsCashLabel.Size = new System.Drawing.Size(35, 13);
            this.bobsCashLabel.TabIndex = 3;
            this.bobsCashLabel.Text = "label2";
            // 
            // bankCashLabel
            // 
            this.bankCashLabel.AutoSize = true;
            this.bankCashLabel.Location = new System.Drawing.Point(12, 61);
            this.bankCashLabel.Name = "bankCashLabel";
            this.bankCashLabel.Size = new System.Drawing.Size(35, 13);
            this.bankCashLabel.TabIndex = 4;
            this.bankCashLabel.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 151);
            this.Controls.Add(this.bankCashLabel);
            this.Controls.Add(this.bobsCashLabel);
            this.Controls.Add(this.joesCashLabel);
            this.Controls.Add(this.btnReceive5FromBob);
            this.Controls.Add(this.btnGive10ToJoe);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Fun with Joe and Bob";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGive10ToJoe;
        private System.Windows.Forms.Button btnReceive5FromBob;
        private System.Windows.Forms.Label joesCashLabel;
        private System.Windows.Forms.Label bobsCashLabel;
        private System.Windows.Forms.Label bankCashLabel;
    }
}

