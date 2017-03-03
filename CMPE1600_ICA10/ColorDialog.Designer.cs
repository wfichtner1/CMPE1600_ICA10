﻿namespace CMPE1600_ICA10
{
    partial class ColorDialog
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
            this.UI_RedTrack = new System.Windows.Forms.TrackBar();
            this.UI_GreenTrack = new System.Windows.Forms.TrackBar();
            this.UI_BlueTrack = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UI_ColorBox = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UI_RedTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UI_GreenTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UI_BlueTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // UI_RedTrack
            // 
            this.UI_RedTrack.Location = new System.Drawing.Point(12, 63);
            this.UI_RedTrack.Maximum = 255;
            this.UI_RedTrack.Name = "UI_RedTrack";
            this.UI_RedTrack.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.UI_RedTrack.Size = new System.Drawing.Size(45, 104);
            this.UI_RedTrack.TabIndex = 0;
            this.UI_RedTrack.Scroll += new System.EventHandler(this.UI_RedTrack_Scroll);
            // 
            // UI_GreenTrack
            // 
            this.UI_GreenTrack.Location = new System.Drawing.Point(63, 63);
            this.UI_GreenTrack.Maximum = 255;
            this.UI_GreenTrack.Name = "UI_GreenTrack";
            this.UI_GreenTrack.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.UI_GreenTrack.Size = new System.Drawing.Size(45, 104);
            this.UI_GreenTrack.TabIndex = 1;
            this.UI_GreenTrack.Scroll += new System.EventHandler(this.UI_GreenTrack_Scroll);
            // 
            // UI_BlueTrack
            // 
            this.UI_BlueTrack.Location = new System.Drawing.Point(114, 63);
            this.UI_BlueTrack.Maximum = 255;
            this.UI_BlueTrack.Name = "UI_BlueTrack";
            this.UI_BlueTrack.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.UI_BlueTrack.Size = new System.Drawing.Size(45, 104);
            this.UI_BlueTrack.TabIndex = 2;
            this.UI_BlueTrack.Scroll += new System.EventHandler(this.UI_BlueTrack_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Red";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Green";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Blue";
            // 
            // UI_ColorBox
            // 
            this.UI_ColorBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UI_ColorBox.Location = new System.Drawing.Point(184, 94);
            this.UI_ColorBox.Name = "UI_ColorBox";
            this.UI_ColorBox.Size = new System.Drawing.Size(50, 25);
            this.UI_ColorBox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(181, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Color:";
            // 
            // ColorDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.UI_ColorBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UI_BlueTrack);
            this.Controls.Add(this.UI_GreenTrack);
            this.Controls.Add(this.UI_RedTrack);
            this.Name = "ColorDialog";
            this.Text = "Color";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ColorDialog_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.UI_RedTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UI_GreenTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UI_BlueTrack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar UI_RedTrack;
        private System.Windows.Forms.TrackBar UI_GreenTrack;
        private System.Windows.Forms.TrackBar UI_BlueTrack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label UI_ColorBox;
        private System.Windows.Forms.Label label5;
    }
}