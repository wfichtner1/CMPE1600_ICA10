﻿namespace CMPE1600_ICA10
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
            this.UI_ColorDialogCheck = new System.Windows.Forms.CheckBox();
            this.UI_SizeDialogCheck = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UI_ColorLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UI_SizeLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // UI_ColorDialogCheck
            // 
            this.UI_ColorDialogCheck.AutoSize = true;
            this.UI_ColorDialogCheck.Location = new System.Drawing.Point(8, 34);
            this.UI_ColorDialogCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UI_ColorDialogCheck.Name = "UI_ColorDialogCheck";
            this.UI_ColorDialogCheck.Size = new System.Drawing.Size(145, 21);
            this.UI_ColorDialogCheck.TabIndex = 0;
            this.UI_ColorDialogCheck.Text = "Show Color Dialog";
            this.UI_ColorDialogCheck.UseVisualStyleBackColor = true;
            this.UI_ColorDialogCheck.CheckedChanged += new System.EventHandler(this.UI_ColorDialogCheck_CheckedChanged);
            // 
            // UI_SizeDialogCheck
            // 
            this.UI_SizeDialogCheck.AutoSize = true;
            this.UI_SizeDialogCheck.Location = new System.Drawing.Point(8, 62);
            this.UI_SizeDialogCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UI_SizeDialogCheck.Name = "UI_SizeDialogCheck";
            this.UI_SizeDialogCheck.Size = new System.Drawing.Size(139, 21);
            this.UI_SizeDialogCheck.TabIndex = 1;
            this.UI_SizeDialogCheck.Text = "Show Size Dialog";
            this.UI_SizeDialogCheck.UseVisualStyleBackColor = true;
            this.UI_SizeDialogCheck.CheckedChanged += new System.EventHandler(this.UI_SizeDialogCheck_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Drawing Color:";
            // 
            // UI_ColorLabel
            // 
            this.UI_ColorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UI_ColorLabel.Location = new System.Drawing.Point(275, 27);
            this.UI_ColorLabel.Name = "UI_ColorLabel";
            this.UI_ColorLabel.Size = new System.Drawing.Size(50, 25);
            this.UI_ColorLabel.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Circle Size:";
            // 
            // UI_SizeLabel
            // 
            this.UI_SizeLabel.AutoSize = true;
            this.UI_SizeLabel.Location = new System.Drawing.Point(271, 63);
            this.UI_SizeLabel.Name = "UI_SizeLabel";
            this.UI_SizeLabel.Size = new System.Drawing.Size(24, 17);
            this.UI_SizeLabel.TabIndex = 5;
            this.UI_SizeLabel.Text = "10";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 129);
            this.Controls.Add(this.UI_SizeLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UI_ColorLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UI_SizeDialogCheck);
            this.Controls.Add(this.UI_ColorDialogCheck);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Main Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox UI_ColorDialogCheck;
        private System.Windows.Forms.CheckBox UI_SizeDialogCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label UI_ColorLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label UI_SizeLabel;
        private System.Windows.Forms.Timer timer1;
    }
}

