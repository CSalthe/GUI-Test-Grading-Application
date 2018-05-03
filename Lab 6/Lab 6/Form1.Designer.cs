namespace Lab_6
{
    partial class wpmGrader
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
            this.wpmTextBox = new System.Windows.Forms.TextBox();
            this.wpmLabel = new System.Windows.Forms.Label();
            this.wpmButton = new System.Windows.Forms.Button();
            this.gradeLabel = new System.Windows.Forms.Label();
            this.gradeOutPut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // wpmTextBox
            // 
            this.wpmTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.wpmTextBox.Location = new System.Drawing.Point(200, 85);
            this.wpmTextBox.Name = "wpmTextBox";
            this.wpmTextBox.Size = new System.Drawing.Size(100, 20);
            this.wpmTextBox.TabIndex = 0;
            // 
            // wpmLabel
            // 
            this.wpmLabel.AutoSize = true;
            this.wpmLabel.BackColor = System.Drawing.SystemColors.Info;
            this.wpmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.wpmLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.wpmLabel.Location = new System.Drawing.Point(87, 86);
            this.wpmLabel.Name = "wpmLabel";
            this.wpmLabel.Size = new System.Drawing.Size(107, 15);
            this.wpmLabel.TabIndex = 1;
            this.wpmLabel.Text = "Words per minute:";
            // 
            // wpmButton
            // 
            this.wpmButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.wpmButton.Location = new System.Drawing.Point(200, 175);
            this.wpmButton.Name = "wpmButton";
            this.wpmButton.Size = new System.Drawing.Size(100, 23);
            this.wpmButton.TabIndex = 2;
            this.wpmButton.Text = "Calculate Grade";
            this.wpmButton.UseVisualStyleBackColor = true;
            this.wpmButton.Click += new System.EventHandler(this.wpmButton_Click);
            // 
            // gradeLabel
            // 
            this.gradeLabel.AutoSize = true;
            this.gradeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.gradeLabel.Location = new System.Drawing.Point(98, 280);
            this.gradeLabel.Name = "gradeLabel";
            this.gradeLabel.Size = new System.Drawing.Size(96, 15);
            this.gradeLabel.TabIndex = 4;
            this.gradeLabel.Text = "Grade recieved: ";
            // 
            // gradeOutPut
            // 
            this.gradeOutPut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradeOutPut.Location = new System.Drawing.Point(200, 281);
            this.gradeOutPut.Name = "gradeOutPut";
            this.gradeOutPut.Size = new System.Drawing.Size(100, 20);
            this.gradeOutPut.TabIndex = 5;
            // 
            // wpmGrader
            // 
            this.AcceptButton = this.wpmButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(473, 355);
            this.Controls.Add(this.gradeOutPut);
            this.Controls.Add(this.gradeLabel);
            this.Controls.Add(this.wpmButton);
            this.Controls.Add(this.wpmLabel);
            this.Controls.Add(this.wpmTextBox);
            this.Name = "wpmGrader";
            this.Text = "Words Per Minute Grader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox wpmTextBox;
        private System.Windows.Forms.Label wpmLabel;
        private System.Windows.Forms.Button wpmButton;
        private System.Windows.Forms.Label gradeLabel;
        private System.Windows.Forms.Label gradeOutPut;
    }
}

