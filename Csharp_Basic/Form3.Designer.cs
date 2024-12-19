namespace Csharp_Basic
{
    partial class Form3
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
            this.InputTxt = new System.Windows.Forms.TextBox();
            this.InputButton = new System.Windows.Forms.Button();
            this.Monday = new System.Windows.Forms.RadioButton();
            this.Tuesday = new System.Windows.Forms.RadioButton();
            this.Wednesday = new System.Windows.Forms.RadioButton();
            this.Thursday = new System.Windows.Forms.RadioButton();
            this.Friday = new System.Windows.Forms.RadioButton();
            this.Saturday = new System.Windows.Forms.RadioButton();
            this.Sunday = new System.Windows.Forms.RadioButton();
            this.OutputTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // InputTxt
            // 
            this.InputTxt.Location = new System.Drawing.Point(13, 13);
            this.InputTxt.Name = "InputTxt";
            this.InputTxt.Size = new System.Drawing.Size(255, 25);
            this.InputTxt.TabIndex = 0;
            // 
            // InputButton
            // 
            this.InputButton.Location = new System.Drawing.Point(274, 12);
            this.InputButton.Name = "InputButton";
            this.InputButton.Size = new System.Drawing.Size(75, 27);
            this.InputButton.TabIndex = 1;
            this.InputButton.Text = "입력";
            this.InputButton.UseVisualStyleBackColor = true;
            this.InputButton.Click += new System.EventHandler(this.InputButton_Click);
            // 
            // Monday
            // 
            this.Monday.AutoSize = true;
            this.Monday.Location = new System.Drawing.Point(13, 45);
            this.Monday.Name = "Monday";
            this.Monday.Size = new System.Drawing.Size(43, 19);
            this.Monday.TabIndex = 2;
            this.Monday.TabStop = true;
            this.Monday.Text = "월";
            this.Monday.UseVisualStyleBackColor = true;
            this.Monday.Click += new System.EventHandler(this.Monday_Click);
            // 
            // Tuesday
            // 
            this.Tuesday.AutoSize = true;
            this.Tuesday.Location = new System.Drawing.Point(62, 45);
            this.Tuesday.Name = "Tuesday";
            this.Tuesday.Size = new System.Drawing.Size(43, 19);
            this.Tuesday.TabIndex = 3;
            this.Tuesday.TabStop = true;
            this.Tuesday.Text = "화";
            this.Tuesday.UseVisualStyleBackColor = true;
            this.Tuesday.Click += new System.EventHandler(this.Tuesday_Click);
            // 
            // Wednesday
            // 
            this.Wednesday.AutoSize = true;
            this.Wednesday.Location = new System.Drawing.Point(111, 45);
            this.Wednesday.Name = "Wednesday";
            this.Wednesday.Size = new System.Drawing.Size(43, 19);
            this.Wednesday.TabIndex = 4;
            this.Wednesday.TabStop = true;
            this.Wednesday.Text = "수";
            this.Wednesday.UseVisualStyleBackColor = true;
            this.Wednesday.Click += new System.EventHandler(this.Wednesday_Click);
            // 
            // Thursday
            // 
            this.Thursday.AutoSize = true;
            this.Thursday.Location = new System.Drawing.Point(160, 45);
            this.Thursday.Name = "Thursday";
            this.Thursday.Size = new System.Drawing.Size(43, 19);
            this.Thursday.TabIndex = 5;
            this.Thursday.TabStop = true;
            this.Thursday.Text = "목";
            this.Thursday.UseVisualStyleBackColor = true;
            this.Thursday.Click += new System.EventHandler(this.Thursday_Click);
            // 
            // Friday
            // 
            this.Friday.AutoSize = true;
            this.Friday.Location = new System.Drawing.Point(209, 45);
            this.Friday.Name = "Friday";
            this.Friday.Size = new System.Drawing.Size(43, 19);
            this.Friday.TabIndex = 6;
            this.Friday.TabStop = true;
            this.Friday.Text = "금";
            this.Friday.UseVisualStyleBackColor = true;
            this.Friday.Click += new System.EventHandler(this.Friday_Click);
            // 
            // Saturday
            // 
            this.Saturday.AutoSize = true;
            this.Saturday.Location = new System.Drawing.Point(258, 45);
            this.Saturday.Name = "Saturday";
            this.Saturday.Size = new System.Drawing.Size(43, 19);
            this.Saturday.TabIndex = 7;
            this.Saturday.TabStop = true;
            this.Saturday.Text = "토";
            this.Saturday.UseVisualStyleBackColor = true;
            this.Saturday.Click += new System.EventHandler(this.Saturday_Click);
            // 
            // Sunday
            // 
            this.Sunday.AutoSize = true;
            this.Sunday.Location = new System.Drawing.Point(307, 45);
            this.Sunday.Name = "Sunday";
            this.Sunday.Size = new System.Drawing.Size(43, 19);
            this.Sunday.TabIndex = 8;
            this.Sunday.TabStop = true;
            this.Sunday.Text = "일";
            this.Sunday.UseVisualStyleBackColor = true;
            this.Sunday.Click += new System.EventHandler(this.Sunday_Click);
            // 
            // OutputTxt
            // 
            this.OutputTxt.Location = new System.Drawing.Point(13, 70);
            this.OutputTxt.Multiline = true;
            this.OutputTxt.Name = "OutputTxt";
            this.OutputTxt.Size = new System.Drawing.Size(337, 232);
            this.OutputTxt.TabIndex = 9;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 312);
            this.Controls.Add(this.OutputTxt);
            this.Controls.Add(this.Sunday);
            this.Controls.Add(this.Saturday);
            this.Controls.Add(this.Friday);
            this.Controls.Add(this.Thursday);
            this.Controls.Add(this.Wednesday);
            this.Controls.Add(this.Tuesday);
            this.Controls.Add(this.Monday);
            this.Controls.Add(this.InputButton);
            this.Controls.Add(this.InputTxt);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputTxt;
        private System.Windows.Forms.Button InputButton;
        private System.Windows.Forms.RadioButton Monday;
        private System.Windows.Forms.RadioButton Tuesday;
        private System.Windows.Forms.RadioButton Wednesday;
        private System.Windows.Forms.RadioButton Thursday;
        private System.Windows.Forms.RadioButton Friday;
        private System.Windows.Forms.RadioButton Saturday;
        private System.Windows.Forms.RadioButton Sunday;
        private System.Windows.Forms.TextBox OutputTxt;
    }
}