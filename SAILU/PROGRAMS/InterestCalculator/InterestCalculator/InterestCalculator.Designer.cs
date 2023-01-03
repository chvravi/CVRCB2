namespace InterestCalculator
{
    partial class InterestCalculator
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
            this.lblPrincipal = new System.Windows.Forms.Label();
            this.txtPrincipal = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.lblRate = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.lblTimePeriod = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblSimpleInterest = new System.Windows.Forms.Label();
            this.lblCompoundInterest = new System.Windows.Forms.Label();
            this.txtSimpleInterest = new System.Windows.Forms.TextBox();
            this.txtCompoundInterest = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblPrincipal
            // 
            this.lblPrincipal.AutoSize = true;
            this.lblPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrincipal.Location = new System.Drawing.Point(40, 45);
            this.lblPrincipal.Name = "lblPrincipal";
            this.lblPrincipal.Size = new System.Drawing.Size(82, 24);
            this.lblPrincipal.TabIndex = 0;
            this.lblPrincipal.Text = "Principal";
            // 
            // txtPrincipal
            // 
            this.txtPrincipal.Location = new System.Drawing.Point(147, 48);
            this.txtPrincipal.Name = "txtPrincipal";
            this.txtPrincipal.Size = new System.Drawing.Size(135, 20);
            this.txtPrincipal.TabIndex = 1;
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(499, 45);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(135, 20);
            this.txtRate.TabIndex = 3;
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRate.Location = new System.Drawing.Point(371, 45);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(113, 24);
            this.lblRate.TabIndex = 2;
            this.lblRate.Text = "Interest Rate";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(874, 48);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(135, 20);
            this.txtTime.TabIndex = 5;
            // 
            // lblTimePeriod
            // 
            this.lblTimePeriod.AutoSize = true;
            this.lblTimePeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimePeriod.Location = new System.Drawing.Point(746, 48);
            this.lblTimePeriod.Name = "lblTimePeriod";
            this.lblTimePeriod.Size = new System.Drawing.Size(113, 24);
            this.lblTimePeriod.TabIndex = 4;
            this.lblTimePeriod.Text = "Time Period";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(467, 125);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(207, 33);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Calculate Interest";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblSimpleInterest
            // 
            this.lblSimpleInterest.AutoSize = true;
            this.lblSimpleInterest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSimpleInterest.Location = new System.Drawing.Point(44, 170);
            this.lblSimpleInterest.Name = "lblSimpleInterest";
            this.lblSimpleInterest.Size = new System.Drawing.Size(116, 20);
            this.lblSimpleInterest.TabIndex = 7;
            this.lblSimpleInterest.Text = "Simple Interest";
            // 
            // lblCompoundInterest
            // 
            this.lblCompoundInterest.AutoSize = true;
            this.lblCompoundInterest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompoundInterest.Location = new System.Drawing.Point(700, 170);
            this.lblCompoundInterest.Name = "lblCompoundInterest";
            this.lblCompoundInterest.Size = new System.Drawing.Size(146, 20);
            this.lblCompoundInterest.TabIndex = 8;
            this.lblCompoundInterest.Text = "Compound Interest";
            // 
            // txtSimpleInterest
            // 
            this.txtSimpleInterest.Location = new System.Drawing.Point(48, 212);
            this.txtSimpleInterest.Multiline = true;
            this.txtSimpleInterest.Name = "txtSimpleInterest";
            this.txtSimpleInterest.Size = new System.Drawing.Size(487, 302);
            this.txtSimpleInterest.TabIndex = 9;
            // 
            // txtCompoundInterest
            // 
            this.txtCompoundInterest.Location = new System.Drawing.Point(654, 212);
            this.txtCompoundInterest.Multiline = true;
            this.txtCompoundInterest.Name = "txtCompoundInterest";
            this.txtCompoundInterest.Size = new System.Drawing.Size(487, 302);
            this.txtCompoundInterest.TabIndex = 10;
            // 
            // InterestCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 513);
            this.Controls.Add(this.txtCompoundInterest);
            this.Controls.Add(this.txtSimpleInterest);
            this.Controls.Add(this.lblCompoundInterest);
            this.Controls.Add(this.lblSimpleInterest);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.lblTimePeriod);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.txtPrincipal);
            this.Controls.Add(this.lblPrincipal);
            this.Name = "InterestCalculator";
            this.Text = "Interest Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrincipal;
        private System.Windows.Forms.TextBox txtPrincipal;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label lblTimePeriod;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblSimpleInterest;
        private System.Windows.Forms.Label lblCompoundInterest;
        private System.Windows.Forms.TextBox txtSimpleInterest;
        private System.Windows.Forms.TextBox txtCompoundInterest;
    }
}

