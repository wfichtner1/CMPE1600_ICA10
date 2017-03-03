namespace CMPE1600_ICA10
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
            this.UI_ColorDialogCheck = new System.Windows.Forms.CheckBox();
            this.UI_SizeDialogCheck = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UI_ColorDialogCheck
            // 
            this.UI_ColorDialogCheck.AutoSize = true;
            this.UI_ColorDialogCheck.Location = new System.Drawing.Point(8, 35);
            this.UI_ColorDialogCheck.Name = "UI_ColorDialogCheck";
            this.UI_ColorDialogCheck.Size = new System.Drawing.Size(145, 21);
            this.UI_ColorDialogCheck.TabIndex = 0;
            this.UI_ColorDialogCheck.Text = "Show Color Dialog";
            this.UI_ColorDialogCheck.UseVisualStyleBackColor = true;
            // 
            // UI_SizeDialogCheck
            // 
            this.UI_SizeDialogCheck.AutoSize = true;
            this.UI_SizeDialogCheck.Location = new System.Drawing.Point(8, 62);
            this.UI_SizeDialogCheck.Name = "UI_SizeDialogCheck";
            this.UI_SizeDialogCheck.Size = new System.Drawing.Size(139, 21);
            this.UI_SizeDialogCheck.TabIndex = 1;
            this.UI_SizeDialogCheck.Text = "Show Size Dialog";
            this.UI_SizeDialogCheck.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Drawing Color:";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(274, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 25);
            this.label2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Circle Size:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(271, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 129);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UI_SizeDialogCheck);
            this.Controls.Add(this.UI_ColorDialogCheck);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox UI_ColorDialogCheck;
        private System.Windows.Forms.CheckBox UI_SizeDialogCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

