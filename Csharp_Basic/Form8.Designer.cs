namespace Csharp_Basic
{
    partial class Form8
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
            this.File_Search_Input = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Button();
            this.InputID = new System.Windows.Forms.TextBox();
            this.InputPW = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // File_Search_Input
            // 
            this.File_Search_Input.Location = new System.Drawing.Point(53, 12);
            this.File_Search_Input.Name = "File_Search_Input";
            this.File_Search_Input.Size = new System.Drawing.Size(136, 51);
            this.File_Search_Input.TabIndex = 0;
            this.File_Search_Input.Text = "파일 정보 입력";
            this.File_Search_Input.UseVisualStyleBackColor = true;
            this.File_Search_Input.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(338, 79);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(75, 69);
            this.Login.TabIndex = 1;
            this.Login.Text = "로그인";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.button2_Click);
            // 
            // InputID
            // 
            this.InputID.Location = new System.Drawing.Point(87, 79);
            this.InputID.Name = "InputID";
            this.InputID.Size = new System.Drawing.Size(245, 25);
            this.InputID.TabIndex = 2;
            // 
            // InputPW
            // 
            this.InputPW.Location = new System.Drawing.Point(87, 123);
            this.InputPW.Name = "InputPW";
            this.InputPW.Size = new System.Drawing.Size(245, 25);
            this.InputPW.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "PW";
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 202);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputPW);
            this.Controls.Add(this.InputID);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.File_Search_Input);
            this.Name = "Form8";
            this.Text = "Form8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button File_Search_Input;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.TextBox InputID;
        private System.Windows.Forms.TextBox InputPW;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}